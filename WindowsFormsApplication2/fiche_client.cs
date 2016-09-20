using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_fil_rouge;

namespace WindowsFormsApplication2
{
    public partial class fiche_client : Form
    {
        public Int64 id;
        
        public fiche_client()
        {
            InitializeComponent();
        }
        client_DAO repo = new client_DAO();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void fiche_client_Load(object sender, EventArgs e)
        {
            button_supprimer_client.Visible = false;

            if (this.id > 0)
            {
                button_supprimer_client.Visible = true;
                client envoyerdonnees = repo.find((Int64)id);

                textBox_nom.Text = envoyerdonnees.NomDuClient;
                textBox_prenom.Text = envoyerdonnees.PrenomDuClient;
                textBox_ident_cli.Text = id.ToString();
                textBox_refe_client.Text = Convert.ToInt64(envoyerdonnees.ReferenceDuClient).ToString();
                textBox_coefficient.Text = Convert.ToInt64(envoyerdonnees.Coefficient).ToString();
                textBox_adresse.Text = envoyerdonnees.AdresseDuClient;
                textBox_complement_adresse.Text = envoyerdonnees.ComplementAdresse;
                textBox_Ville.Text = envoyerdonnees.VilleDuClient;
                textBox_CP.Text = Convert.ToInt64(envoyerdonnees.CodePostalDuClient).ToString();
                textBox_adresse_mail.Text = envoyerdonnees.AdresseMailDuClient;
                textBox_tel.Text = Convert.ToInt64(envoyerdonnees.TelephoneDuClient).ToString();

                if (envoyerdonnees.Sexe == false)
                {
                    radioButton_mme.Checked = true;
                }
                else
                {
                    radioButton_monsieur.Checked = true;
                }

                if (envoyerdonnees.ClientParticulier == true)
                {
                    groupBox_particulier.Enabled = true;
                    radioButton_particulier.Checked = true;
                    textBox_adresse_de_livraison_part.Text = envoyerdonnees.AdresseDeLivraisonClient;
                    textBox_CP_part.Text = envoyerdonnees.CodePostalDeLivraisonClient;
                    textBox_ville_part.Text = envoyerdonnees.VilleDeLivraisonClient;
                    textBox_adresse_de_livraison_complement_part.Text = envoyerdonnees.ComplementAdresseClient;
                }
                else
                {
                    groupBox_prof.Enabled = true;
                    radioButton_professionel.Checked = true;
                    textBox_adresse_livraison_prof.Text = envoyerdonnees.AdresseDeLivraisonClient;
                    textBox_CP_prof.Text = envoyerdonnees.CodePostalDeLivraisonClient;
                    textBox_ville_prof.Text = envoyerdonnees.VilleDeLivraisonClient;
                    textBox_nom_enseigne_prof.Text = envoyerdonnees.NomEnseigne;
                    textBox_num_siret_prof.Text = Convert.ToInt64(envoyerdonnees.NumeroSiret).ToString();
                    textBox_adresse_livraison_complement_prof.Text = envoyerdonnees.ComplementAdresseClient;
                }

            } 
            else
            {
                groupBox_prof.Enabled = true;
                groupBox_particulier.Enabled = true;
                button_supprimer_client.Enabled = true;
                textBox_refe_client.Enabled = true;
            
            }
        }

        private void radioButton_particulier_CheckedChanged(object sender, EventArgs e)
        {
            if (this.id == 0)
            {
                groupBox_prof.Enabled = false;
                groupBox_particulier.Enabled = true;
            }
        }

