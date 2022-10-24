using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Devoir
{
    internal class Controleur
    {
       
        private int valeurActuelle;
        private int total = 0;
        private string typeDeDE;
        Random monHasardType = new Random();
        DEordinaire dEordinaire = new DEordinaire();
        DEpipe dEpipe = new DEpipe();
        public int ValeurActuelle { get => valeurActuelle;}
        public int Total { get => total; }
        public string TypeDeDE { get => typeDeDE; }
       
        public int ChoisirDEhasard() 
        {           
            int numero = monHasardType.Next(0, 2);
            return numero;
        }

        public void Brasser() 
        {
            
            if (ChoisirDEhasard() == 1)
            {
                dEpipe.brasser();
                typeDeDE = dEpipe.ToString();
                valeurActuelle = dEpipe.Valeur;
            }
            else {
                dEordinaire.brasser();
                typeDeDE = dEordinaire.ToString();
                valeurActuelle = dEordinaire.Valeur;
            }
            total += valeurActuelle;
        }

        public Controleur()
        {
            valeurActuelle = 0;
             total = 0;
             typeDeDE = " ";
          
        }
    }
}
