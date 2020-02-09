using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeString.Common.Contracts;

namespace AtividadeString.Core.TextTools
{
    public class TrocadorDeCase : IFerramentaDeTexto
    {
        public string Processar(string text)
        {
            int tamanhoTexto = text.Length;

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < tamanhoTexto; i++)
            {

                if (i % 2 == 0)
                    sb.Append(char.ToUpper(text[i]));
                else
                    sb.Append(char.ToLower(text[i]));
              
            }

            return sb.ToString();
        }
    }
}
