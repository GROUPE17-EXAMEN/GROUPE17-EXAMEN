using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFormInPanel(Form form)
        {
            
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);
            panelMain.Tag = form; 
            form.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Utilisateurs":
                    LoadFormInPanel(new UtilisateurForm());
                    break;
            }

        }
    }
}
