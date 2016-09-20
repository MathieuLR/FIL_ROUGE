namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.button_creer_une_fiche_client = new System.Windows.Forms.Button();
            this.button_modif_fiche_client = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_supp_fiche_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_creer_une_fiche_client
            // 
            this.button_creer_une_fiche_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_creer_une_fiche_client.Location = new System.Drawing.Point(94, 26);
            this.button_creer_une_fiche_client.Name = "button_creer_une_fiche_client";
            this.button_creer_une_fiche_client.Size = new System.Drawing.Size(104, 45);
            this.button_creer_une_fiche_client.TabIndex = 0;
            this.button_creer_une_fiche_client.Text = "Creer une fiche client";
            this.button_creer_une_fiche_client.UseVisualStyleBackColor = true;
            // 
            // button_modif_fiche_client
            // 
            this.button_modif_fiche_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modif_fiche_client.Location = new System.Drawing.Point(94, 91);
            this.button_modif_fiche_client.Name = "button_modif_fiche_client";
            this.button_modif_fiche_client.Size = new System.Drawing.Size(104, 45);
            this.button_modif_fiche_client.TabIndex = 1;
            this.button_modif_fiche_client.Text = "Modifier une fiche client";
            this.button_modif_fiche_client.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "retour";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_supp_fiche_client
            // 
            this.button_supp_fiche_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supp_fiche_client.Location = new System.Drawing.Point(94, 153);
            this.button_supp_fiche_client.Name = "button_supp_fiche_client";
            this.button_supp_fiche_client.Size = new System.Drawing.Size(104, 45);
            this.button_supp_fiche_client.TabIndex = 3;
            this.button_supp_fiche_client.Text = "Supprimer une fiche client";
            this.button_supp_fiche_client.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_supp_fiche_client);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_modif_fiche_client);
            this.Controls.Add(this.button_creer_une_fiche_client);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_creer_une_fiche_client;
        private System.Windows.Forms.Button button_modif_fiche_client;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_supp_fiche_client;
    }
}