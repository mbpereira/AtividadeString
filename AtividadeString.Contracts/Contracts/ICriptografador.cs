
namespace AtividadeString.Common.Contracts
{
    public interface ICriptografador
    {
        string Criptografar(string mensagem);
        string Descriptografar(string mensagemCriptografada);
    }
}
