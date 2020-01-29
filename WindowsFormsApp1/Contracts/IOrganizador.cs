using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Contracts
{
    public interface IOrganizador
    {
        void Organizar(IList<Form> janelas);
    }
}
