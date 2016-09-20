using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_fil_rouge
{
    public partial class fonction_form : Form
    {
        public fonction_form()
        {
            InitializeComponent();
        }

        private void fonction_form_Load(object sender, EventArgs e)
        {

        }

        public void parametrefenetre(Form maform)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    f.Close();
            //}
            maform.FormBorderStyle = FormBorderStyle.None;
            maform.MdiParent = this;
            maform.Show();
            maform.Location = new Point(0, 0);
            this.Width = maform.Width;
            this.Height = maform.Height;
            maform.Dock = DockStyle.Fill;
        }
    }
}
