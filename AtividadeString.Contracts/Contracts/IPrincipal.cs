using AtividadeString.Common.Enums;

namespace AtividadeString.Common.Contracts
{
    public interface IPrincipal
    {
        void Transmitir(string message);
        void Organizar(DisposicaoDeJanelas tipoOrganizacao);
    }
}
