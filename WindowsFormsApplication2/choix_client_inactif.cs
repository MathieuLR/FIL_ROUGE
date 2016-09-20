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
    public partial class choix_client_inactif : Form
    {
        client_DAO repo = new client_DAO();

        public choix_client_inactif()
        {
            InitializeComponent();
        }

        private void choix_client_inactif_Load(object sender, EventArgs e)
        {
            List<client> liste = new List<client>();
            liste = repo.list_inactif();

            comboBox_ref_client.ValueMember = "IdentifiantClient";
            comboBox_ref_client.DisplayMember = "Affichage";
            comboBox_ref_client.DataSource = repo.list_inactif();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            fiche_client ficheclient = new fiche_client();
            ficheclient.id = (Int64)comboBox_ref_client.SelectedValue;

            
            ficheclient.MaximizeBox = false;
            ficheclient.MdiParent = this.MdiParent;
            ficheclient.Show();
            
        }
    }
}
