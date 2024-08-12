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
    public partial class Statistiques : Form
    {
        Stats stats = new Stats();
        
        public Statistiques()
        {
            InitializeComponent();
            GetSerie();

        }

        private void GetSerie ()
        {
            var ListSerie = GlobalConfig.Connections.GetSerieList();
            foreach (var item in ListSerie)
            {
                listBox1.Items.Add(item);
            }
            return;
        }

        private void ClickVoirStat(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une série.");
            }
            else
            {
                stats.SerieID = listBox1.SelectedIndex +1;
                GetStat(stats);
                if(stats.NbEssai == 0)
                {
                    MessageBox.Show("La série sélectionnée n'a pas encore été testée.");
                    return;
                }
                textBoxEssais.Text = stats.NbEssai.ToString();
                textBoxMoy.Text = stats.Moyenne.ToString();
            }
        }

        private void GetStat(Stats stats)
        {
            GlobalConfig.Connections.GetStats(stats);

        }
    }
}
