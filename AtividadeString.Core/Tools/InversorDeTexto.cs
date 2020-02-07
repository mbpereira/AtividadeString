using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeString.Contracts;

namespace AtividadeString.Core.Tools
{
    public class InversorDeTexto : IFerramentaDeTexto
    {
        public string Processar(string text) => string.Join("", text.AsEnumerable().Reverse());
    }
}
