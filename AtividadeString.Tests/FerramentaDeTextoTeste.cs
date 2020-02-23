using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtividadeString.Core.Tools.Text;

namespace AtividadeString.Tests
{
    [TestClass]
    public class FerramentaDeTextoTeste
    {
        [TestMethod]
        public void TestarTrocadorDeCase()
        {
            var trocador = new TrocadorDeCase();
            var textoTrocado = trocador.Processar("Mateus");

            Assert.AreEqual("MaTeUs", textoTrocado);

        }
        [TestMethod]
        public void TestarRemovedorDeDuplicidades()
        {
            var removedor = new RemovedorDeDuplicidades();
            var semDuplicidade = removedor.Processar("aabcdeefa");

            Assert.AreEqual("abcdef", semDuplicidade);
        }
        [TestMethod]
        public void TestarInversorDeTexto()
        {
            var inversor = new InversorDeTexto();
            var invertido = inversor.Processar("abcde");
            Assert.AreEqual("edcba", invertido);
        }
        [TestMethod]
        public void TestarOrganizadorDeCaracteresUnicos()
        {
            var removedor = new RemovedorDeDuplicidades();
            var organizador = new OrdenadorDeCaracteresUnicos(removedor);

            var organizado = organizador.Processar("accb");
            Assert.AreEqual("abc", organizado);

        }
    }
}
