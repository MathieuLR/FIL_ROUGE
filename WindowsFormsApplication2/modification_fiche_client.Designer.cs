namespace WindowsFormsApplication2
{
    partial class modification_fiche_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ref_client
            // 
            this.textBox_ref_client.Location = new System.Drawing.Point(140, 82);
            this.textBox_ref_client.Name = "textBox_ref_client";
            this.textBox_ref_client.Size = new System.Drawing.Size(100, 20);
            this.textBox_ref_client.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrer la référence client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_valider
            // 
            this.button_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_valider.Location = new System.Drawing.Point(193, 223);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(79, 28);
            this.button_valider.TabIndex = 2;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            // 
            // button_retour
            // 
            this.button_retour.Location = new System.Drawing.Point(12, 226);
            this.button_retour.Name = "button_retour";
            this.button_retour.Size = new System.Drawing.Size(75, 23);
            this.button_retour.TabIndex = 3;
            this.button_retour.Text = "retour";
            this.button_retour.UseVisualStyleBackColor = true;
            // 
            // modification_fiche_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ref_client);
            this.Name = "modification_fiche_client";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ref_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_retour;
    }
}