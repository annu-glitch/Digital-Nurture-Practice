using System.Net;
using System.Net.Mail;

namespace CustomerCommLib
{
    public interface IMailSender          //infrastructure
    {
        bool SendMail(string toAddress, string message);
    }

    public class MailSender : IMailSender    //implements the interface
    {
        public bool SendMail(string toAddress, string message)
        {
            MailMessage mail = new MailMessage();      //creating a mail object
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");      //connecting to server

            mail.From = new MailAddress("2205448@kiit.ac.in");    //represents an email address (the sender's)
            mail.To.Add(toAddress);  
            mail.Subject = "Test Mail";
            mail.Body = message;

            smtpServer.Port = 587;    //email encryption
            smtpServer.Credentials = new NetworkCredential("2205448@kiit.ac.in", "wtmm ywnt lmto wtwk");    //generated app password
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);             //works on actually sending the email: interacts with outside world

            return true;
        }
    }

    public class CustomerComm1    //the business logic: deals with what to send
    {
        private readonly IMailSender _mailSender;

        public CustomerComm1(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            string email = "2205448@kiit.ac.in";
            string body = "Welcome to our service!";

            return _mailSender.SendMail(email, body);
        }
    }
}
