namespace AtividadeString.Contracts
{
    public interface IPrincipal
    {
        void Transmitir(string message);
        void Organizar(DisposicaoDeJanelas tipoOrganizacao);
    }
}
