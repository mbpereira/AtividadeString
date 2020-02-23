using AtividadeString.Core.Contracts;

namespace AtividadeString.Core.Tools.Text
{
    public class Descriptografador : IFerramentaDeTexto
    {

        private readonly Core.Contracts.IDescriptografador _descriptografador;
        public Descriptografador(Core.Contracts.IDescriptografador descriptografador)
        {
            _descriptografador = descriptografador;
        }
        public string Processar(string text) => _descriptografador.Descriptografar(text);
    }
}
