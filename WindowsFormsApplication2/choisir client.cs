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
    public partial class choix_client : Form
    {
        client_DAO repo = new client_DAO();
        public choix_client()
        {
            InitializeComponent();
        }
        //public void parametrefenetre(Form maform)
        //{

        //    maform.FormBorderStyle = FormBorderStyle.None;
        //    maform.MdiParent = this;
        //    maform.Show();
        //    maform.Location = new Point(0, 0);
        //    this.Width = maform.Width;
        //    this.Height = maform.Height;
        //    maform.Dock = DockStyle.Fill;
        //}


        private void button_valider_Click(object sender, EventArgs e)
        {
            fiche_client ficheclient = new fiche_client();
            ficheclient.id = (Int64)comboBox_ref_client.SelectedValue;
            
            //parametrefenetre(ficheclient);
            //ficheclient.FormBorderStyle = FormBorderStyle.None;
            ficheclient.MaximizeBox = false;
            ficheclient.MdiParent = this.MdiParent;
            ficheclient.Show();
            //ficheclient.Location = new Point(0, 0);
            //this.Width = ficheclient.Width;
            //this.Height = ficheclient.Height;
            //ficheclient.Dock = DockStyle.Fill;

         


        }

        public void choix_client_Load(object sender, EventArgs e)
        {
        
            List<client> liste = new List<client>();
            liste = repo.List();

            comboBox_ref_client.ValueMember = "IdentifiantClient";
            comboBox_ref_client.DisplayMember = "Affichage";
            comboBox_ref_client.DataSource = repo.List();

        }

        public void comboBox_ref_client_SelectedIndexChanged(object sender, EventArgs e)
        {
           string identifiant = comboBox_ref_client.SelectedItem.ToString();
        }

        private void button_recherche_client_Click(object sender, EventArgs e)
        {
            Form6 rechercheclient = new Form6();
            rechercheclient.MaximizeBox = false;
            rechercheclient.MdiParent = this.MdiParent;
            rechercheclient.Show();

        }

        private void button_retour_Click(object sender, EventArgs e)
        {

        }
    }
}
