using AtividadeString.Core.Contracts;
using System.Collections.Generic;
using System.Text;
using MatrixCalculator.Core;
using MatrixCalculator.Core.Contracts;
using MatrixCalculator.Core.Models;
using System;

namespace AtividadeString.Core.Tools.Complementary
{
    public class Criptografador : ICriptografador, IDescriptografador
    {
        private readonly IList<char> alfabeto = new List<char>(new char[]{ 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
            'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
            'w', 'x', 'y', 'z', ' ', '1', '2', '3',
            '4', '5', '6', '7', '8', '9', '0'
        });

        private readonly Matrix _pin;
        private readonly IMatrixCalculator _calculadoraDeMatrizes;

        public Criptografador(Matrix pin) : this(pin, new Calculator()) { }

        public Criptografador(Matrix pin, IMatrixCalculator calculadoraDeMatrizes)
        {
            _pin = pin;
            _calculadoraDeMatrizes = calculadoraDeMatrizes;
        }

        public string Criptografar(string mensagem)
        {
            int quantidadeDeLetras = mensagem.Length;

            if (quantidadeDeLetras % _pin.NumberOfColumns != 0)
                mensagem += " ";

            Matrix matrizCorrespondente = ConverterMensagemParaMatrizDeInteiros(mensagem, c => {
                if (alfabeto.Contains(c)) 
                    return alfabeto.IndexOf(c);
                else
                    return (int)c * 10;
            });

            Matrix matrizCodificada = _calculadoraDeMatrizes.Product(_pin, matrizCorrespondente);

            return ConverterMatrizCodificada(matrizCodificada);
        }

        public string Descriptografar(string mensagemCriptografada)
        {
            Matrix matrizCorrespondente = ConverterMensagemParaMatrizDeInteiros(mensagemCriptografada, c => (int)c);
            Matrix matrizDecodificada = _calculadoraDeMatrizes.Product(_calculadoraDeMatrizes.Inverse(_pin), matrizCorrespondente);

            return ConverterMatrizDecodificada(matrizDecodificada);
        }

        private string ConverterMatrizDecodificada(Matrix matriz)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < matriz.NumberOfRows; i++)
            {
                for(int j = 0; j < matriz.NumberOfColumns; j++)
                {
                    int itemInteiro = (int) matriz.GetItem(i, j);
                    double item = matriz.GetItem(i, j);

                    if (itemInteiro < 0 || item != itemInteiro)
                    {
                        return "Indescriptografavel";
                    }
                    else if(itemInteiro > alfabeto.Count)
                    {
                        sb.Append((char) itemInteiro / 10);
                    }
                    else
                    {
                        sb.Append(alfabeto[itemInteiro]);
                    }
                }
            }

            return sb.ToString();
        }
        private string ConverterMatrizCodificada(Matrix matriz)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matriz.NumberOfRows; i++)
            {
                for (int j = 0; j < matriz.NumberOfColumns; j++)
                {
                    sb.Append(matriz.GetItem(i, j));

                    if (i == matriz.NumberOfRows - 1)
                    {
                        if (j < matriz.NumberOfColumns - 1)
                            sb.Append(".");
                    } else sb.Append(".");
                }
            }

            return sb.ToString();
        }
        private int CalcularQuantidadeDeColunas(string mensagem)
        {
            int quantidadeDeColunas = mensagem.Length / _pin.NumberOfRows;

            return quantidadeDeColunas;
        }
        
        public Matrix ConverterMensagemParaMatrizDeInteiros(string mensagem, Func<char, int> converterEmInteiro)
        {
            int quantidadeDeColunas = CalcularQuantidadeDeColunas(mensagem);

            double[,] matriz = new double[2,quantidadeDeColunas];

            int i = 0, j = 0;
            foreach(char c in mensagem)
            {
                if (j == quantidadeDeColunas)
                {
                    j = 0;
                    i++;
                }

                matriz[i, j] = converterEmInteiro(c);

                j++;
            }

            return new Matrix(2, quantidadeDeColunas, matriz);
        }


    }
}
