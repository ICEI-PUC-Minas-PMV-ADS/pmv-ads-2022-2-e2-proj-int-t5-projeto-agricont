namespace AgriCont.Services
{
    public interface IEmail
    {
        bool Enviar(string nome, string email, string mensagem, string telefone);
        bool EnviarEmail(string email, string nome, string mensagem, string telefone);
    }
}
