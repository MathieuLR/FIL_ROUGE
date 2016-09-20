namespace WindowsFormsApplication2
{
    partial class facture
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
            this.textBox_ref_client = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_num_commande = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_pro = new System.Windows.Forms.RadioButton();
            this.textBox_prenom_lieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nom_lieu = new System.Windows.Forms.TextBox();
            this.textBox_raison_sociale = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_num_siret = new System.Windows.Forms.TextBox();
            this.textBox_ville_lieu = new System.Windows.Forms.TextBox();
            this.textBox_CP_lieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_adresse_livraison_complement_lieu = new System.Windows.Forms.TextBox();
            this.textBox_adresse_livraison_lieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tva = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_total_ht = new System.Windows.Forms.TextBox();
            this.textBox_total_remise = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_prix_total = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sélectionner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_imprimer_facture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_retour = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ref_client
            // 
            this.textBox_ref_client.Location = new System.Drawing.Point(779, 60);
            this.textBox_ref_client.Name = "textBox_ref_client";
            this.textBox_ref_client.Size = new System.Drawing.Size(141, 20);
            this.textBox_ref_client.TabIndex = 83;
            this.textBox_ref_client.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Référence client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Numéro de commande";
            // 
            // textBox_num_commande
            // 
            this.textBox_num_commande.Location = new System.Drawing.Point(779, 97);
            this.textBox_num_commande.Name = "textBox_num_commande";
            this.textBox_num_commande.Size = new System.Drawing.Size(141, 20);
            this.textBox_num_commande.TabIndex = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vScrollBar1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textBox_tva);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_total_ht);
            this.groupBox2.Controls.Add(this.textBox_total_remise);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_prix_total);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(141, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 427);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Récapitulatif de la commande";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(831, 19);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 183);
            this.vScrollBar1.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_pro);
            this.groupBox1.Controls.Add(this.textBox_prenom_lieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_nom_lieu);
            this.groupBox1.Controls.Add(this.textBox_raison_sociale);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_num_siret);
            this.groupBox1.Controls.Add(this.textBox_ville_lieu);
            this.groupBox1.Controls.Add(this.textBox_CP_lieu);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox_adresse_livraison_complement_lieu);
            this.groupBox1.Controls.Add(this.textBox_adresse_livraison_lieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 211);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lieu de livraison";
            // 
            // radioButton_pro
            // 
            this.radioButton_pro.AutoSize = true;
            this.radioButton_pro.Location = new System.Drawing.Point(18, 155);
            this.radioButton_pro.Name = "radioButton_pro";
            this.radioButton_pro.Size = new System.Drawing.Size(81, 17);
            this.radioButton_pro.TabIndex = 86;
            this.radioButton_pro.TabStop = true;
            this.radioButton_pro.Text = "professionel";
            this.radioButton_pro.UseVisualStyleBackColor = true;
            // 
            // textBox_prenom_lieu
            // 
            this.textBox_prenom_lieu.Location = new System.Drawing.Point(305, 113);
            this.textBox_prenom_lieu.Name = "textBox_prenom_lieu";
            this.textBox_prenom_lieu.ReadOnly = true;
            this.textBox_prenom_lieu.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom_lieu.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Nom";
            // 
            // textBox_nom_lieu
            // 
            this.textBox_nom_lieu.Location = new System.Drawing.Point(90, 117);
            this.textBox_nom_lieu.Name = "textBox_nom_lieu";
            this.textBox_nom_lieu.ReadOnly = true;
            this.textBox_nom_lieu.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom_lieu.TabIndex = 82;
            // 
            // textBox_raison_sociale
            // 
            this.textBox_raison_sociale.Location = new System.Drawing.Point(333, 178);
            this.textBox_raison_sociale.Name = "textBox_raison_sociale";
            this.textBox_raison_sociale.ReadOnly = true;
            this.textBox_raison_sociale.Size = new System.Drawing.Size(197, 20);
            this.textBox_raison_sociale.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(241, 185);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 80;
            this.label19.Text = "Raison sociale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Numéro SIRET";
            // 
            // textBox_num_siret
            // 
            this.textBox_num_siret.Location = new System.Drawing.Point(110, 178);
            this.textBox_num_siret.Name = "textBox_num_siret";
            this.textBox_num_siret.ReadOnly = true;
            this.textBox_num_siret.Size = new System.Drawing.Size(100, 20);
            this.textBox_num_siret.TabIndex = 78;
            // 
            // textBox_ville_lieu
            // 
            this.textBox_ville_lieu.Location = new System.Drawing.Point(305, 84);
            this.textBox_ville_lieu.Name = "textBox_ville_lieu";
            this.textBox_ville_lieu.ReadOnly = true;
            this.textBox_ville_lieu.Size = new System.Drawing.Size(149, 20);
            this.textBox_ville_lieu.TabIndex = 72;
            // 
            // textBox_CP_lieu
            // 
            this.textBox_CP_lieu.Location = new System.Drawing.Point(90, 84);
            this.textBox_CP_lieu.Name = "textBox_CP_lieu";
            this.textBox_CP_lieu.ReadOnly = true;
            this.textBox_CP_lieu.Size = new System.Drawing.Size(149, 20);
            this.textBox_CP_lieu.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "Code Postal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "Ville";
            // 
            // textBox_adresse_livraison_complement_lieu
            // 
            this.textBox_adresse_livraison_complement_lieu.Location = new System.Drawing.Point(131, 54);
            this.textBox_adresse_livraison_complement_lieu.Name = "textBox_adresse_livraison_complement_lieu";
            this.textBox_adresse_livraison_complement_lieu.ReadOnly = true;
            this.textBox_adresse_livraison_complement_lieu.Size = new System.Drawing.Size(495, 20);
            this.textBox_adresse_livraison_complement_lieu.TabIndex = 71;
            // 
            // textBox_adresse_livraison_lieu
            // 
            this.textBox_adresse_livraison_lieu.Location = new System.Drawing.Point(131, 24);
            this.textBox_adresse_livraison_lieu.Name = "textBox_adresse_livraison_lieu";
            this.textBox_adresse_livraison_lieu.ReadOnly = true;
            this.textBox_adresse_livraison_lieu.Size = new System.Drawing.Size(495, 20);
            this.textBox_adresse_livraison_lieu.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Adresse de facturation 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Adresse de facturation";
            // 
            // textBox_tva
            // 
            this.textBox_tva.Location = new System.Drawing.Point(748, 288);
            this.textBox_tva.Name = "textBox_tva";
            this.textBox_tva.Size = new System.Drawing.Size(100, 20);
            this.textBox_tva.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(678, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "TVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(678, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 83;
            this.label10.Text = "Total HT";
            // 
            // textBox_total_ht
            // 
            this.textBox_total_ht.Location = new System.Drawing.Point(748, 252);
            this.textBox_total_ht.Name = "textBox_total_ht";
            this.textBox_total_ht.Size = new System.Drawing.Size(100, 20);
            this.textBox_total_ht.TabIndex = 82;
            // 
            // textBox_total_remise
            // 
            this.textBox_total_remise.Location = new System.Drawing.Point(748, 221);
            this.textBox_total_remise.Name = "textBox_total_remise";
            this.textBox_total_remise.Size = new System.Drawing.Size(100, 20);
            this.textBox_total_remise.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(678, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Total remise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Prix Total";
            // 
            // textBox_prix_total
            // 
            this.textBox_prix_total.Location = new System.Drawing.Point(748, 321);
            this.textBox_prix_total.Name = "textBox_prix_total";
            this.textBox_prix_total.Size = new System.Drawing.Size(100, 20);
            this.textBox_prix_total.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sélectionner,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 183);
            this.dataGridView1.TabIndex = 72;
            // 
            // Sélectionner
            // 
            this.Sélectionner.HeaderText = "Ligne";
            this.Sélectionner.Name = "Sélectionner";
            this.Sélectionner.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Libelle du produit";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code Article";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix HT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix TTC";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Réduction";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(659, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Date de Livraison";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(779, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // button_imprimer_facture
            // 
            this.button_imprimer_facture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_imprimer_facture.Location = new System.Drawing.Point(931, 696);
            this.button_imprimer_facture.Name = "button_imprimer_facture";
            this.button_imprimer_facture.Size = new System.Drawing.Size(142, 35);
            this.button_imprimer_facture.TabIndex = 91;
            this.button_imprimer_facture.Text = "Imprimer facture";
            this.button_imprimer_facture.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.image_fil_rouge_cindy;
            this.pictureBox1.Location = new System.Drawing.Point(57, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // button_retour
            // 
            this.button_retour.Location = new System.Drawing.Point(12, 708);
            this.button_retour.Name = "button_retour";
            this.button_retour.Size = new System.Drawing.Size(75, 23);
            this.button_retour.TabIndex = 92;
            this.button_retour.Text = "retour";
            this.button_retour.UseVisualStyleBackColor = true;
            // 
            // facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 743);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.button_imprimer_facture);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_ref_client);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_num_commande);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "facture";
            this.Text = "facture";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ref_client;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_num_commande;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_pro;
        private System.Windows.Forms.TextBox textBox_prenom_lieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nom_lieu;
        private System.Windows.Forms.TextBox textBox_raison_sociale;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_num_siret;
        private System.Windows.Forms.TextBox textBox_ville_lieu;
        private System.Windows.Forms.TextBox textBox_CP_lieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_adresse_livraison_complement_lieu;
        private System.Windows.Forms.TextBox textBox_adresse_livraison_lieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_total_ht;
        private System.Windows.Forms.TextBox textBox_total_remise;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_prix_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sélectionner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_imprimer_facture;
        private System.Windows.Forms.Button button_retour;
    }
}