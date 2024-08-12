using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocLib.Objets
{
    public class Mots
    {
        public int ID { get; set; }
        public int SerieID { get; set; }
        public string Francais { get; set; }
        public string Anglais { get; set; }
        public string Neerlandais { get; set; }

       /* public Mots(int ID,int serieIDValue,string FrancaisValue,string AnglaisValue, string NeerlandaisValue)
        {
            this.ID = ID;
            this.SerieID= serieIDValue;
            this.Francais = FrancaisValue;
            this.Anglais = AnglaisValue;
            this.Neerlandais = NeerlandaisValue;
        
        }*/
        public Mots(Int32 ID, Int32 serieID, string Francais, string Anglais, string Neerlandais)
        {
            this.ID= ID;
            this.SerieID= serieID;
            this.Francais= Francais;
            this.Anglais= Anglais;
            this.Neerlandais= Neerlandais;
        }
    }

    //(System.Int32 ID, System.Int32 SerieID, System.String Francais, System.String Anglais, System.String Neerlandais) 
}
