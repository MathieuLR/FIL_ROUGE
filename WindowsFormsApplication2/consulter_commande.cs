using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL_fil_rouge;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication2
{
    public partial class consulter_commande : Form
    {
        public consulter_commande()
        {
            InitializeComponent();
        }
        bool valideidentifiant = false;
        bool validenumcommande = false;
        

        private void button1_Click(object sender, EventArgs e)
         {
            if (valideidentifiant == true)
            {
                commande_DAO repo = new commande_DAO();
                Int64 id = Convert.ToInt64(textBox_ref_client.Text);
                if (repo.list(id).Count > 0)
                {
                    dataGridView1.DataSource = repo.list(id);
                    valideidentifiant = false;
                    button1.Enabled = false;
                    this.dataGridView1.Columns["AdresseDeLivraison"].Visible = false;
                    this.dataGridView1.Columns["VilleDeLivraison"].Visible = false;
                    this.dataGridView1.Columns["CodePostalDeLivraison"].Visible = false;
                    this.dataGridView1.Columns["AdresseDeFacturation"].Visible = false;
                    this.dataGridView1.Columns["VilleDeFacturation"].Visible = false;
                    this.dataGridView1.Columns["CodePostalDeFacturation"].Visible = false;
                    this.dataGridView1.Columns["NumeroFacture"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Référence client non valide");
                }
            }
            
            if (validenumcommande == true)
            {
                commande_DAO test = new commande_DAO();
                Int64 id = Convert.ToInt64(textBox_num_commande.Text);
                if (test.listnumcom(id).Count > 0)
                {
                    dataGridView1.DataSource = test.listnumcom(id);
                    validenumcommande = false;
                    button1.Enabled = false;
                    this.dataGridView1.Columns["AdresseDeLivraison"].Visible = false;
                    this.dataGridView1.Columns["VilleDeLivraison"].Visible = false;
                    this.dataGridView1.Columns["CodePostalDeLivraison"].Visible = false;
                    this.dataGridView1.Columns["AdresseDeFacturation"].Visible = false;
                    this.dataGridView1.Columns["VilleDeFacturation"].Visible = false;
                    this.dataGridView1.Columns["CodePostalDeFacturation"].Visible = false;
                    this.dataGridView1.Columns["NumeroFacture"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Numéro de commande non valide");
                }

            }
        
        }
            

            
        private void consulter_commande_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
           
        }

  
        private void textBox_num_commande_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string chiffreok = @"^[0-9]{1,60}$";
            if (!Regex.IsMatch(textBox_num_commande.Text, chiffreok))
            {
                textBox_num_commande.Focus();
                validenumcommande = false;

            }
            else
            {
                validenumcommande = true;
                button1.Enabled = true;
            }
        }

        private void textBox_ref_client_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string chiffreok = @"^[0-9]{1,60}$";
            if (!Regex.IsMatch(textBox_ref_client.Text, chiffreok))
            {
                textBox_ref_client.Focus();
                valideidentifiant = false;

            }
            else
            {
                valideidentifiant = true;
                button1.Enabled = true;

            }
        }

        private void textBox_num_commande_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_ref_client.Clear();
            textBox_num_commande.Clear();
            textBox_num_commande.Focus();
        }

        private void textBox_ref_client_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_ref_client.Clear();
            textBox_num_commande.Clear();
            textBox_ref_client.Focus();
        }
    }
}
