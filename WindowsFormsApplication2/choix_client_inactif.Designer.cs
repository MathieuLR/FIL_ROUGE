namespace WindowsFormsApplication2
{
    partial class choix_client_inactif
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
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_ref_client = new System.Windows.Forms.ComboBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 99;
            this.label20.Text = "Identifiant Client";
            // 
            // comboBox_ref_client
            // 
            this.comboBox_ref_client.FormattingEnabled = true;
            this.comboBox_ref_client.Location = new System.Drawing.Point(117, 66);
            this.comboBox_ref_client.Name = "comboBox_ref_client";
            this.comboBox_ref_client.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ref_client.TabIndex = 103;
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(180, 178);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(79, 28);
            this.button_valider.TabIndex = 104;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_retour
            // 
            this.button_retour.Location = new System.Drawing.Point(12, 183);
            this.button_retour.Name = "button_retour";
            this.button_retour.Size = new System.Drawing.Size(75, 23);
            this.button_retour.TabIndex = 105;
            this.button_retour.Text = "retour";
            this.button_retour.UseVisualStyleBackColor = true;
            // 
            // choix_client_inactif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 218);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.comboBox_ref_client);
            this.Controls.Add(this.label20);
            this.Name = "choix_client_inactif";
            this.Text = "choix_client_inactif";
            this.Load += new System.EventHandler(this.choix_client_inactif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.ComboBox comboBox_ref_client;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_retour;
    }
}