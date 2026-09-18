using OkosOtthon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon
{
    internal class Program
    {
         static List<ErtesitesiCsatorna> ertesitesek = new List<ErtesitesiCsatorna>();
        static void Main(string[] args)
        {
            ertesitesek.Add(new Push());
            ertesitesek.Add(new Email("nemethi@kkszki.hu"));
            ertesitesek.Add(new SMS("+36204775566"));

            foreach (ErtesitesiCsatorna item in ertesitesek)
            {
                item.Kuld("hőmérséklet-csökkenés");
            }

        }
    }
}
