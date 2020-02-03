using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Contracts;

namespace WindowsFormsApp1.Tools
{
    class OrganizadorLadoALado : IOrganizador
    {
        public IOrganizador Proximo { get; set; }

        public void Organizar(ICollection<Form> janelas, DisposicaoDeJanelas tipoOrganizacao)
        {
            
        }
    }
}
