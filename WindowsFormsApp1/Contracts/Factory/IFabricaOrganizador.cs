using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Contracts;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Contracts.Factory
{
    public interface IFabricaOrganizador
    {
        IOrganizador CriarOrganizador(DisposicaoDeJanelas disposicao);
    }
}
