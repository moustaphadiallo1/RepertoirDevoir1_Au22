using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Devoir
{
    public abstract class MonDE
    {
        private int nbfaces;
        protected int valeur;
        public Random monHasard = new Random();
        private readonly string typedeDE;

        protected MonDE(string typedeDE)
        {
            this.nbfaces = 6;
            this.typedeDE = typedeDE;
            this.valeur = 0;
        }

        public int Nbfaces { get => nbfaces; }

        public string TypedeDE { get => typedeDE; }
        public int Valeur { get => valeur;}

        public abstract int brasser();

        public override string ToString()
        {
            return this.typedeDE;
        }
        
    }
}
