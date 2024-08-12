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
    public partial class AjoutMot : Form
    {
        // Paramètres utilisés pour les combobox
        private List<string> Langues1 = new List<string>();
        private List<string> Langues2 = new List<string>();
        private List<string> Langues3 = new List<string>();
        //private List<string> SeriesChoisies = new List<string>();


        public AjoutMot()
        {
            InitializeComponent();
            LinkBoxLang();
            LoadSerieList();
            
        }

        /// <summary>
        /// Fonction qui va rechercher les noms de séries avant de les ajouter a la liste et la charger
        /// </summary>
        private void LoadSerieList()
        {
            var SerieList = GlobalConfig.Connections.GetSerieList();
            foreach (var NomSerie in SerieList)
            {
                listserie.Items.Add(NomSerie);
            }
            
        }

        /// <summary>
        /// Fonction qui va relier les paramètres mentionnés plus haut avec les combobox afin de sélectionner
        /// une langue.
        /// </summary>
        private void LinkBoxLang()
        {
            Langues1.Add("Francais");
            Langues1.Add("Anglais");
            Langues1.Add("Neerlandais");
            Langues2.Add("Francais");
            Langues2.Add("Anglais");
            Langues2.Add("Neerlandais");
            Langues3.Add("Francais");
            Langues3.Add("Anglais");
            Langues3.Add("Neerlandais");

            comboBoxLang1.DataSource = Langues1; 
            comboBoxLang2.DataSource = Langues2; 
            comboBoxLang3.DataSource = Langues3;

            
        }

        /// <summary>
        /// Action de validation lorsque l'on clique sur le bouton de création de mots.
        /// Il y a un appel a la fonction ValidateForm() qui va permettre de bloquer le processus si les champs
        /// ne sont pas correctement remplis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickValidation(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string MotFrancais = "";
                string MotAnglais = "";
                string MotNeerlandais = "";

                // Affectation du mot francais a la bonne variable
                if(string.IsNullOrEmpty(MotFrancais))
                {
                    if(string.Equals(comboBoxLang1.SelectedItem.ToString(),"Francais"))
                    {
                        MotFrancais = textBoxMot1.Text;
                    }
                    else if (string.Equals(comboBoxLang2.SelectedItem.ToString(), "Francais"))
                    {
                        MotFrancais = textBoxMot2.Text;
                    }
                    else
                    {
                        MotFrancais = textBoxMot3.Text;
                    }
                }
                // Affectation du mont anglais a la bonne variable
                if (string.IsNullOrEmpty(MotAnglais))
                {
                    if (string.Equals(comboBoxLang1.SelectedItem.ToString(), "Anglais"))
                    {
                        MotAnglais = textBoxMot1.Text;
                    }
                    else if (string.Equals(comboBoxLang2.SelectedItem.ToString(), "Anglais"))
                    {
                        MotAnglais = textBoxMot2.Text;
                    }
                    else
                    {
                        MotAnglais = textBoxMot3.Text;
                    }
                }
                // Affectation du mot neerlandais a la bonne variable
                if (string.IsNullOrEmpty(MotNeerlandais))
                {
                    if (string.Equals(comboBoxLang1.SelectedItem.ToString(), "Neerlandais"))
                    {
                        MotNeerlandais = textBoxMot1.Text;
                    }
                    else if (string.Equals(comboBoxLang2.SelectedItem.ToString(), "Neerlandais"))
                    {
                        MotNeerlandais = textBoxMot2.Text;
                    }
                    else
                    {
                        MotNeerlandais = textBoxMot3.Text;
                    }
                }

                //Récupération du nom de ou des séries pour l'identifier
                foreach (var item in listserie.SelectedItems)
                {
                    Serie Serievisee = new Serie();
                    Serievisee.NomSerie = item.ToString();
                    GlobalConfig.Connections.GetSerieID(Serievisee);
                    // Creation du mot puis entrée dans la db
                    Mots Model = new Mots(
                        1,
                        Serievisee.ID,
                        MotFrancais,
                        MotAnglais,
                        MotNeerlandais);
                    GlobalConfig.Connections.CreateMot(Model);

                    // Remise a 0 des textbox pour les réutiliser
                    textBoxMot1.Text = "";
                    textBoxMot2.Text = "";
                    textBoxMot3.Text = "";
                }
                

                listserie.SelectedItems.Clear();
                MessageBox.Show("Mot Ajouté !");
            }
        }

        /// <summary>
        /// Fonction permettant de vérifier la validité du Forms.
        /// </summary>
        /// <returns> True si le FORMS est valide, FALSE sinon puis affiche une messagebox avec la source de l'erreur.</returns>
        public bool ValidateForm() 
        {
            bool output = true;

            if (string.IsNullOrEmpty(comboBoxLang1.GetItemText(comboBoxLang1.SelectedIndex)))
            {
                output = false;
                MessageBox.Show("Sélectionnez une langue");
            }


            if (string.IsNullOrEmpty(textBoxMot1.Text))
            {
                output = false;
            }


            if (string.IsNullOrEmpty(comboBoxLang2.GetItemText(comboBoxLang2.SelectedIndex)))
            {
                output = false;
                MessageBox.Show("Sélectionnez une langue pour la traduction 1 ");
            }


            if (string.IsNullOrEmpty(textBoxMot2.Text))
            {
                output = false;
            }


            if (string.IsNullOrEmpty(comboBoxLang3.GetItemText(comboBoxLang3.SelectedIndex)) )
            {
                output = false;
                MessageBox.Show("Sélectionnez une langue pour la traduction 2");
            }


            if (string.IsNullOrEmpty(textBoxMot3.Text))
            {
                output = false;
            }

            
            if(string.Equals(comboBoxLang1.GetItemText(comboBoxLang1.SelectedIndex), comboBoxLang2.GetItemText(comboBoxLang2.SelectedIndex)) 
                || string.Equals(comboBoxLang1.GetItemText(comboBoxLang1.SelectedIndex), comboBoxLang3.GetItemText(comboBoxLang3.SelectedIndex))
                || string.Equals(comboBoxLang2.GetItemText(comboBoxLang2.SelectedIndex), comboBoxLang3.GetItemText(comboBoxLang3.SelectedIndex))  
                ) 
            {
                output = false;
                MessageBox.Show("Veuillez sélectionner des langues différentes pour les différents mots");
            }

            if (listserie.SelectedIndex == -1 )
            {
                output=false;
                MessageBox.Show("Veuillez sélectionner une série dans laquelle mettre le mot.");
            }

            return output; 
        
        
        }
    }
}
