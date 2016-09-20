namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.comboBox_ref_client = new System.Windows.Forms.ComboBox();
            this.comboBox_prenom = new System.Windows.Forms.ComboBox();
            this.comboBox_nom = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_num_de_commande = new System.Windows.Forms.ComboBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_ref_client
            // 
            this.comboBox_ref_client.FormattingEnabled = true;
            this.comboBox_ref_client.Location = new System.Drawing.Point(127, 166);
            this.comboBox_ref_client.Name = "comboBox_ref_client";
            this.comboBox_ref_client.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ref_client.TabIndex = 108;
            // 
            // comboBox_prenom
            // 
            this.comboBox_prenom.FormattingEnabled = true;
            this.comboBox_prenom.Location = new System.Drawing.Point(127, 122);
            this.comboBox_prenom.Name = "comboBox_prenom";
            this.comboBox_prenom.Size = new System.Drawing.Size(121, 21);
            this.comboBox_prenom.TabIndex = 107;
            // 
            // comboBox_nom
            // 
            this.comboBox_nom.FormattingEnabled = true;
            this.comboBox_nom.Location = new System.Drawing.Point(127, 73);
            this.comboBox_nom.Name = "comboBox_nom";
            this.comboBox_nom.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nom.TabIndex = 106;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 105;
            this.label20.Text = "Référence client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Numéro de commande";
            // 
            // comboBox_num_de_commande
            // 
            this.comboBox_num_de_commande.FormattingEnabled = true;
            this.comboBox_num_de_commande.Location = new System.Drawing.Point(127, 208);
            this.comboBox_num_de_commande.Name = "comboBox_num_de_commande";
            this.comboBox_num_de_commande.Size = new System.Drawing.Size(121, 21);
            this.comboBox_num_de_commande.TabIndex = 111;
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(150, 290);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(79, 28);
            this.button_valider.TabIndex = 113;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            // 
            // button_retour
            // 
            this.button_retour.Location = new System.Drawing.Point(258, 343);
            this.button_retour.Name = "button_retour";
            this.button_retour.Size = new System.Drawing.Size(75, 23);
            this.button_retour.TabIndex = 112;
            this.button_retour.Text = "retour";
            this.button_retour.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 376);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.comboBox_num_de_commande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_ref_client);
            this.Controls.Add(this.comboBox_prenom);
            this.Controls.Add(this.comboBox_nom);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ref_client;
        private System.Windows.Forms.ComboBox comboBox_prenom;
        private System.Windows.Forms.ComboBox comboBox_nom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_num_de_commande;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_retour;
    }
}