using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wf_Devoir
{
    public partial class Frm_DE : Form
    {
        private Controleur controleur = new Controleur();
        public Frm_DE()
        {
            InitializeComponent();
        }

        private void Frm_DE_Load(object sender, EventArgs e)
        {

        }

        private void btn_brasser_Click(object sender, EventArgs e)
        {
                controleur.Brasser();

                txt_DEcourant.Text = controleur.TypeDeDE;
                txt_valDEcourant.Text = controleur.ValeurActuelle.ToString();
                txt_toatalPoints.Text = controleur.Total.ToString();
            
        }
    }
}