        private void radioButton_professionel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.id == 0)
            {
                groupBox_prof.Enabled = true;
                groupBox_particulier.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.id == 0)
            {
                
                client clientcreation = new client();

                clientcreation.NomDuClient = textBox_nom.Text;
                clientcreation.PrenomDuClient = textBox_prenom.Text;
                clientcreation.VilleDuClient = textBox_Ville.Text;
                clientcreation.ReferenceDuClient = Convert.ToInt64(textBox_refe_client.Text);
                clientcreation.Coefficient = Convert.ToInt64(textBox_coefficient.Text);
                clientcreation.AdresseDuClient = textBox_adresse.Text;
                clientcreation.ComplementAdresse = textBox_complement_adresse.Text;
                clientcreation.VilleDuClient = textBox_Ville.Text;
                clientcreation.CodePostalDuClient = Convert.ToInt64(textBox_CP.Text);
                clientcreation.AdresseMailDuClient = textBox_adresse_mail.Text;
                clientcreation.TelephoneDuClient = Convert.ToInt64(textBox_tel.Text);
                clientcreation.ClientParticulier = radioButton_particulier.Checked;
                clientcreation.IdentifiantServiceCommercial = Convert.ToInt64(textbox_service_com.Text);


                if (radioButton_mme.Checked == true)
                {

                    clientcreation.Sexe = false;
                }
                else
                {
                    clientcreation.Sexe = true;
                }

                if (radioButton_particulier.Checked == true)
                {

                    clientcreation.AdresseDeLivraisonClient = textBox_adresse_livraison_prof.Text;
                    clientcreation.CodePostalDeLivraisonClient = textBox_CP_prof.Text;
                    clientcreation.VilleDeLivraisonClient = textBox_ville_prof.Text;
                    clientcreation.NomEnseigne = textBox_nom_enseigne_prof.Text;
                    clientcreation.ComplementAdresseClient = textBox_adresse_livraison_complement_prof.Text;
                    clientcreation.AdresseDeLivraisonClient = textBox_adresse_de_livraison_part.Text;
                    clientcreation.CodePostalDeLivraisonClient = textBox_CP_part.Text;
                    clientcreation.VilleDeLivraisonClient = textBox_ville_part.Text;
                    clientcreation.ComplementAdresseClient = textBox_adresse_de_livraison_complement_part.Text;
                    



                }
                else
                {
                    clientcreation.AdresseDeLivraisonClient = textBox_adresse_de_livraison_part.Text;
                    clientcreation.CodePostalDeLivraisonClient = textBox_CP_part.Text;
                    clientcreation.VilleDeLivraisonClient = textBox_ville_part.Text;
                    clientcreation.ComplementAdresseClient = textBox_adresse_de_livraison_complement_part.Text;
                    clientcreation.AdresseDeLivraisonClient = textBox_adresse_livraison_prof.Text;
                    clientcreation.CodePostalDeLivraisonClient = textBox_CP_prof.Text;
                    clientcreation.VilleDeLivraisonClient = textBox_ville_prof.Text;
                    clientcreation.NomEnseigne = textBox_nom_enseigne_prof.Text;
                    clientcreation.NumeroSiret = Convert.ToInt64(textBox_num_siret_prof.Text);
                    clientcreation.ComplementAdresseClient = textBox_adresse_livraison_complement_prof.Text;

                }
                DialogResult reponse = MessageBox.Show("Souhaitez vous ajouter le client ?", "Validation", MessageBoxButtons.YesNo);
                if (reponse == DialogResult.Yes)
                {
                    repo.insert(clientcreation);
                    this.Close();
                }

               

            }
            else
            {
              

                client clientmodification = new client();
                clientmodification.IdentifiantClient = Convert.ToInt64(textBox_ident_cli.Text);
                clientmodification.NomDuClient = textBox_nom.Text;
                clientmodification.PrenomDuClient = textBox_prenom.Text;
                clientmodification.VilleDuClient = textBox_Ville.Text;
                clientmodification.ReferenceDuClient = Convert.ToInt64(textBox_refe_client.Text);
                clientmodification.Coefficient = Convert.ToInt64(textBox_coefficient.Text);
                clientmodification.AdresseDuClient = textBox_adresse.Text;
                clientmodification.ComplementAdresse = textBox_complement_adresse.Text;
                clientmodification.VilleDuClient = textBox_Ville.Text;
                clientmodification.CodePostalDuClient = Convert.ToInt64(textBox_CP.Text);
                clientmodification.AdresseMailDuClient = textBox_adresse_mail.Text;
                clientmodification.TelephoneDuClient = Convert.ToInt64(textBox_tel.Text);
                clientmodification.ClientParticulier = radioButton_particulier.Checked;
                clientmodification.IdentifiantServiceCommercial = Convert.ToInt64(textbox_service_com.Text);


                if (radioButton_mme.Checked == true)
                {

                    clientmodification.Sexe = false;
                }
                else
                {
                    clientmodification.Sexe = true;
                }

                if (radioButton_particulier.Checked == true)
                {

                    clientmodification.AdresseDeLivraisonClient = textBox_adresse_livraison_prof.Text;
                    clientmodification.CodePostalDeLivraisonClient = textBox_CP_prof.Text;
                    clientmodification.VilleDeLivraisonClient = textBox_ville_prof.Text;
                    clientmodification.NomEnseigne = textBox_nom_enseigne_prof.Text;
                    clientmodification.ComplementAdresseClient = textBox_adresse_livraison_complement_prof.Text;
                    clientmodification.AdresseDeLivraisonClient = textBox_adresse_de_livraison_part.Text;
                    clientmodification.CodePostalDeLivraisonClient = textBox_CP_part.Text;
                    clientmodification.VilleDeLivraisonClient = textBox_ville_part.Text;
                    clientmodification.ComplementAdresseClient = textBox_adresse_de_livraison_complement_part.Text;




                }
                else
                {
                    clientmodification.AdresseDeLivraisonClient = textBox_adresse_de_livraison_part.Text;
                    clientmodification.CodePostalDeLivraisonClient = textBox_CP_part.Text;
                    clientmodification.VilleDeLivraisonClient = textBox_ville_part.Text;
                    clientmodification.ComplementAdresseClient = textBox_adresse_de_livraison_complement_part.Text;
                    clientmodification.AdresseDeLivraisonClient = textBox_adresse_livraison_prof.Text;
                    clientmodification.CodePostalDeLivraisonClient = textBox_CP_prof.Text;
                    clientmodification.VilleDeLivraisonClient = textBox_ville_prof.Text;
                    clientmodification.NomEnseigne = textBox_nom_enseigne_prof.Text;
                    clientmodification.NumeroSiret = Convert.ToInt64(textBox_num_siret_prof.Text);
                    clientmodification.ComplementAdresseClient = textBox_adresse_livraison_complement_prof.Text;

                }
                DialogResult reponse = MessageBox.Show("Souhaitez vous valider les modifications du client ?", "Validation", MessageBoxButtons.YesNo);
                if (reponse == DialogResult.Yes)
                {
                    repo.update(clientmodification);
                    this.Close();
                }

            }
        }

        private void textBox_refe_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_supprimer_client_Click(object sender, EventArgs e)
        {
            client clientinactif = new client();
            clientinactif.IdentifiantClient = Convert.ToInt64(textBox_ident_cli.Text);
            clientinactif.NomDuClient = textBox_nom.Text;
            clientinactif.PrenomDuClient = textBox_prenom.Text;
            clientinactif.VilleDuClient = textBox_Ville.Text;
            clientinactif.ReferenceDuClient = Convert.ToInt64(textBox_refe_client.Text);
            clientinactif.Coefficient = Convert.ToInt64(textBox_coefficient.Text);
            clientinactif.AdresseDuClient = textBox_adresse.Text;
            clientinactif.ComplementAdresse = textBox_complement_adresse.Text;
            clientinactif.VilleDuClient = textBox_Ville.Text;
            clientinactif.CodePostalDuClient = Convert.ToInt64(textBox_CP.Text);
            clientinactif.AdresseMailDuClient = textBox_adresse_mail.Text;
            clientinactif.TelephoneDuClient = Convert.ToInt64(textBox_tel.Text);
            clientinactif.ClientParticulier = radioButton_particulier.Checked;
            clientinactif.IdentifiantServiceCommercial = Convert.ToInt64(textbox_service_com.Text);
            clientinactif.ClientActif = false;


            if (radioButton_mme.Checked == true)
            {

                clientinactif.Sexe = false;
            }
            else
            {
                clientinactif.Sexe = true;
            }

            if (radioButton_particulier.Checked == true)
            {

                clientinactif.AdresseDeLivraisonClient = textBox_adresse_livraison_prof.Text;
                clientinactif.CodePostalDeLivraisonClient = textBox_CP_prof.Text;
                clientinactif.VilleDeLivraisonClient = textBox_ville_prof.Text;
                clientinactif.NomEnseigne = textBox_nom_enseigne_prof.Text;
                clientinactif.ComplementAdresseClient = textBox_adresse_livraison_complement_prof.Text;
                clientinactif.AdresseDeLivraisonClient = textBox_adresse_de_livraison_part.Text;
                clientinactif.CodePostalDeLivraisonClient = textBox_CP_part.Text;
                clientinactif.VilleDeLivraisonClient = textBox_ville_part.Text;
                clientinactif.ComplementAdresseClient = textBox_adresse_de_livraison_complement_part.Text;




            }
            else
            {
                clientinactif.AdresseDeLivraisonClient = textBox_adresse_de_livraison_part.Text;
                clientinactif.CodePostalDeLivraisonClient = textBox_CP_part.Text;
                clientinactif.VilleDeLivraisonClient = textBox_ville_part.Text;
                clientinactif.ComplementAdresseClient = textBox_adresse_de_livraison_complement_part.Text;
                clientinactif.AdresseDeLivraisonClient = textBox_adresse_livraison_prof.Text;
                clientinactif.CodePostalDeLivraisonClient = textBox_CP_prof.Text;
                clientinactif.VilleDeLivraisonClient = textBox_ville_prof.Text;
                clientinactif.NomEnseigne = textBox_nom_enseigne_prof.Text;
                clientinactif.NumeroSiret = Convert.ToInt64(textBox_num_siret_prof.Text);
                clientinactif.ComplementAdresseClient = textBox_adresse_livraison_complement_prof.Text;

            }
            DialogResult reponse = MessageBox.Show("Souhaitez vous désactiver le client ?", "Validation", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                repo.update(clientinactif);
                this.Close();
                choix_client recupcombo = new choix_client();
                recupcombo.comboBox_ref_client.DataSource = repo.List();

            }

        }
    
    }
}
