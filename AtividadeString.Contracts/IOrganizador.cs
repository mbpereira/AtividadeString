using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeString.Contracts
{
    public interface IOrganizador
    {
        void Organizar(ICollection<Form> janelas);
    }
}
