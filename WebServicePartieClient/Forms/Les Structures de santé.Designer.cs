namespace WebServicePartieClient.Forms
{
    partial class Les_Structures_de_santé
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
            this.dgvStruct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStruct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStruct
            // 
            this.dgvStruct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStruct.GridColor = System.Drawing.Color.White;
            this.dgvStruct.Location = new System.Drawing.Point(0, 0);
            this.dgvStruct.Name = "dgvStruct";
            this.dgvStruct.RowHeadersWidth = 62;
            this.dgvStruct.RowTemplate.Height = 33;
            this.dgvStruct.Size = new System.Drawing.Size(800, 450);
            this.dgvStruct.TabIndex = 0;
            this.dgvStruct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStruct_CellContentClick);
            // 
            // Les_Structures_de_santé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStruct);
            this.Name = "Les_Structures_de_santé";
            this.Text = "Les_Structures_de_santé";
            this.Load += new System.EventHandler(this.Les_Structures_de_santé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStruct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStruct;
    }
}