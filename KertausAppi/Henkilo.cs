using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KertausAppi
{
    class Henkilo : Object
    {
        public string Nimi { get; set; }
        private double paino; //0-100kg kapselointi
        public double Paino
        {
            get
            {
                return paino;
            }
            set
            {
                if (value >= 0 && value <= 100) paino = value;
                else
                {
                    Console.WriteLine("Henkilön paino ei ole sallittu!");
                    paino = 0;
                }
            }
        }
        /*public Henkilo()
        {
            Nimi = "Viksu";
            Paino = 100;
        }*/
        public Henkilo()
        {
        }
        public Henkilo(string nimi, double paino)
        {
            Nimi = nimi;
            Paino = paino;
        }
        public override string ToString()
        {
            return Nimi + " " + paino;
        }

    }
}
