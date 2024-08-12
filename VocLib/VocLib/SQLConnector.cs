using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VocLib.Objets;

namespace VocLib
{
    public class SQLConnector : IDataConnection
    {
        private string db = "VocSeries";

        /// <summary>
        /// Crée un nouveau mot dans la DB
        /// </summary>
        /// <param name="Model"></param>
        /// <returns>Les infos sur le nouveau mot avec son ID</returns>
        public Mots CreateMot(Mots Model)
        {
            // Ouverture et destruction de la connection pour éviter les MemLeaks

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                //Param de la Procédure dbo.spMotsSeries_AddMot dans la db
                /*@SerieID int,
                @Francais nvarchar(50),
                @Anglais nvarchar(50),
                @Neerlandais nvarchar(50),
                @id int = 0 output*/


                var p = new DynamicParameters();
                p.Add("@SerieID", Model.SerieID);
                p.Add("@Francais",Model.Francais);
                p.Add("@Anglais", Model.Anglais);
                p.Add("@Neerlandais", Model.Neerlandais);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMotsSeries_AddMot", p, commandType: CommandType.StoredProcedure);

                Model.ID = p.Get<int>("@id");

                return Model;
            }
            
        }

        /// <summary>
        ///  Crée une nouvelle série dans la DB
        /// </summary>
        /// <param name="Model"></param>
        /// <returns> Les infos sur la nouvelle séries avec l'ID de la DB</returns>
        public Serie CreateSerie(Serie Model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                // Param de la procédure dans la db 
                //@NomSerie nvarchar(50)
                //@ID int , output
                var p = new DynamicParameters();
                p.Add("@NomSerie", Model.NomSerie);
                p.Add("@ID", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spSeries_AddSerie", p, commandType: CommandType.StoredProcedure) ;

                int i = p.Get<int>("@ID");
                Model.ID = (int)i;

                return Model;
            }

                
        }

      
        public List<string> GetSerieList()
        {
            List<string> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
               output= connection.Query<string>("dbo.spSeries_GetListOfSerie").ToList();
            }
            return output;
        }

        public Serie GetSerieID(Serie model)
        {
            var p = new DynamicParameters();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                // Param de la procédure dans la db 
                //@SerieName nvarchar(50),
                //@ID int output
                
                p.Add("@SerieName", model.NomSerie);
                p.Add("@ID",DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spSeries_GetSerieID", p, commandType: CommandType.StoredProcedure );
                
                int i = p.Get<int>("@ID");
                model.ID = i;

                return model;
            }
            
            
        }
        
        public List<Mots> GetMots(Serie model)
        {
            var p = new DynamicParameters();
            List<Mots> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                // Param procédure dans la db :
                // @SerieID int

                p.Add("@SerieID", model.ID);
                IEnumerable<Mots> mots = connection.Query<Mots>("dbo.spMotsSerie_GetMotFromSerieID", p, commandType: CommandType.StoredProcedure);
                output = mots.ToList();
            }
            return output;
        }

        public Serie GetNumberMots(Serie Model)
        {
            var p = new DynamicParameters();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                // Param procédure dans la db :
                //@ID int,
                //@Count int output

                p.Add("@ID", Model.ID);
                p.Add("@Count", DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMotsSeries_CountMotsFromSerieID", p, commandType: CommandType.StoredProcedure);

                Model.NombreMot = p.Get<int>("@Count");
                return Model;

            }
        }

        public Stats GetStats(Stats Stats)
        {
            var p = new DynamicParameters();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                // Param Procédure dans la DB
                // @SerieID int,
                // @NbEssai int output,
                // @SumNbMots int output,
                // @SumNbScore int output
                p.Add("@SerieID", Stats.SerieID);
                p.Add("@NbEssai", DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@SumNbMots", DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@SumNbScore", DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStatistiques_GetStatFromSerieID", p, commandType: CommandType.StoredProcedure);

                double s2 = p.Get<int>("@SumNbMots");
                double s = p.Get<int>("@SumNbScore");
                Stats.NbEssai = p.Get<int>("@NbEssai");
                double d = (double)((s / s2)*100);
                Stats.Moyenne = d;
                return Stats;
            }   
        }

        public void AddStats(Stats Stats)
        {
            var p = new DynamicParameters();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectString(db)))
            {
                // Param Procédure :
                // @SerieID int,
                // @MotsCount int,
                // @Score int
                p.Add("@SerieID", Stats.SerieID);
                p.Add("@MotsCount", Stats.NbMots);
                p.Add("@Score", Stats.Score);

                connection.Execute("dbo.spStatistique_AddStat",p, commandType: CommandType.StoredProcedure);

            }





        }
    }
}
