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
    public partial class MatiereForm : Form
    {
        DBExamenContext db;
        public MatiereForm()
        {
            InitializeComponent();
            db = new DBExamenContext();
        }

        private void MatiereForm_Load(object sender, EventArgs e)
        {
            refreshMatiere();
        }
        private void refreshMatiere(){
            dataGridView1.DataSource = db.matieres.ToList();
        
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();
            matiere.NomMatiere = txtNomMatiere.Text;
            db.matieres.Add(matiere);
            int result = db.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Matieres ajouter avec succés");
            }
            refreshMatiere();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtNomMatiere.Text = row.Cells["NomMatiere"].Value?.ToString();

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var idMatiere = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                  var mat = db.matieres.Find(idMatiere);
                    if (mat != null)
                    {
                        mat.NomMatiere = txtNomMatiere.Text;
                        db.SaveChanges();
                    refreshMatiere();
                    MessageBox.Show("matiere modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var idMatiere = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var mat = db.matieres.Find(idMatiere);
                if (mat != null)
                {
                    mat.NomMatiere = txtNomMatiere.Text;
                    db.matieres.Remove(mat);
                    db.SaveChanges();
                    refreshMatiere();
                    MessageBox.Show("matiere supprimer avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
