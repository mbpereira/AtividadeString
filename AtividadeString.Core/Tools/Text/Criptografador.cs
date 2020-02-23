using AtividadeString.Core.Contracts;

namespace AtividadeString.Core.Tools.Text
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
