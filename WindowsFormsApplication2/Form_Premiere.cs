using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form_Premiere : Form
    {
        public Form_Premiere()
        {
            InitializeComponent();
        }
        
        public void parametrefenetre(Form maform)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    f.Close();
            //}
            // maform.FormBorderStyle = FormBorderStyle.FixedSingle;
            maform.MdiParent = this;
            maform.Show();
            maform.MaximizeBox = false;
            //maform.Location = new Point(0, 0);
            //this.Width = maform.Width;
            //this.Height = maform.Height;
            //maform.Dock = DockStyle.Fill;
        }
     

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_fil_rouge login_fil_rouge = new login_fil_rouge();
            parametrefenetre(login_fil_rouge);
        }

        private void consulterFicheClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choix_client choix_client = new choix_client();
            parametrefenetre(choix_client);
        }

        private void nouvelleCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saisie_commande_fil_rouge saisie_commande_fil_rouge = new saisie_commande_fil_rouge();
            parametrefenetre(saisie_commande_fil_rouge);
        }

        private void saisirUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulter_commande consulter_commande = new consulter_commande();
            parametrefenetre(consulter_commande);
        }

        private void consulterCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultation_catalogue consultation_catalogue = new consultation_catalogue();
            parametrefenetre(consultation_catalogue);
        }

        private void consulterChiffreDaffaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            requete_CA requete_CA = new requete_CA();
            parametrefenetre(requete_CA);
        }

        private void consulterUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facture facture = new facture();
            parametrefenetre(facture);
        }

        private void historiqueCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulter_commande consulter_commande = new consulter_commande();
            parametrefenetre(consulter_commande);
        }

        private void suiviLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suivi_livraison suivi_livraison = new suivi_livraison();
            parametrefenetre(suivi_livraison);
        }

        private void consulterUneFicheClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fiche_client_ajout fiche_client = new fiche_client_ajout();
            fiche_client f = new fiche_client();
            f.id = 0;
            //f.Show();
            parametrefenetre(f);
        }

        private void Form_Premiere_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
      
        }

        private void rechercherUnClientInactifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choix_client_inactif choix_client_inactif = new choix_client_inactif();
            parametrefenetre(choix_client_inactif);
        }
    }
}
