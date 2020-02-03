namespace WindowsFormsApp1.Contracts.Factory
{
    public interface IFabricaOrganizador
    {
        IOrganizador CriarOrganizador(DisposicaoDeJanelas disposicao);
    }
}
