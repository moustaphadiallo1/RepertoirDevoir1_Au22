using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Devoir
{
    public class DEordinaire : MonDE
    {
        public DEordinaire() : base("DE Ordinaire")
        {

        }

        public override int brasser()
        {
          return  monHasard.Next(1, 7);
        }
    }
}
