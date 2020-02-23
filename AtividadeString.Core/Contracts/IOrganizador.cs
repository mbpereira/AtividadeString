using System.Collections.Generic;
using System.Windows.Forms;

namespace AtividadeString.Core.Contracts
{
    public interface IOrganizador
    {
        void Organizar(ICollection<Form> janelas);
    }
}
