namespace WindowsFormsApplication2
{
    partial class consulter_commande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ref_client = new System.Windows.Forms.TextBox();
            this.textBox_num_commande = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.image_fil_rouge_cindy;
            this.pictureBox2.Location = new System.Drawing.Point(55, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Référence client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 168);
            this.dataGridView1.TabIndex = 99;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 100;
            this.button5.Text = "retour";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Numéro de commande";
            // 
            // textBox_ref_client
            // 
            this.textBox_ref_client.Location = new System.Drawing.Point(171, 171);
            this.textBox_ref_client.Name = "textBox_ref_client";
            this.textBox_ref_client.Size = new System.Drawing.Size(100, 20);
            this.textBox_ref_client.TabIndex = 103;
            this.textBox_ref_client.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_ref_client_MouseClick);
            this.textBox_ref_client.TextChanged += new System.EventHandler(this.textBox_ref_client_TextChanged);
            // 
            // textBox_num_commande
            // 
            this.textBox_num_commande.Location = new System.Drawing.Point(433, 171);
            this.textBox_num_commande.Name = "textBox_num_commande";
            this.textBox_num_commande.Size = new System.Drawing.Size(100, 20);
            this.textBox_num_commande.TabIndex = 104;
            this.textBox_num_commande.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_num_commande_MouseClick);
            this.textBox_num_commande.TextChanged += new System.EventHandler(this.textBox_num_commande_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 105;
            this.button1.Text = "Chercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consulter_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_num_commande);
            this.Controls.Add(this.textBox_ref_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "consulter_commande";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.consulter_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ref_client;
        private System.Windows.Forms.TextBox textBox_num_commande;
        private System.Windows.Forms.Button button1;
    }
}