using System;
using AtividadeString.Common.Models;
using AtividadeString.Core.Complements;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtividadeString.Tests
{
    [TestClass]
    public class OperacoesMatrizesTeste
    {
        [TestMethod]
        public void CalcularProduto2x2()
        {
            var matA = new Matriz(2, 2, new int[,] { { 1, 2 }, { 1, 3 } });
            var matB = new Matriz(2, 2, new int[,] { { 3, 4 }, { 1, 1 } });
            MatrizOperacoes operacoes = new MatrizOperacoes();

            var resposta = new Matriz(2, 2, new int[,] { { 5, 6 }, { 6, 7 } });

            Assert.IsTrue(SaoIguais(resposta, operacoes.CalcularProduto(matA, matB)));

        }
        [TestMethod]
        public void CalcularProduto3x3()
        {
            var matA = new Matriz(3, 3, new int[,] { { 1, 2, 9 }, { 1, 3, 14 }, { 1, 3, 5 } });
            var matB = new Matriz(3, 3, new int[,] { { 3, 4, 52 }, { 1, 1, 33 }, { 4, 6, 2 } });
            MatrizOperacoes operacoes = new MatrizOperacoes();

            Matriz resposta = new Matriz(3, 3, new int[,] { { 41, 60, 136 }, { 62, 91, 179 }, { 26, 37, 161 } }); 

            Assert.IsTrue(SaoIguais(resposta, operacoes.CalcularProduto(matA, matB)));

        }
        [TestMethod]
        public void CalcularProduto5x5()
        {
            var matA = new Matriz(5, 5, new int[,] { { 1, 2, 9, 1, 0 }, { 1, 3, 14, 0, 0 }, { 1, 3, 5, 0, 0 }, { 9, 8, 10, 0, 0 }, { 14, 33, 22, 0, 0 } } );
            var matB = new Matriz(5, 5, new int[,] { { 3, 4, 52, 66, 0 }, { 1, 1, 33, 22, 44 }, { 4, 6, 2, 3, 2 }, { 10, 11, 23, 43, 1 }, { 1, 2, 0, 9, 0 } });
            MatrizOperacoes operacoes = new MatrizOperacoes();

            Matriz resposta = new Matriz(5, 5, new int[,] { { 51, 71, 159, 180, 107 }, { 62, 91, 179, 174, 160 }, { 26, 37, 161, 147, 142 }, { 75, 104, 752, 800, 372 }, { 163, 221, 1861, 1716, 1496 } });

            Assert.IsTrue(SaoIguais(resposta, operacoes.CalcularProduto(matA, matB)));

        }

        public bool SaoIguais(Matriz a, Matriz b)
        {
            if (a == b)
                return true;

            if (a.QuantidadeColunas != b.QuantidadeColunas || a.QuantidadeLinhas != b.QuantidadeLinhas)
                return false;

            for (int i = 0; i < a.QuantidadeLinhas; i++)
            {
                for (int j = 0; j < a.QuantidadeColunas; j++)
                {
                    if (a.Recuperar(i, j) != b.Recuperar(i, j))
                        return false;
                }
            }

            return true;
        }
    }
}
