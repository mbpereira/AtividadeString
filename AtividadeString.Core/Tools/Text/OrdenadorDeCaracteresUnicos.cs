using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeString.Core.Contracts;

namespace AtividadeString.Core.Tools.Text
{
    public class OrdenadorDeCaracteresUnicos : IFerramentaDeTexto
    {
        private RemovedorDeDuplicidades _removedorDeDuplicidades;
        public OrdenadorDeCaracteresUnicos(RemovedorDeDuplicidades removedorDeDupliciades)
        {
            _removedorDeDuplicidades = removedorDeDupliciades;
        }

        public string Processar(string text)
        {
            List<char> semDupliciade = SemDupliciade(text);

            semDupliciade.Sort();

            return string.Join("", semDupliciade);
            
        }

        private List<char> SemDupliciade(string text) => new List<char>(_removedorDeDuplicidades.Processar(text));
    }
}
