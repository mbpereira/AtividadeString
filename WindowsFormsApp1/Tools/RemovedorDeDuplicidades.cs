using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Contracts;

namespace WindowsFormsApp1.Tools
{
    public class RemovedorDeDuplicidades : IFerramentaDeTexto
    {
        public string Processar(string text) {

            List<char> semDuplicidade = new List<char>();

            foreach(char c in text)
            {
                if (c == ' ')
                {
                    semDuplicidade.Add(c);
                    continue;
                }

                if (!semDuplicidade.Contains(c))
                    semDuplicidade.Add(c);
            }

            return string.Join("", semDuplicidade);
                
        }
        
    }
}
