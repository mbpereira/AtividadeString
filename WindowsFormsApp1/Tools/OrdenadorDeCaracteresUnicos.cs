using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Contracts;

namespace WindowsFormsApp1.Tools
{
    public class OrdenadorDeCaracteresUnicos : IFerramentaDeTexto
    {
        private IFerramentaDeTexto _removedorDeDuplicidades;
        public OrdenadorDeCaracteresUnicos(IFerramentaDeTexto removedorDeDupliciades)
        {
            _removedorDeDuplicidades = removedorDeDupliciades;
        }
        public OrdenadorDeCaracteresUnicos()
        {
            _removedorDeDuplicidades = new RemovedorDeDuplicidades();
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
