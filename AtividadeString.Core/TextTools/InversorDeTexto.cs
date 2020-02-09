using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeString.Common.Contracts;

namespace AtividadeString.Core.TextTools
{
    public class InversorDeTexto : IFerramentaDeTexto
    {
        public string Processar(string text) => string.Join("", text.AsEnumerable().Reverse());
    }
}
