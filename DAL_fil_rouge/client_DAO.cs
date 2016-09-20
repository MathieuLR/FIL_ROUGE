using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DAL_fil_rouge
{
    public class client_DAO
    {
        public client find(long ID)
        {
            try
            {
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from Client where IdentifiantClient = @IdentifiantClient", connect);
            requete.Parameters.AddWithValue("@IdentifiantClient", ID);
            SqlDataReader lecture = requete.ExecuteReader();


            client cli = new client();

            while (lecture.Read())
            {

                cli.IdentifiantClient = Convert.ToInt32(lecture["IdentifiantClient"]);
                cli.NomDuClient = Convert.ToString(lecture["NomDuClient"]);
                cli.PrenomDuClient = Convert.ToString(lecture["PrenomDuClient"]);
                cli.VilleDuClient = Convert.ToString(lecture["VilleDuClient"]);
                cli.ReferenceDuClient = Convert.ToInt32(lecture["ReferenceDuClient"]);
                if (lecture["Coefficient"] is DBNull)
                {
                    cli.Coefficient = 0;

                }
                else
                {
                    cli.Coefficient = Convert.ToInt64(lecture["Coefficient"]);
                }

                cli.AdresseDuClient = Convert.ToString(lecture["AdresseDuClient"]);
                cli.CodePostalDuClient = Convert.ToInt32(lecture["CodePostalDuClient"]);
                cli.AdresseMailDuClient = Convert.ToString(lecture["AdresseMailDuClient"]);
                cli.TelephoneDuClient = Convert.ToInt32(lecture["TelephoneDuClient"]);
                cli.AdresseDeLivraisonClient = Convert.ToString(lecture["AdresseDeLivraisonClient"]);
                cli.VilleDeLivraisonClient = Convert.ToString(lecture["VilleDeLivraisonClient"]);
                cli.CodePostalDeLivraisonClient = Convert.ToString(lecture["CodePostalDeLivraisonClient"]);
                cli.ClientParticulier = Convert.ToBoolean(lecture["ClientParticulier"]);
                cli.Sexe = Convert.ToBoolean(lecture["Sexe"]);
                cli.ComplementAdresseClient = Convert.ToString(lecture["ComplementAdresseClient"]);
                cli.ClientActif = Convert.ToBoolean(lecture["ClientActif"]);

                if (lecture["NumeroSiret"] is DBNull)
                {
                    cli.NumeroSiret = 0;
                }
                else
                {
                    cli.NumeroSiret = Convert.ToInt32(lecture["NumeroSiret"]);
                }
                if (lecture["NomEnseigne"] is DBNull)
                {
                    cli.NomEnseigne = "";
                }
                else
                {
                    cli.NomEnseigne = Convert.ToString(lecture["NomEnseigne"]);
                }
                if (lecture["ComplementAdresse"] is DBNull)
                {
                    cli.ComplementAdresse = "";
                }
                else
                {
                    cli.ComplementAdresse = Convert.ToString(lecture["ComplementAdresse"]);
                }

                //cli.Affichage = Convert.ToString(lecture["IdentifiantClient"]);
                //cli.AffichageTotal = Convert.ToString(lecture["NomDuClient"]) + " " + Convert.ToString(lecture["PrenomDuClient"]) + " " + Convert.ToString(lecture["VilleDuClient"] + " " + Convert.ToString(lecture["ReferenceDuClient"]) + " " + Convert.ToString(lecture["Coefficient"]) + " " + Convert.ToString(lecture["AdresseDuClient"]) + " " + Convert.ToString(lecture["CodePostalDuClient"]) + " " + Convert.ToString(lecture["AdresseMailDuClient"]) + " " + Convert.ToString(lecture["TelephoneDuClient"]) + " " + Convert.ToString(lecture["NumeroSiret"]) + " " + Convert.ToString(lecture["NomEnseigne"]) + " " + Convert.ToString(lecture["ComplementAdresse"]));

            }
            lecture.Close();
            connect.Close();
            return cli;
            }
            catch
            {
                throw new Exception("Problème lors de la recherche !");
            }

        }
        public List<client> List()
        {
            try
            {
            List<client> resultat = new List<client>();
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client where ClientActif = 1", connect);

            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                client cli = new client();
                cli.IdentifiantClient = Convert.ToInt32(lecture["IdentifiantClient"]);
                cli.NomDuClient = Convert.ToString(lecture["NomDuClient"]);
                cli.PrenomDuClient = Convert.ToString(lecture["PrenomDuClient"]);
                cli.VilleDuClient = Convert.ToString(lecture["VilleDuClient"]);
                cli.ReferenceDuClient = Convert.ToInt32(lecture["ReferenceDuClient"]);
                if (lecture["Coefficient"] is DBNull)
                {
                    cli.Coefficient = 0;

                }
                else
                {
                    cli.Coefficient = Convert.ToInt64(lecture["Coefficient"]);
                }

                cli.AdresseDuClient = Convert.ToString(lecture["AdresseDuClient"]);
                cli.CodePostalDuClient = Convert.ToInt32(lecture["CodePostalDuClient"]);
                cli.AdresseMailDuClient = Convert.ToString(lecture["AdresseMailDuClient"]);
                cli.TelephoneDuClient = Convert.ToInt32(lecture["TelephoneDuClient"]);
                cli.Sexe = Convert.ToBoolean(lecture["Sexe"]);
                cli.ClientActif = Convert.ToBoolean(lecture["ClientActif"]);
                if (lecture["NumeroSiret"] is DBNull)
                {
                    cli.NumeroSiret = 0;
                }
                else
                {
                    cli.NumeroSiret = Convert.ToInt32(lecture["NumeroSiret"]);
                }
                if (lecture["NomEnseigne"] is DBNull)
                {
                    cli.NomEnseigne = "";
                }
                else
                {
                    cli.NomEnseigne = Convert.ToString(lecture["NomEnseigne"]);
                }
                if (lecture["ComplementAdresse"] is DBNull)
                {
                    cli.ComplementAdresse = "";
                }
                else
                {
                    cli.ComplementAdresse = Convert.ToString(lecture["ComplementAdresse"]);
                }
                cli.ComplementAdresseClient = Convert.ToString(lecture["ComplementAdresseClient"]);
                cli.Affichage = Convert.ToString(lecture["IdentifiantClient"]);
                cli.AffichageTotal = Convert.ToString(lecture["NomDuClient"]) + " " + Convert.ToString(lecture["PrenomDuClient"]) + " " + Convert.ToString(lecture["VilleDuClient"] + " " + Convert.ToString(lecture["ReferenceDuClient"]) + " " + Convert.ToString(lecture["Coefficient"]) + " " + Convert.ToString(lecture["AdresseDuClient"]) + " " + Convert.ToString(lecture["CodePostalDuClient"]) + " " + Convert.ToString(lecture["AdresseMailDuClient"]) + " " + Convert.ToString(lecture["TelephoneDuClient"]) + " " + Convert.ToString(lecture["NumeroSiret"]) + " " + Convert.ToString(lecture["NomEnseigne"]) + " " + Convert.ToString(lecture["ComplementAdresse"]));
                resultat.Add(cli);


            }
            lecture.Close();

            connect.Close();
            return resultat;

            }
            catch
            {
                throw new Exception("Problème lors de l'initialisation de la liste !");
            }

        }
        public void insert(client cli)
        {
            try
            {

                SqlConnection connect = new SqlConnection("server =.; database=fil_rouge; integrated security=true");
                connect.Open();

                SqlCommand requetebis = new SqlCommand("select MAX(IdentifiantClient) from Client", connect);
                long IdentifiantClient = (long)requetebis.ExecuteScalar();
                cli.IdentifiantClient = IdentifiantClient + 1;


                SqlCommand requete = new SqlCommand("insert into Client(IdentifiantClient,ReferenceDuClient,NomDuClient,PrenomDuClient,Coefficient,AdresseDuClient,VilleDuClient,CodePostalDuClient,AdresseMailDuClient,TelephoneDuClient,NumeroSiret,NomEnseigne,ComplementAdresse,AdresseDeLivraisonClient,VilleDeLivraisonClient,CodePostalDeLivraisonClient,ClientParticulier,Sexe,IdentifiantServiceCommercial,ComplementAdresseClient,ClientActif) values(@id,@reference,@nom,@prenom,@coefficient,@adresse,@ville,@CP,@adressemail,@telephone,@numerosiret,@nomenseigne,@complementadresse,@AdresseDeLivraisonClient,@VilleDeLivraisonClient,@CodePostalDeLivraisonClient,@ClientParticulier,@Sexe,@IdentifiantServiceCommercial,@ComplementAdresseClient,1)", connect);
                if (cli.ReferenceDuClient == null)
                    requete.Parameters.AddWithValue("@reference", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@reference", cli.ReferenceDuClient);
                requete.Parameters.AddWithValue("@nom", cli.NomDuClient);
                requete.Parameters.AddWithValue("@prenom", cli.PrenomDuClient);
                if (cli.Coefficient == null)
                    requete.Parameters.AddWithValue("@coefficient", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@coefficient", cli.Coefficient);
                requete.Parameters.AddWithValue("@adresse", cli.AdresseDuClient);
                requete.Parameters.AddWithValue("@ville", cli.VilleDuClient);
                if (cli.CodePostalDuClient == null)
                    requete.Parameters.AddWithValue("@CP", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@CP", cli.CodePostalDuClient);
                requete.Parameters.AddWithValue("@adressemail", cli.AdresseMailDuClient);
                if (cli.TelephoneDuClient == null)
                    requete.Parameters.AddWithValue("@telephone", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@telephone", cli.TelephoneDuClient);
                if (cli.NumeroSiret == null)
                    requete.Parameters.AddWithValue("@numerosiret", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@numerosiret", cli.NumeroSiret);
                requete.Parameters.AddWithValue("@nomenseigne", cli.NomEnseigne);
                requete.Parameters.AddWithValue("@complementadresse", cli.ComplementAdresse);
                requete.Parameters.AddWithValue("@id", cli.IdentifiantClient);
                requete.Parameters.AddWithValue("@AdresseDeLivraisonClient", cli.AdresseDeLivraisonClient);
                requete.Parameters.AddWithValue("@VilleDeLivraisonClient", cli.VilleDeLivraisonClient);
                if (cli.CodePostalDeLivraisonClient == null)
                    requete.Parameters.AddWithValue("@CodePostalDeLivraisonClient", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@CodePostalDeLivraisonClient", cli.CodePostalDeLivraisonClient);
                requete.Parameters.AddWithValue("@ClientParticulier", cli.ClientParticulier);
                requete.Parameters.AddWithValue("@Sexe", cli.Sexe);
                requete.Parameters.AddWithValue("@IdentifiantServiceCommercial", cli.IdentifiantServiceCommercial);
                if (cli.ComplementAdresseClient == null)
                    requete.Parameters.AddWithValue("@ComplementAdresseClient", DBNull.Value);
                else
                    requete.Parameters.AddWithValue("@ComplementAdresseClient", cli.ComplementAdresseClient);
                requete.Parameters.AddWithValue("@ClientActif", cli.ClientActif);
                requete.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                throw new Exception("Problème lors de l'ajout !");
            }
        }
        
            public void update (client cli)
         {
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("update Client set ReferenceDuClient =(@reference),NomDuClient = (@nom),PrenomDuClient = (@prenom),Coefficient = (@coefficient),AdresseDuClient = (@adresse),VilleDuClient= (@ville),CodePostalDuClient = (@CP),AdresseMailDuClient = (@adressemail),TelephoneDuClient = (@telephone),NumeroSiret = (@numerosiret),NomEnseigne = (@nomenseigne),ComplementAdresse = (@complementadresse),AdresseDeLivraisonClient = (@AdresseDeLivraisonClient),VilleDeLivraisonClient = (@VilleDeLivraisonClient),CodePostalDeLivraisonClient =(@CodePostalDeLivraisonClient),ClientParticulier =(@ClientParticulier),Sexe = (@Sexe),ComplementAdresseClient =(@ComplementAdresseClient),ClientActif =(@ClientActif) where IdentifiantClient = @IdentifiantClient", connect);

            requete.Parameters.AddWithValue("@IdentifiantClient", cli.IdentifiantClient);
            if (cli.ReferenceDuClient == null)
                requete.Parameters.AddWithValue("@reference", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@reference", cli.ReferenceDuClient);
            requete.Parameters.AddWithValue("@nom", cli.NomDuClient);
            requete.Parameters.AddWithValue("@prenom", cli.PrenomDuClient);
            if (cli.Coefficient == null)
                requete.Parameters.AddWithValue("@coefficient", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@coefficient", cli.Coefficient);
            requete.Parameters.AddWithValue("@adresse", cli.AdresseDuClient);
            requete.Parameters.AddWithValue("@ville", cli.VilleDuClient);
            if (cli.CodePostalDuClient == null)
                requete.Parameters.AddWithValue("@CP", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@CP", cli.CodePostalDuClient);
            requete.Parameters.AddWithValue("@adressemail", cli.AdresseMailDuClient);
            if (cli.TelephoneDuClient == null)
                requete.Parameters.AddWithValue("@telephone", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@telephone", cli.TelephoneDuClient);
            if (cli.NumeroSiret == null)
                requete.Parameters.AddWithValue("@numerosiret", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@numerosiret", cli.NumeroSiret);
            requete.Parameters.AddWithValue("@nomenseigne", cli.NomEnseigne);
            requete.Parameters.AddWithValue("@complementadresse", cli.ComplementAdresse);
            requete.Parameters.AddWithValue("@id", cli.IdentifiantClient);
            requete.Parameters.AddWithValue("@AdresseDeLivraisonClient", cli.AdresseDeLivraisonClient);
            requete.Parameters.AddWithValue("@VilleDeLivraisonClient", cli.VilleDeLivraisonClient);
            if (cli.CodePostalDeLivraisonClient == null)
                requete.Parameters.AddWithValue("@CodePostalDeLivraisonClient", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@CodePostalDeLivraisonClient", cli.CodePostalDeLivraisonClient);
            requete.Parameters.AddWithValue("@ClientParticulier", cli.ClientParticulier);
            requete.Parameters.AddWithValue("@Sexe", cli.Sexe);
            requete.Parameters.AddWithValue("@ClientActif", cli.ClientActif);
            requete.Parameters.AddWithValue("@IdentifiantServiceCommercial", cli.IdentifiantServiceCommercial);
            if (cli.ComplementAdresseClient == null)
                requete.Parameters.AddWithValue("@ComplementAdresseClient", DBNull.Value);
            else
                requete.Parameters.AddWithValue("@ComplementAdresseClient", cli.ComplementAdresseClient);
            requete.ExecuteNonQuery();
            connect.Close();
        }

        public List<client> list_inactif()
        {
            try
            {
            List<client> resultat = new List<client>();
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client where ClientActif = 0", connect);

            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                client cli = new client();
                cli.IdentifiantClient = Convert.ToInt32(lecture["IdentifiantClient"]);
                cli.NomDuClient = Convert.ToString(lecture["NomDuClient"]);
                cli.PrenomDuClient = Convert.ToString(lecture["PrenomDuClient"]);
                cli.VilleDuClient = Convert.ToString(lecture["VilleDuClient"]);
                cli.ReferenceDuClient = Convert.ToInt32(lecture["ReferenceDuClient"]);
                if (lecture["Coefficient"] is DBNull)
                {
                    cli.Coefficient = 0;

                }
                else
                {
                    cli.Coefficient = Convert.ToInt64(lecture["Coefficient"]);
                }

                cli.AdresseDuClient = Convert.ToString(lecture["AdresseDuClient"]);
                cli.CodePostalDuClient = Convert.ToInt32(lecture["CodePostalDuClient"]);
                cli.AdresseMailDuClient = Convert.ToString(lecture["AdresseMailDuClient"]);
                cli.TelephoneDuClient = Convert.ToInt32(lecture["TelephoneDuClient"]);
                cli.Sexe = Convert.ToBoolean(lecture["Sexe"]);
                cli.ClientActif = Convert.ToBoolean(lecture["ClientActif"]);
                if (lecture["NumeroSiret"] is DBNull)
                {
                    cli.NumeroSiret = 0;
                }
                else
                {
                    cli.NumeroSiret = Convert.ToInt32(lecture["NumeroSiret"]);
                }
                if (lecture["NomEnseigne"] is DBNull)
                {
                    cli.NomEnseigne = "";
                }
                else
                {
                    cli.NomEnseigne = Convert.ToString(lecture["NomEnseigne"]);
                }
                if (lecture["ComplementAdresse"] is DBNull)
                {
                    cli.ComplementAdresse = "";
                }
                else
                {
                    cli.ComplementAdresse = Convert.ToString(lecture["ComplementAdresse"]);
                }
                cli.ComplementAdresseClient = Convert.ToString(lecture["ComplementAdresseClient"]);
                cli.Affichage = Convert.ToString(lecture["IdentifiantClient"]);
                cli.AffichageTotal = Convert.ToString(lecture["NomDuClient"]) + " " + Convert.ToString(lecture["PrenomDuClient"]) + " " + Convert.ToString(lecture["VilleDuClient"] + " " + Convert.ToString(lecture["ReferenceDuClient"]) + " " + Convert.ToString(lecture["Coefficient"]) + " " + Convert.ToString(lecture["AdresseDuClient"]) + " " + Convert.ToString(lecture["CodePostalDuClient"]) + " " + Convert.ToString(lecture["AdresseMailDuClient"]) + " " + Convert.ToString(lecture["TelephoneDuClient"]) + " " + Convert.ToString(lecture["NumeroSiret"]) + " " + Convert.ToString(lecture["NomEnseigne"]) + " " + Convert.ToString(lecture["ComplementAdresse"]));
                resultat.Add(cli);


            }
            lecture.Close();

            connect.Close();
            return resultat;

            }
            catch
            {
                throw new Exception("Problème lors de l'initialisation de la liste !");
            }

        }

        public List<client> List_recherche_mail(string mail)
        {
            try
            {
            List<client> resultat = new List<client>();
            SqlConnection connect = new SqlConnection("server=.; database=fil_rouge; integrated security=true");
            connect.Open();
            SqlCommand requete = new SqlCommand("select * from client where AdresseMailDuClient = @AdresseMailDuClient", connect);
            requete.Parameters.AddWithValue("@AdresseMailDuClient", mail);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                client cli = new client();
                cli.IdentifiantClient = Convert.ToInt32(lecture["IdentifiantClient"]);
                cli.NomDuClient = Convert.ToString(lecture["NomDuClient"]);
                cli.PrenomDuClient = Convert.ToString(lecture["PrenomDuClient"]);
                cli.VilleDuClient = Convert.ToString(lecture["VilleDuClient"]);
                cli.ReferenceDuClient = Convert.ToInt32(lecture["ReferenceDuClient"]);
                if (lecture["Coefficient"] is DBNull)
                {
                    cli.Coefficient = 0;

                }
                else
                {
                    cli.Coefficient = Convert.ToInt64(lecture["Coefficient"]);
                }

                cli.AdresseDuClient = Convert.ToString(lecture["AdresseDuClient"]);
                cli.CodePostalDuClient = Convert.ToInt32(lecture["CodePostalDuClient"]);
                cli.AdresseMailDuClient = Convert.ToString(lecture["AdresseMailDuClient"]);
                cli.TelephoneDuClient = Convert.ToInt32(lecture["TelephoneDuClient"]);
                cli.Sexe = Convert.ToBoolean(lecture["Sexe"]);
                cli.ClientActif = Convert.ToBoolean(lecture["ClientActif"]);
                if (lecture["NumeroSiret"] is DBNull)
                {
                    cli.NumeroSiret = 0;
                }
                else
                {
                    cli.NumeroSiret = Convert.ToInt32(lecture["NumeroSiret"]);
                }
                if (lecture["NomEnseigne"] is DBNull)
                {
                    cli.NomEnseigne = "";
                }
                else
                {
                    cli.NomEnseigne = Convert.ToString(lecture["NomEnseigne"]);
                }
                if (lecture["ComplementAdresse"] is DBNull)
                {
                    cli.ComplementAdresse = "";
                }
                else
                {
                    cli.ComplementAdresse = Convert.ToString(lecture["ComplementAdresse"]);
                }
                cli.ComplementAdresseClient = Convert.ToString(lecture["ComplementAdresseClient"]);
               
                resultat.Add(cli);


            }
            lecture.Close();

            connect.Close();
            return resultat;

            }
            catch
            {
                throw new Exception("Problème lors de l'initialisation de la liste !");
            }

        }

    
    }

}
    

   

