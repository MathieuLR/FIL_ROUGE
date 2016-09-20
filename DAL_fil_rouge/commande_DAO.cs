using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_fil_rouge
{
    public class commande_DAO
    {
        public List<commande> list(Int64 id)
        {
            try
            {

                SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
                connect.Open();
                SqlCommand requete = new SqlCommand("select * from commande where IdentifiantClient = @IdentifiantClient", connect);

                requete.Parameters.AddWithValue("@IdentifiantClient", id);
                SqlDataReader lecture = requete.ExecuteReader();

                List<commande> recherchecommande = new List<commande>();

                while (lecture.Read())
                {
                    commande c = new commande();
                    c.IdentifiantCommande = (long)(lecture["IdentifiantCommande"]);
                    c.IdentifiantClient = (Int64)(lecture["IdentifiantClient"]);
                    c.NumeroDeCommande = (long)(lecture["NumeroDeCommande"]);
                    c.DateDeCommande = (DateTime)(lecture["DateDeCommande"]);
                    c.PrixTotalCommande = (Decimal)(lecture["PrixTotalCommande"]);
                    recherchecommande.Add(c);
                }

                lecture.Close();
                connect.Close();
                return recherchecommande;
            }

            catch
            {
                throw new Exception("Problème lors de l'initialisation de la liste !");

            }
        }
            public List<commande> listnumcom(Int64 id)
        {
            try
            {

                SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
                connect.Open();
                SqlCommand requete = new SqlCommand("select * from commande where NumeroDeCommande = @NumeroDeCommande", connect);

                requete.Parameters.AddWithValue("@NumeroDeCommande", id);
                SqlDataReader lecture = requete.ExecuteReader();

                List<commande> recherchecommande = new List<commande>();
               
                    
                        while (lecture.Read())
                        {
                            commande c = new commande();
                            c.IdentifiantCommande = (long)(lecture["IdentifiantCommande"]);
                            c.IdentifiantClient = (Int64)(lecture["IdentifiantClient"]);
                            c.NumeroDeCommande = (long)(lecture["NumeroDeCommande"]);
                            c.DateDeCommande = (DateTime)(lecture["DateDeCommande"]);
                            c.PrixTotalCommande = (Decimal)(lecture["PrixTotalCommande"]);
                            recherchecommande.Add(c);
                        }
             
                lecture.Close();
                connect.Close();
                return recherchecommande;
            }

            catch
            {
                throw new Exception("Problème lors de l'initialisation de la liste !");

            }
        }
    }
}
