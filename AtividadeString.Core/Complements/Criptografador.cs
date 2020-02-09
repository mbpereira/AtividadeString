using AtividadeString.Common.Contracts;
using AtividadeString.Common.Models;
using System.Collections.Generic;
using System.Text;

namespace AtividadeString.Core.Complements
{
    public class Criptografador : ICriptografador
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
        private readonly Matriz _pin;
        private readonly IMatrizOperacoes _matrizOperacoes;
        public Criptografador(IMatrizOperacoes matrizOperacoes, Matriz pin)
        {
            _matrizOperacoes = matrizOperacoes;
            _pin = pin;
        }

        public string Criptografar(string mensagem)
        {
            int quantidadeDeLetras = mensagem.Length;

            if (quantidadeDeLetras % _pin.QuantidadeColunas != 0)
                mensagem += " ";

            int quantidadeDeColunas = CalcularQuantidadeDeColunas(mensagem);
            Matriz matrizCorrespondente = new Matriz(_pin.QuantidadeLinhas, quantidadeDeColunas, CriarMatrizCorrespondente(mensagem));

            Matriz matrizCodificada = _matrizOperacoes.CalcularProduto(_pin, matrizCorrespondente);

            return ConverterMatrizCodificada(matrizCodificada);
        }

        private string ConverterMatrizCodificada(Matriz matriz)
        {
            StringBuilder sb = new StringBuilder();



            for (int i = 0; i < matriz.QuantidadeLinhas; i++)
            {
                for (int j = 0; j < matriz.QuantidadeColunas; j++)
                {
                    sb.Append(matriz.Conteudo[i, j]);

                    if (i == matriz.QuantidadeLinhas - 1)
                    {
                        if (j < matriz.QuantidadeColunas - 1)
                            sb.Append("$");
                    } else sb.Append("$");
                }
            }


            return sb.ToString();
        }

        private int CalcularQuantidadeDeColunas(string mensagem)
        {


            int quantidadeDeColunas = mensagem.Length / _pin.QuantidadeLinhas;

            return quantidadeDeColunas;
        }
        public int[,] CriarMatrizCorrespondente(string mensagem)
        {
            int quantidadeDeColunas = CalcularQuantidadeDeColunas(mensagem);

            int[,] matriz = new int[2,quantidadeDeColunas];

            int i = 0, j = 0;
            foreach(char c in mensagem)
            {
                if (j == quantidadeDeColunas)
                {
                    j = 0;
                    i += 1;
                }
                if (alfabeto.Contains(c)) 
                    matriz[i, j] = alfabeto.IndexOf(c);
                else
                    matriz[i, j] = (int)c * 10;

                j++;
            }

            return matriz;
        }
        public string Descriptografar(string mensagemCriptografada)
        {
            return "";
        }
    }
}
