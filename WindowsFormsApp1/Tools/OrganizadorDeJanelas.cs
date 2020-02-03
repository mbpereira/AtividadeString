using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Contracts;

namespace WindowsFormsApp1.Tools
{
    public class OrganizadorDeJanelas
    {

        public void Organizar(ICollection<Form> janelas, DisposicaoDeJanelas tipoOrganizacao)
        {
            IOrganizador cascata = new OrganizadorCascata();
            IOrganizador ladoALado = new OrganizadorLadoALado();

            cascata.Proximo = ladoALado;

            cascata.Organizar(janelas, tipoOrganizacao);
        }
    }
}
