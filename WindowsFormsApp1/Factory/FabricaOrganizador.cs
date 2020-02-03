﻿using WindowsFormsApp1.Contracts;
using WindowsFormsApp1.Contracts.Factory;
using WindowsFormsApp1.Tools;

namespace WindowsFormsApp1.Factory
{
    class FabricaOrganizador : IFabricaOrganizador
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
