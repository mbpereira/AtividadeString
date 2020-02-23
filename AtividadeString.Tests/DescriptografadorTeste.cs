using System;
using AtividadeString.Core.Tools.Complementary;
using MatrixCalculator.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtividadeString.Tests
{
    [TestClass]
    public class DescriptografadorTeste
    {
        [TestMethod]
        public void DeveDescriptografarERetornarUmNome()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(pin);

            Assert.AreEqual("Mateus", cripto.Descriptografar("72.118.133.156.262.311"));
        }
        [TestMethod]
        public void DeveDescriptografarUmaLetra()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(pin);

            Assert.AreEqual("A", cripto.Descriptografar("104.208"));
        }
        [TestMethod]
        public void DeveDescriptografarUmCaractereEspecial()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(pin);

            Assert.AreEqual("-", cripto.Descriptografar("554.1558"));
        }


    }
}
