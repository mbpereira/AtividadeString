using System;
using MatrixCalculator.Core.Models;
using AtividadeString.Core.Tools.Complementary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixCalculator.Core;

namespace AtividadeString.Tests
{
    [TestClass]
    public class CriptgrafadorTeste
    {
        [TestMethod]
        public void CriptografarUmCaractere()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(pin);

            Assert.AreEqual("104.208", cripto.Criptografar("A"));
        }
        [TestMethod]
        public void CriptografarUmCaractereEspecial()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(pin);

            Assert.AreEqual("554.1558", cripto.Criptografar("-"));
        }

        [TestMethod]
        public void CriptografarUmNome()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(pin);

            Assert.AreEqual("72.118.133.156.262.311", cripto.Criptografar("Mateus"));
        }
    }
}
