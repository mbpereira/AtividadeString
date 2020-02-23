using System;
using MatrixCalculator.Core;
using MatrixCalculator.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtividadeString.Tests
{
    [TestClass]
    public class OperacoesMatrizesTeste
    {
        [TestMethod]
        public void CalcularProduto2x2()
        {
            var matA = new Matrix(2, 2, new double[,] { { 1, 2 }, { 1, 3 } });
            var matB = new Matrix(2, 2, new double[,] { { 3, 4 }, { 1, 1 } });
            Calculator operacoes = new Calculator();

            var resposta = new Matrix(2, 2, new double[,] { { 5, 6 }, { 6, 7 } });

            Assert.IsTrue(SaoIguais(resposta, operacoes.Product(matA, matB)));

        }
        [TestMethod]
        public void CalcularProduto3x3()
        {
            var matA = new Matrix(3, 3, new double[,] { { 1, 2, 9 }, { 1, 3, 14 }, { 1, 3, 5 } });
            var matB = new Matrix(3, 3, new double[,] { { 3, 4, 52 }, { 1, 1, 33 }, { 4, 6, 2 } });
            Calculator operacoes = new Calculator();

            Matrix resposta = new Matrix(3, 3, new double[,] { { 41, 60, 136 }, { 62, 91, 179 }, { 26, 37, 161 } }); 

            Assert.IsTrue(SaoIguais(resposta, operacoes.Product(matA, matB)));

        }
        [TestMethod]
        public void CalcularProduto5x5()
        {
            var matA = new Matrix(5, 5, new double[,] { { 1, 2, 9, 1, 0 }, { 1, 3, 14, 0, 0 }, { 1, 3, 5, 0, 0 }, { 9, 8, 10, 0, 0 }, { 14, 33, 22, 0, 0 } } );
            var matB = new Matrix(5, 5, new double[,] { { 3, 4, 52, 66, 0 }, { 1, 1, 33, 22, 44 }, { 4, 6, 2, 3, 2 }, { 10, 11, 23, 43, 1 }, { 1, 2, 0, 9, 0 } });
            Calculator operacoes = new Calculator();

            Matrix resposta = new Matrix(5, 5, new double[,] { { 51, 71, 159, 180, 107 }, { 62, 91, 179, 174, 160 }, { 26, 37, 161, 147, 142 }, { 75, 104, 752, 800, 372 }, { 163, 221, 1861, 1716, 1496 } });

            Assert.IsTrue(SaoIguais(resposta, operacoes.Product(matA, matB)));

        }

        public bool SaoIguais(Matrix a, Matrix b)
        {
            if (a == b)
                return true;

            if (a.NumberOfColumns != b.NumberOfColumns || a.NumberOfRows != b.NumberOfRows)
                return false;

            for (int i = 0; i < a.NumberOfRows; i++)
            {
                for (int j = 0; j < a.NumberOfColumns; j++)
                {
                    if (a.GetItem(i, j) != b.GetItem(i, j))
                        return false;
                }
            }

            return true;
        }
    }
}
