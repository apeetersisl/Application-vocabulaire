using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocUI
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialisation de la connection a la db 
            VocLib.GlobalConfig.InitializeConnection();


            // Lancement de l'application 
            Application.Run(new MenuPrincipal());
            //Application.Run(new ChoixTest());
        
        }
    }
}
