using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon.Models
{
    public class Push:ErtesitesiCsatorna
    {
        public override void Kuld(string uzi)
        {
            Console.WriteLine($"Üzenet küldése: {uzi}! Idő: {DateTime.Now}! Push értesítés");
        }
    }
}
