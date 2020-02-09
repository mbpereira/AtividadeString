using AtividadeString.Common.Contracts;
using AtividadeString.Common.Enums;
using AtividadeString.Forms.Tools;
namespace AtividadeString.Forms.Factory
{
    public class FabricaOrganizador
    {
        private static FabricaOrganizador _fabrica = null;

        private FabricaOrganizador()
        { }

        public static FabricaOrganizador CriarFabrica()
        {
            if (_fabrica == null)
                _fabrica = new FabricaOrganizador();

            return _fabrica;
        }
        public IOrganizador CriarOrganizador(DisposicaoDeJanelas disposicao)
        {
            if (disposicao == DisposicaoDeJanelas.Cascata)
                return new OrganizadorCascata();

            return new OrganizadorLadoALado();
        }
    }
}
