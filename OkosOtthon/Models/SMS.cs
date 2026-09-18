using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon.Models
{
    public class SMS:ErtesitesiCsatorna
    {
        public string telefonszam;

        public SMS(string telefonszam)
        {
            this.telefonszam = telefonszam;
        }

        public override void Kuld(string uzi)
        {
            Console.WriteLine($"Üzenet küldése: {uzi}! Idő: {DateTime.Now}! Telószám: {telefonszam}");
        }
    }
}
