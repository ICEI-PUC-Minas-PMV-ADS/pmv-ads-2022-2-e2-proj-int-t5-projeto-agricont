using System.Net.Mail;
using AgriCont.Models;
using System.Net;

namespace AgriCont.Services
{
    public class Email : IEmail
    {
        private readonly IConfiguration _configuration;
        private Email username;
        private FormFaleConosco mensagem;
        private FormFaleConosco nome;
        private FormFaleConosco telefone;
        public Email(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Email(Email username)
        {
            this.username = username;
        }

        public bool Enviar(string nome, string email, string mensagem)
        {
            throw new NotImplementedException();
        }

        public bool Enviar(string nome, string email, string mensagem, string telefone)
        {
            throw new NotImplementedException();
        }

        public bool EnviarEmail(string email, string nome,string mensagem, string telefone)
        {
            try
            {
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress("agricontwebb@gmail.com", "AgriCont - Fale Conosco "),
                };

                mail.To.Add("agricontweb@gmail.com");
                mail.Subject = "Fale Conosco - "+ nome;
                mail.Body = "De: " + nome + ".   " + " E-mail: " + email + "   Telefone: "+ telefone + "   Mensagem: " + mensagem;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential("agricontwebb@gmail.com", "ggcwxwokkfbkjlbq");
                    smtp.EnableSsl = true;
                   

                    smtp.Send(mail);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void EnviarEmail(Email username, string v, FormFaleConosco mensagem)
        {
            throw new NotImplementedException();
        }

    }
}
