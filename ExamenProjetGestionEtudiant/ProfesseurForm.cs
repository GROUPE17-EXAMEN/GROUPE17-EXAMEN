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
    public partial class ProfesseurForm : Form
    {
        DBExamenContext db;
        public ProfesseurForm()
        {
            db= new DBExamenContext();
            InitializeComponent();
           
        }
        private void miseAjour()
        {
            dataGridView1.DataSource = db.professeurs.ToList();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Professeur prof = new Professeur();
            prof.Prenom=txtPrenom.Text;
            prof.Nom=txtNom.Text;
            prof.Telephone=txtTelephone.Text;
            prof.Email=txtEmail.Text;
            db.professeurs.Add(prof);
            int result = db.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Professeur ajouté avec succès");
            }
            miseAjour();
            clear();
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;

        }

        private void ProfesseurForm_Load(object sender, EventArgs e)
        {
            miseAjour();
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtPrenom.Text = row.Cells["Prenom"].Value?.ToString();
                txtNom.Text = row.Cells["Nom"].Value?.ToString();
                txtTelephone.Text = row.Cells["Telephone"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var idprof = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var prof = db.professeurs.Find(idprof);
                if (prof != null)
                {
                    prof.Prenom = txtPrenom.Text;
                    prof.Nom = txtNom.Text;
                    prof.Email = txtEmail.Text;
                    prof.Telephone = txtTelephone.Text;

                    db.SaveChanges();
                    miseAjour();
                    clear();
                    MessageBox.Show("Professeur modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clear()
        {
            txtTelephone.Text = "";
            txtPrenom.Text = "";
            txtNom.Text = "";
            txtEmail.Text = "";



        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var idprof = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var prof = db.professeurs.Find(idprof);
                if (prof != null)
                {
                    prof.Prenom = txtPrenom.Text;
                    prof.Nom = txtNom.Text;
                    prof.Email = txtEmail.Text;
                    prof.Telephone = txtTelephone.Text;
                    db.professeurs.Remove(prof);
                    db.SaveChanges();
                    miseAjour();
                    clear();
                    MessageBox.Show("Professeur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
