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
using System.Text.RegularExpressions;


namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        verif_mail verification = new verif_mail();
        client_DAO repo = new client_DAO();
       
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            
           
            client_DAO repo = new client_DAO();
            if (verification.verifmail(textBox_adresse_mail_recherche))
            {
                string mail = textBox_adresse_mail_recherche.Text;
                if (repo.List_recherche_mail(mail).Count > 0)
                {
                    dataGridView1.DataSource = repo.List_recherche_mail(mail);
                    this.dataGridView1.Columns["ReferenceDuClient"].Visible = false;
                    this.dataGridView1.Columns["AdresseDuClient"].Visible = false;
                    this.dataGridView1.Columns["CodePostalDuClient"].Visible = false;
                    this.dataGridView1.Columns["TelephoneDuClient"].Visible = false;
                    this.dataGridView1.Columns["NumeroSiret"].Visible = false;
                    this.dataGridView1.Columns["NomEnseigne"].Visible = false;
                    this.dataGridView1.Columns["ComplementAdresse"].Visible = false;
                    this.dataGridView1.Columns["AdresseDeLivraisonClient"].Visible = false;
                    this.dataGridView1.Columns["ComplementAdresseClient"].Visible = false;
                    this.dataGridView1.Columns["VilleDeLivraisonClient"].Visible = false;
                    this.dataGridView1.Columns["CodePostalDeLivraisonClient"].Visible = false;
                    this.dataGridView1.Columns["ClientParticulier"].Visible = false;
                    this.dataGridView1.Columns["Sexe"].Visible = false;
                    this.dataGridView1.Columns["ClientActif"].Visible = false;
                    this.dataGridView1.Columns["IdentifiantServiceCommercial"].Visible = false;
                    this.dataGridView1.Columns["Coefficient"].Visible = false;
                    this.dataGridView1.Columns["Affichage"].Visible = false;
                    this.dataGridView1.Columns["AffichageTotal"].Visible = false;

                }
                else
                {
                    MessageBox.Show("Adresse mail inexistante dans la base de donnée");
                }
            }
        }

        //private void verifmail()
        //{
        //    Regex myRegex = new Regex(@"^(.+)@(.+)\.(.+)$");
        //    Match test = myRegex.Match(textBox_adresse_mail_recherche.Text);
        //    if (test.Success)
        //    {
        //        Regex mypremierregex = new Regex(@"^[a-zA-Z0-9_\-\.]{2,50}$");
        //        Match test1 = mypremierregex.Match(test.Groups[1].Value);
        //        if (test1.Success)
        //        {
        //            Regex mydeuxiemeregex = new Regex(@"^[a-zA-Z0-9\-\.]{2,50}$");
        //            Match test2 = mydeuxiemeregex.Match(test.Groups[2].Value);
        //            if (test2.Success)
        //            {
        //                Regex mytroisiemeregex = new Regex(@"^[a-zA-Z]{2,50}$");
        //                Match test3 = mytroisiemeregex.Match(test.Groups[3].Value);
        //                if (test3.Success)
        //                {
        //                    mailvalide = true;
        //                }

        //                else
        //                {
        //                    MessageBox.Show("Erreur sur cette partie de l'adresse mail : ." + test.Groups[3].ToString());
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Erreur sur cette partie de l'adresse mail : @" + test.Groups[2].ToString());
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erreur sur cette partie de l'adresse mail :" + test.Groups[1].ToString());
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("Adresse mail invalide , veuillez saisir une adresse type michel@gmail.com");

        //    }
        //}

        private void textBox_adresse_mail_recherche_TextChanged(object sender, EventArgs e)
        {
            //string chiffreok = @"^[\w\.=-]+@[\w\.-]+\.[\w]{2,3}$";
            //Regex myRegex = new Regex(@"^([\w\.=-]+)@([\w\.-]+)\.([\w]{2,3})$");
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
