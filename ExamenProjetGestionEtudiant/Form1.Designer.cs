using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Utilisateurs");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Etudiants");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Classes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cours");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Matières");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Professeurs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Notes");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Gestion", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Dashboard", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1220, 48);
            this.panelNavbar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 566);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud1";
            treeNode1.Text = "Utilisateurs";
            treeNode2.Name = "Nœud2";
            treeNode2.Text = "Etudiants";
            treeNode3.Name = "Nœud3";
            treeNode3.Text = "Classes";
            treeNode4.Name = "Nœud4";
            treeNode4.Text = "Cours";
            treeNode5.Name = "Nœud5";
            treeNode5.Text = "Matières";
            treeNode6.Name = "Nœud6";
            treeNode6.Text = "Professeurs";
            treeNode7.Name = "Nœud7";
            treeNode7.Text = "Notes";
            treeNode8.Name = "Nœud8";
            treeNode8.Text = "Rapports";
            treeNode9.Name = "Nœud9";
            treeNode9.NodeFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode9.Text = "Gestion";
            treeNode10.Name = "Nœud0";
            treeNode10.NodeFont = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode10.Text = "Dashboard";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(214, 566);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(214, 48);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1006, 566);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 614);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelMain;
    }
}

