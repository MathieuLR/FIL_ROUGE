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
    public partial class page_accueil_fil_rouge : Form
    {
        public page_accueil_fil_rouge()
        {
            InitializeComponent();
        }

        private void page_accueil_fil_rouge_Load(object sender, EventArgs e)
        {
           
        }

        private void button_consulter_une_commande_Click(object sender, EventArgs e)
        {
            consulter_commande consult = new consulter_commande();
            consult.ShowDialog();
            Show();
        }

        private void button_recherche_client_Click(object sender, EventArgs e)
        {
            choix_client choix = new choix_client();
            choix.ShowDialog();
            Show();
        }

        private void button_fiche_client_Click(object sender, EventArgs e)
        {
            fiche_client ficheclient = new fiche_client();
            ficheclient.ShowDialog();
            Show();
        }

        private void button_creer_une_commande_Click(object sender, EventArgs e)
        {
            saisie_commande_fil_rouge creacommande = new saisie_commande_fil_rouge();
            creacommande.ShowDialog();
            Show();
        }

        private void button_consulter_le_catalogue_Click(object sender, EventArgs e)
        {
            consultation_catalogue consultcata = new consultation_catalogue();
            consultcata.ShowDialog();
            Show();
        }

        private void button_facture_Click(object sender, EventArgs e)
        {
            facture pagefacture = new facture();
            pagefacture.ShowDialog();
            Show();
        }

        private void button_suivi_livraison_Click(object sender, EventArgs e)
        {
            suivi_livraison pagelivraison = new suivi_livraison();
            pagelivraison.ShowDialog();
            Show();
        }

        private void button_CA_Click(object sender, EventArgs e)
        {
            requete_CA pageCA = new requete_CA();
            pageCA.ShowDialog();
            Show();
        }
    }
}
