
namespace WebServicePartieClient.Forms
{
    partial class Localisation
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
            this.btnCherche = new System.Windows.Forms.Button();
            this.textS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCherche
            // 
            this.btnCherche.Location = new System.Drawing.Point(244, 34);
            this.btnCherche.Name = "btnCherche";
            this.btnCherche.Size = new System.Drawing.Size(112, 34);
            this.btnCherche.TabIndex = 0;
            this.btnCherche.Text = "chercher";
            this.btnCherche.UseVisualStyleBackColor = true;
            this.btnCherche.Click += new System.EventHandler(this.btnCherche_Click);
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(70, 37);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(150, 31);
            this.textS.TabIndex = 1;
            // 
            // Localisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textS);
            this.Controls.Add(this.btnCherche);
            this.Name = "Localisation";
            this.Text = "Localisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCherche;
        private System.Windows.Forms.TextBox textS;
    }
}