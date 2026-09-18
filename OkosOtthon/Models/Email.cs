using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon.Models
{
    public class Email:ErtesitesiCsatorna
    {
        public string email;

        public Email(string email)
        {
            this.email = email;
        }

        public override void Kuld(string uzi)
        {
            Console.WriteLine($"Üzenet küldése: {uzi}! Idő: {DateTime.Now}! Email: {email}");

        }
    }
}
