using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Contracts
{
    public interface IPrincipal
    {
        void Transmitir(string message);
        void Organizar(DisposicaoDeJanelas tipoOrganizacao);
    }
}
