using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocLib;
using VocLib.Objets;

namespace VocUI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonAddMot_Click(object sender, EventArgs e)
        {
            //Relie au forms AjoutMot
            AjoutMot frm = new AjoutMot();
            frm.Show();
            
        }

        private void ButtonSeTester_Click(object sender, EventArgs e)
        {
            // RELIE au forms CHOIX TEST
            ChoixTest frm = new ChoixTest();
            frm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ClicktoStats(object sender, EventArgs e)
        {
            // Relie au forms STATISTIQUES
            Statistiques frm = new Statistiques();
            frm.Show();
        }
    }
}
