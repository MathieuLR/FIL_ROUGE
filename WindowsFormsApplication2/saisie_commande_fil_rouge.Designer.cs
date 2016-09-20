namespace WindowsFormsApplication2
{
    partial class saisie_commande_fil_rouge
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
            this.textBox_num_commande = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_libelle_court = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_identifiant_produit = new System.Windows.Forms.TextBox();
            this.button_ajout_commande = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_marque = new System.Windows.Forms.ComboBox();
            this.comboBox_famille_produit = new System.Windows.Forms.ComboBox();
            this.comboBox_choix_produit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_modif_quantite = new System.Windows.Forms.Button();
            this.button_supp_ligne = new System.Windows.Forms.Button();
            this.button_valider = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_prix_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ref_client = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_total_remise = new System.Windows.Forms.TextBox();
            this.textBox_total_ht = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_tva = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sélectionner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_num_commande
            // 
            this.textBox_num_commande.Location = new System.Drawing.Point(217, 183);
            this.textBox_num_commande.Name = "textBox_num_commande";
            this.textBox_num_commande.Size = new System.Drawing.Size(141, 20);
            this.textBox_num_commande.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro de commande";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(708, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libelle court du produit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_libelle_court
            // 
            this.textBox_libelle_court.Location = new System.Drawing.Point(136, 23);
            this.textBox_libelle_court.Name = "textBox_libelle_court";
            this.textBox_libelle_court.Size = new System.Drawing.Size(141, 20);
            this.textBox_libelle_court.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identifiant du porduit";
            // 
            // textBox_identifiant_produit
            // 
            this.textBox_identifiant_produit.Location = new System.Drawing.Point(434, 23);
            this.textBox_identifiant_produit.Name = "textBox_identifiant_produit";
            this.textBox_identifiant_produit.Size = new System.Drawing.Size(141, 20);
            this.textBox_identifiant_produit.TabIndex = 6;
            // 
            // button_ajout_commande
            // 
            this.button_ajout_commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajout_commande.Location = new System.Drawing.Point(324, 348);
            this.button_ajout_commande.Name = "button_ajout_commande";
            this.button_ajout_commande.Size = new System.Drawing.Size(174, 36);
            this.button_ajout_commande.TabIndex = 7;
            this.button_ajout_commande.Text = "Ajouter a la commande";
            this.button_ajout_commande.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Famille du  produit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marque";
            // 
            // comboBox_marque
            // 
            this.comboBox_marque.FormattingEnabled = true;
            this.comboBox_marque.Location = new System.Drawing.Point(396, 64);
            this.comboBox_marque.Name = "comboBox_marque";
            this.comboBox_marque.Size = new System.Drawing.Size(141, 21);
            this.comboBox_marque.TabIndex = 11;
            // 
            // comboBox_famille_produit
            // 
            this.comboBox_famille_produit.FormattingEnabled = true;
            this.comboBox_famille_produit.Location = new System.Drawing.Point(136, 64);
            this.comboBox_famille_produit.Name = "comboBox_famille_produit";
            this.comboBox_famille_produit.Size = new System.Drawing.Size(141, 21);
            this.comboBox_famille_produit.TabIndex = 12;
            // 
            // comboBox_choix_produit
            // 
            this.comboBox_choix_produit.FormattingEnabled = true;
            this.comboBox_choix_produit.Location = new System.Drawing.Point(685, 64);
            this.comboBox_choix_produit.Name = "comboBox_choix_produit";
            this.comboBox_choix_produit.Size = new System.Drawing.Size(141, 21);
            this.comboBox_choix_produit.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Choisissez votre produit";
            // 
            // button_modif_quantite
            // 
            this.button_modif_quantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modif_quantite.Location = new System.Drawing.Point(34, 656);
            this.button_modif_quantite.Name = "button_modif_quantite";
            this.button_modif_quantite.Size = new System.Drawing.Size(142, 35);
            this.button_modif_quantite.TabIndex = 17;
            this.button_modif_quantite.Text = "Modifier la quantité";
            this.button_modif_quantite.UseVisualStyleBackColor = true;
            this.button_modif_quantite.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_supp_ligne
            // 
            this.button_supp_ligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supp_ligne.Location = new System.Drawing.Point(201, 656);
            this.button_supp_ligne.Name = "button_supp_ligne";
            this.button_supp_ligne.Size = new System.Drawing.Size(142, 35);
            this.button_supp_ligne.TabIndex = 18;
            this.button_supp_ligne.Text = "Supprimer une ligne";
            this.button_supp_ligne.UseVisualStyleBackColor = true;
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(477, 767);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(162, 44);
            this.button_valider.TabIndex = 19;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 788);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "retour";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox_prix_total
            // 
            this.textBox_prix_total.Location = new System.Drawing.Point(766, 729);
            this.textBox_prix_total.Name = "textBox_prix_total";
            this.textBox_prix_total.Size = new System.Drawing.Size(100, 20);
            this.textBox_prix_total.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 736);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Prix Total";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(850, 431);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 183);
            this.vScrollBar1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Référence client";
            // 
            // textBox_ref_client
            // 
            this.textBox_ref_client.Location = new System.Drawing.Point(217, 146);
            this.textBox_ref_client.Name = "textBox_ref_client";
            this.textBox_ref_client.Size = new System.Drawing.Size(141, 20);
            this.textBox_ref_client.TabIndex = 30;
            this.textBox_ref_client.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_famille_produit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_libelle_court);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_identifiant_produit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_marque);
            this.groupBox2.Controls.Add(this.comboBox_choix_produit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(81, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 104);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 636);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Total remise";
            // 
            // textBox_total_remise
            // 
            this.textBox_total_remise.Location = new System.Drawing.Point(766, 629);
            this.textBox_total_remise.Name = "textBox_total_remise";
            this.textBox_total_remise.Size = new System.Drawing.Size(100, 20);
            this.textBox_total_remise.TabIndex = 73;
            // 
            // textBox_total_ht
            // 
            this.textBox_total_ht.Location = new System.Drawing.Point(767, 660);
            this.textBox_total_ht.Name = "textBox_total_ht";
            this.textBox_total_ht.Size = new System.Drawing.Size(100, 20);
            this.textBox_total_ht.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(696, 667);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Total HT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 703);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "TVA";
            // 
            // textBox_tva
            // 
            this.textBox_tva.Location = new System.Drawing.Point(767, 696);
            this.textBox_tva.Name = "textBox_tva";
            this.textBox_tva.Size = new System.Drawing.Size(100, 20);
            this.textBox_tva.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.image_fil_rouge_cindy;
            this.pictureBox1.Location = new System.Drawing.Point(70, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 183);
            this.dataGridView1.TabIndex = 78;
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
            // saisie_commande_fil_rouge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 823);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_tva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_total_ht);
            this.Controls.Add(this.textBox_total_remise);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_ref_client);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_prix_total);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.button_supp_ligne);
            this.Controls.Add(this.button_modif_quantite);
            this.Controls.Add(this.button_ajout_commande);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_num_commande);
            this.Name = "saisie_commande_fil_rouge";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.saisie_commande_fil_rouge_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_num_commande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_libelle_court;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_identifiant_produit;
        private System.Windows.Forms.Button button_ajout_commande;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_marque;
        private System.Windows.Forms.ComboBox comboBox_famille_produit;
        private System.Windows.Forms.ComboBox comboBox_choix_produit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modif_quantite;
        private System.Windows.Forms.Button button_supp_ligne;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox_prix_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ref_client;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_total_remise;
        private System.Windows.Forms.TextBox textBox_total_ht;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_tva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sélectionner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}