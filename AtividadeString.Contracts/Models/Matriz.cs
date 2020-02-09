using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeString.Common.Models
{
    public class Matriz
    {

        public int[,] Conteudo { get; private set; }
        public int QuantidadeLinhas { get; private set;  }
        public int QuantidadeColunas { get; private set; }

        public Matriz(int quantidadeLinhas, int quantidadeColunas, int[,] matriz)
        {
            QuantidadeLinhas = quantidadeLinhas;
            QuantidadeColunas = quantidadeColunas;
            Conteudo = matriz;
        }

        public void CopiarDe(int[,] matriz)
        {
            Conteudo = matriz;
        }

        public void Definir(int linha, int coluna, int valor)
        {
            if (linha > QuantidadeColunas - 1 || coluna > QuantidadeLinhas - 1)
                throw new IndexOutOfRangeException();

            Conteudo[linha, coluna] = valor;
        }


        public int Recuperar(int linha, int coluna)
        {
            if (linha > QuantidadeLinhas - 1 || coluna > QuantidadeColunas - 1)
                throw new IndexOutOfRangeException();

            return Conteudo[linha, coluna];
        }


    }
}
