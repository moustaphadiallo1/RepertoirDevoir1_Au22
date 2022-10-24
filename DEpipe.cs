using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Devoir
{
    public class DEpipe : MonDE
    {
        public DEpipe():base("DE Pipe")
        {

        }

        public override int brasser()
        {
            //Generer un nombre au hasard avec mon hasard
            valeur = monHasard.Next(1, 10);
            if (valeur > 6)
            {
                valeur -= 3;
            }
           return valeur;

            //S'assurer d'avoir plus de chance quand on est au dessus de 6
        }
    }
}
