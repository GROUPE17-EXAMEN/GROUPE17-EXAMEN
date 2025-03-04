namespace ExamenProjetGestionEtudiant
{
    partial class ListMatiereForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewListMatiere = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewListMatiere);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewListMatiere
            // 
            this.dataGridViewListMatiere.AllowUserToAddRows = false;
            this.dataGridViewListMatiere.AllowUserToDeleteRows = false;
            this.dataGridViewListMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListMatiere.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewListMatiere.Name = "dataGridViewListMatiere";
            this.dataGridViewListMatiere.ReadOnly = true;
            this.dataGridViewListMatiere.RowHeadersWidth = 62;
            this.dataGridViewListMatiere.RowTemplate.Height = 28;
            this.dataGridViewListMatiere.Size = new System.Drawing.Size(797, 409);
            this.dataGridViewListMatiere.TabIndex = 0;
            // 
            // ListMatiereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListMatiereForm";
            this.Text = "ListMatiereForm";
            this.Load += new System.EventHandler(this.ListMatiereForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListMatiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListMatiere;
    }
}