using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using VocLib;
using VocLib.Objets;

namespace VocUI
{
    public partial class ChoixTest : Form
    {
        private List<string> Langues1 = new List<string>();
        private List<string> Langues2 = new List<string>();

        

        public ChoixTest()
        {
            InitializeComponent();
            LinkBoxLang();
            LoadSerieList();
        }
        private void LoadSerieList()
        {
            var SerieList = GlobalConfig.Connections.GetSerieList();
            foreach (var NomSerie in SerieList)
            {
                ListSeries.Items.Add(NomSerie);
            }

        }
        private void LinkBoxLang()
        {
            Langues1.Add("Francais");
            Langues1.Add("Anglais");
            Langues1.Add("Neerlandais");
            Langues2.Add("Francais");
            Langues2.Add("Anglais");
            Langues2.Add("Neerlandais");
            comboBoxLangDepart.DataSource = Langues1;
            comboBoxLangFin.DataSource = Langues2;
        }

        /// <summary>
        /// Lance le test avec les options sélectionnées puis ferme la fenètre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonbegintest_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Récupère les infos pour lancer le test
                Serie selSerie = new Serie();
                selSerie.NomSerie = ListSeries.SelectedItem.ToString();
                string selLang1 = comboBoxLangDepart.SelectedItem.ToString();
                string selLang2 = comboBoxLangFin.SelectedItem.ToString();

                //Lance le test
                Test frm = new Test(selSerie,selLang1,selLang2);
                frm.Show();
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(comboBoxLangDepart.GetItemText(comboBoxLangDepart.SelectedIndex)))
            {
                output = false;
                MessageBox.Show("Sélectionnez la langue du mot a traduire");
            }
            if (string.IsNullOrEmpty(comboBoxLangFin.GetItemText(comboBoxLangFin.SelectedIndex)))
            {
                output = false;
                MessageBox.Show("Selectionnez la langue de traduction");
            }
            if (string.Equals(comboBoxLangDepart.GetItemText(comboBoxLangDepart.SelectedIndex),
                comboBoxLangFin.GetItemText(comboBoxLangFin.SelectedIndex)))
            {
                output = false;
                MessageBox.Show("Selectionnez des langues differentes pour le test");
            }
            if (ListSeries.SelectedIndex == -1)
            {
                output = false;
                MessageBox.Show("Selectionnez une serie sur laquelle vous tester");
            }
            return output;
        }
    }
}
