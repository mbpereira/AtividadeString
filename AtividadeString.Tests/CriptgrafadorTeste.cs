using System;
using AtividadeString.Common.Models;
using AtividadeString.Core.Complements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AtividadeString.Tests
{
    [TestClass]
    public class CriptgrafadorTeste
    {
        [TestMethod]
        public void CriptografarUmCaractere()
        {
            Matriz pin = new Matriz(2, 2, new int[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(new MatrizOperacoes(), pin);

            Assert.AreEqual("104$208", cripto.Criptografar("A"));
        }
        [TestMethod]
        public void CriptografarUmCaractereEspecial()
        {
            Matriz pin = new Matriz(2, 2, new int[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(new MatrizOperacoes(), pin);

            Assert.AreEqual("554$1558", cripto.Criptografar("-"));
        }

        [TestMethod]
        public void CriptografarUmNome()
        {
            Matriz pin = new Matriz(2, 2, new int[,] { { 1, 2 }, { 3, 4 } });
            Criptografador cripto = new Criptografador(new MatrizOperacoes(), pin);

            Assert.AreEqual("72$118$133$156$262$311", cripto.Criptografar("Mateus"));
        }
    }
}
