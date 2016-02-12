using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KertausAppi
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo henkilo = new Henkilo();
            henkilo.Nimi = "Jukka Taalasmaa";
            henkilo.Paino = 80;
            Console.WriteLine("Henkilon nimi: " + henkilo.Nimi);
            Console.WriteLine("Henkikilon paino: " + henkilo.Paino);


            string nimi = "Kirsi Kernel";
            double paino = 50;

            Henkilo henkilo2 = new Henkilo(nimi, paino);
            Console.WriteLine("Henkilon nimi: " + henkilo2.Nimi);
            Console.WriteLine("Henkilon paino: " + henkilo2.Paino);

            Henkilo henkilo3 = new Henkilo {Nimi="Kalle", Paino= 23 };
            Console.WriteLine("Henkilon nimi: " + henkilo3.Nimi);
            Console.WriteLine("Henkilon paino: " + henkilo3.Paino);

            Katsoja katsoja = new Katsoja("Jussi Jussinen", 100, true);
            Console.WriteLine(katsoja.ToString());
            katsoja.huutaa(); 
        }
    }
}
