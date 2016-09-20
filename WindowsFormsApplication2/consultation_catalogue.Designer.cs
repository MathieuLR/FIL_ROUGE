namespace WindowsFormsApplication2
{
    partial class consultation_catalogue
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_produit = new System.Windows.Forms.GroupBox();
            this.comboBox_sous_rubrique = new System.Windows.Forms.ComboBox();
            this.comboBox_rubrique = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_code_article = new System.Windows.Forms.ComboBox();
            this.comboBox_libelle_du_produit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_afficher = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton_produit_commandé = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_produit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.image_fil_rouge_cindy;
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_produit
            // 
            this.groupBox_produit.Controls.Add(this.comboBox_sous_rubrique);
            this.groupBox_produit.Controls.Add(this.comboBox_rubrique);
            this.groupBox_produit.Controls.Add(this.label4);
            this.groupBox_produit.Controls.Add(this.label3);
            this.groupBox_produit.Controls.Add(this.comboBox_code_article);
            this.groupBox_produit.Controls.Add(this.comboBox_libelle_du_produit);
            this.groupBox_produit.Controls.Add(this.label2);
            this.groupBox_produit.Controls.Add(this.label1);
            this.groupBox_produit.Location = new System.Drawing.Point(12, 173);
            this.groupBox_produit.Name = "groupBox_produit";
            this.groupBox_produit.Size = new System.Drawing.Size(633, 104);
            this.groupBox_produit.TabIndex = 72;
            this.groupBox_produit.TabStop = false;
            this.groupBox_produit.Text = "Produit";
            // 
            // comboBox_sous_rubrique
            // 
            this.comboBox_sous_rubrique.FormattingEnabled = true;
            this.comboBox_sous_rubrique.Location = new System.Drawing.Point(383, 60);
            this.comboBox_sous_rubrique.Name = "comboBox_sous_rubrique";
            this.comboBox_sous_rubrique.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sous_rubrique.TabIndex = 8;
            // 
            // comboBox_rubrique
            // 
            this.comboBox_rubrique.FormattingEnabled = true;
            this.comboBox_rubrique.Location = new System.Drawing.Point(383, 19);
            this.comboBox_rubrique.Name = "comboBox_rubrique";
            this.comboBox_rubrique.Size = new System.Drawing.Size(121, 21);
            this.comboBox_rubrique.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sous Rubrique";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rubrique";
            // 
            // comboBox_code_article
            // 
            this.comboBox_code_article.FormattingEnabled = true;
            this.comboBox_code_article.Location = new System.Drawing.Point(115, 60);
            this.comboBox_code_article.Name = "comboBox_code_article";
            this.comboBox_code_article.Size = new System.Drawing.Size(121, 21);
            this.comboBox_code_article.TabIndex = 4;
            // 
            // comboBox_libelle_du_produit
            // 
            this.comboBox_libelle_du_produit.FormattingEnabled = true;
            this.comboBox_libelle_du_produit.Location = new System.Drawing.Point(115, 20);
            this.comboBox_libelle_du_produit.Name = "comboBox_libelle_du_produit";
            this.comboBox_libelle_du_produit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_libelle_du_produit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle du produit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(46, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 73;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code Article";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Libelle du produit";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix HT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix TTC";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "En stock";
            this.Column5.Name = "Column5";
            // 
            // button_afficher
            // 
            this.button_afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_afficher.Location = new System.Drawing.Point(252, 302);
            this.button_afficher.Name = "button_afficher";
            this.button_afficher.Size = new System.Drawing.Size(135, 31);
            this.button_afficher.TabIndex = 74;
            this.button_afficher.Text = "Afficher";
            this.button_afficher.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(615, 631);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 75;
            this.button5.Text = "retour";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // radioButton_produit_commandé
            // 
            this.radioButton_produit_commandé.AutoSize = true;
            this.radioButton_produit_commandé.Location = new System.Drawing.Point(46, 332);
            this.radioButton_produit_commandé.Name = "radioButton_produit_commandé";
            this.radioButton_produit_commandé.Size = new System.Drawing.Size(123, 17);
            this.radioButton_produit_commandé.TabIndex = 76;
            this.radioButton_produit_commandé.TabStop = true;
            this.radioButton_produit_commandé.Text = "Produits commandés";
            this.radioButton_produit_commandé.UseVisualStyleBackColor = true;
            // 
            // consultation_catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 666);
            this.Controls.Add(this.radioButton_produit_commandé);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_afficher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_produit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "consultation_catalogue";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_produit.ResumeLayout(false);
            this.groupBox_produit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_produit;
        private System.Windows.Forms.ComboBox comboBox_code_article;
        private System.Windows.Forms.ComboBox comboBox_libelle_du_produit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sous_rubrique;
        private System.Windows.Forms.ComboBox comboBox_rubrique;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button_afficher;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton_produit_commandé;
    }
}