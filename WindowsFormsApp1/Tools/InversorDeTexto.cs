using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Contracts;

namespace WindowsFormsApp1.Tools
{
    public class InversorDeTexto : IFerramentaDeTexto
    {
        public string Processar(string text) => string.Join("", text.AsEnumerable().Reverse());
    }
}
