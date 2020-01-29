using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Contracts
{
    public interface IPrincipal
    {
        void Transmitir(string message);
        void Organizar(DisposicaoDeJanelas tipoOrganizacao);
    }
}
