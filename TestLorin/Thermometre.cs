using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLorin
{
    class Thermometre
    {
        private int temperature;
        private char choix;
        private string choixAffichage;

        public Thermometre(int temperature)
        {
            this.temperature = temperature;
        }

        public void Choix(char choix)
        {
            this.choix = choix;

            switch (choix)
            {
                case 'C':
                    choixAffichage = "degrés celius";
                    break;

                case 'F':
                    choixAffichage = "fahrenheit";
                    break;
            }
        }

        public override string ToString()
        {
            if(choix == 'F')
            {
                temperature = (temperature * (9 / 5)) + 32;
            }

            return $"La température est de {temperature} {choixAffichage}.";

        }
    }
}
