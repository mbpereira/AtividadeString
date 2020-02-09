using AtividadeString.Common.Contracts;

namespace AtividadeString.Core.TextTools
{
    public class Criptografador : IFerramentaDeTexto
    {
        private ICriptografador _criptografador;
        public Criptografador(ICriptografador criptografador)
        {
            _criptografador = criptografador;
        }
        public string Processar(string text) => _criptografador.Criptografar(text);
        
    }
}
