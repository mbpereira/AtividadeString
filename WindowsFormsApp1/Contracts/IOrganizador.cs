using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Contracts
{
    public enum DisposicaoDeJanelas
    {
        LadoALado,
        Cascata
    }
    public interface IOrganizador
    {
        IOrganizador Proximo { get; set; }
        void Organizar(ICollection<Form> janelas, DisposicaoDeJanelas tipoOrganizacao);
    }
}
