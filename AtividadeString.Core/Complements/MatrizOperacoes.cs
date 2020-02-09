using AtividadeString.Common.Contracts;
using AtividadeString.Common.Models;
using System;
namespace AtividadeString.Core.Complements
{
    public class MatrizOperacoes : IMatrizOperacoes
    {
        public Matriz CalcularProduto(Matriz a, Matriz b)
        {
            if (a.QuantidadeColunas != b.QuantidadeLinhas)
                throw new InvalidOperationException("Matriz com número de colunas diferente do número de linhas");

            int[,] produto = new int[a.QuantidadeLinhas, b.QuantidadeColunas];


            for (int linhaA = 0; linhaA < a.QuantidadeLinhas; linhaA++)
            {
                for (int colunaB = 0; colunaB < b.QuantidadeColunas; colunaB++)
                {
                    for (int colunaA = 0; colunaA < a.QuantidadeColunas; colunaA++)
                    {
                        produto[linhaA, colunaB] += a.Recuperar(linhaA, colunaA) * b.Recuperar(colunaA, colunaB);
                    }
                }
            }
            

            return new Matriz(a.QuantidadeLinhas, b.QuantidadeColunas, produto);
        }
    }
}
