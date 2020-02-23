using AtividadeString.Core.Enums;

namespace AtividadeString.Core.Contracts
{
    public interface IPrincipal
    {
        void Transmitir(string message);
        void Organizar(DisposicaoDeJanelas tipoOrganizacao);
    }
}
