using System.Collections.Generic;
using System.Windows.Forms;

namespace AtividadeString.Common.Contracts
{
    public interface IOrganizador
    {
        void Organizar(ICollection<Form> janelas);
    }
}
