using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocLib;
using VocLib.Objets;


namespace VocUI
{
    public partial class Test : Form
    {
        // Paramètres nécesssaires au bon fonctionnement du test :
        
        List<Mots> MotsTest;
        List<Mots> MotsFaux = new List<Mots>();
        Random aleatoire = new Random(DateTime.Now.ToString().GetHashCode());
        int ind;
        string lang1, lang2;
        Stats stats = new Stats();
        int score = 0, total;
        
        
        public Test(Serie SerieTest,string LangDepart,string LangTrad)
        {
            InitializeComponent();
            SetSerieID(SerieTest);
            GetNumberMots(SerieTest);
            total = SerieTest.NombreMot;
            MotsTest = GetMots(SerieTest);
            stats.SerieID = SerieTest.ID;
            stats.NbMots = SerieTest.NombreMot;
            ind = aleatoire.Next(0, MotsTest.Count);
            DisplayMots(MotsTest, LangDepart, LangTrad,ind);  

        }

        /// <summary>
        /// Fais appel a la DB pour avoir l'ID de la série
        /// </summary>
        /// <param name="SerieTest"></param>
        /// <returns> SerieTest Avec son ID</returns>
        public Serie SetSerieID(Serie SerieTest)
        {
            GlobalConfig.Connections.GetSerieID(SerieTest);
            return SerieTest;

        }

        /// <summary>
        /// Fait appel a la DB pour avoir le nombre de mots
        /// </summary>
        /// <param name="SerieTest"></param>
        /// <returns> SerieTest avec son nombre de mots</returns>
        public Serie GetNumberMots(Serie SerieTest)
        {
            GlobalConfig.Connections.GetNumberMots(SerieTest);
            return SerieTest;

        }

        /// <summary>
        /// Fait appel a la DB pour stocker les mots de la série dans une liste
        /// </summary>
        /// <param name="SerieTest"></param>
        /// <returns> MotsTest remplie</returns>
        public List<Mots> GetMots(Serie SerieTest)
        {
            List<Mots> MotsTest = GlobalConfig.Connections.GetMots(SerieTest);
            return MotsTest;
        }

        /// <summary>
        /// Fonction affichant les mots de MotsTest dans les bonnes TEXTBOX en focntion de l'ordre de traduciton précédemment sélectionné
        /// </summary>
        /// <param name="MotsTest"></param>
        /// <param name="LangDepart"></param>
        /// <param name="LangTrad"></param>
        /// <param name="ind"></param>
        public void DisplayMots(List<Mots> MotsTest, string LangDepart, string LangTrad,int ind)
        {

            // inscription du mot a traduire
            if (string.Equals(LangDepart, "Francais"))
            {
                textBoxMotATrad.Text = MotsTest[ind].Francais;
                
            }
            if (string.Equals(LangDepart, "Anglais"))
            {
                textBoxMotATrad.Text = MotsTest[ind].Anglais;

            }
            if (string.Equals(LangDepart, "Neerlandais"))
            {
                textBoxMotATrad.Text = MotsTest[ind].Neerlandais;
            }

            // Inscription de la correction
            if (string.Equals(LangTrad, "Francais"))
            {
                textBoxCorrection.Text = MotsTest[ind].Francais;

            }
            if (string.Equals(LangTrad, "Anglais"))
            {
                textBoxCorrection.Text = MotsTest[ind].Anglais;

            }
            if (string.Equals(LangTrad, "Neerlandais"))
            {
                textBoxCorrection.Text = MotsTest[ind].Neerlandais;
            }
            lang1 = LangDepart;
            lang2 = LangTrad;
        }
       
        /// <summary>
        /// Fonction servant a naviguer dans la liste MotsTest, 
        /// a afficher le message final avec le score et 
        /// si des traductions sont fausses propose de se retester 
        /// UNIQUEMENT sur les mots faux
        /// 
        /// Sinon, ferme la fenètre.
        /// 
        /// Stocke le score dans stats avant de l'envoyer dans la db
        /// </summary>
        private void Motsuivant()
        {
            MotsTest.RemoveAt(ind);
            if (MotsTest.Count>0)
            {
                ind = aleatoire.Next(0, MotsTest.Count);
                DisplayMots(MotsTest, lang1, lang2, ind);
            }
            else
            {
                stats.Score = score;
                SendStats(stats);
                MessageBox.Show(string.Concat("Vous avez fini le test avec un score de : ", score.ToString(), "/", total.ToString())) ;
                if (MotsFaux.Count >0)
                {
                    if (MessageBox.Show("Voulez vous recommencer les mots faux ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MotsTest = new List<Mots> { };
                        MotsTest.AddRange(MotsFaux);
                        MotsFaux.Clear();
                        score = 0;
                        total = MotsTest.Count;
                        ind = aleatoire.Next(0, MotsTest.Count);
                        DisplayMots(MotsTest, lang1, lang2, ind);

                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }

            }
            
        }
        
        
        
        private void ButtonVerifierTrad_Click(object sender, EventArgs e)
        {
            buttonNextWord.Visible = true;
            textBoxCorrection.Visible = true;
            labelFaux.Visible = true;
            VerifMotsTest();
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            buttonNextWord.Visible = false;
            textBoxCorrection.Visible = false;
            labelFaux.Visible = false;
            textBoxTradEssai.Text = "";
            Motsuivant();
        }

        /// <summary>
        /// Incrémente le score quand une traduction est juste,
        /// Ajoute le mot a la liste des mots faux sinon
        /// </summary>
        private void VerifMotsTest()
        {
            if (string.Equals(textBoxTradEssai.Text,textBoxCorrection.Text))
            {
                score++;
            }
            else
            {
                if (MotsFaux == null)
                {
                    MotsFaux = new List<Mots> { };
                    MotsFaux.Insert(0, MotsTest[ind]);
                }
                else
                {
                    MotsFaux.Add(MotsTest[ind]);
                }
            }

        }

        private void SendStats(Stats stats)
        {
            GlobalConfig.Connections.AddStats(stats);
        }

    }
}
