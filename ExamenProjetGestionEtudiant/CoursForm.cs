using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    public partial class CoursForm : Form
    {
        DBExamenContext db;
        public CoursForm()
        {
            InitializeComponent();
            db = new DBExamenContext();
        }

        private void CoursForm_Load(object sender, EventArgs e)
        {
            cmbMatiere.DataSource = db.matieres.ToList();
            cmbMatiere.DisplayMember = "NomMatiere";
            cmbMatiere.ValueMember = "Id";
            refresh();

            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;

        }

        private void refresh()
        {
            dataGridView1.DataSource = db.cours
                .Select(e => new
                {
                    e.Id,
                    e.NomCours,
                    e.Description,
                    Matiere = e.matieres.Select(m => m.NomMatiere), 
                })
                .AsEnumerable() 
                .Select(e => new CoursView
                {
                    Id = e.Id,
                    NomCours = e.NomCours,
                    Description = e.Description,
                    Matiere = string.Join(", ", e.Matiere), 
                })
                .ToList();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Cours cour = new Cours();
            cour.NomCours = txtNomCours.Text;
            cour.Description = txtDescription.Text;
            cour.matieres = new List<Matiere>();
            if (cmbMatiere.SelectedItem != null)
            {
                Matiere selectedMatiere = (Matiere)cmbMatiere.SelectedItem;
                cour.matieres.Add(selectedMatiere);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une matière.");
            }

            db.cours.Add(cour);
            int result = db.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Cours ajouté avec succès");
            }
            refresh();
            clear();

            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatiereForm matiere = new MatiereForm();
            matiere.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var idCour = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                var couree = db.cours.FirstOrDefault(c => c.Id == idCour);

                if (couree != null)
                {
                    couree.matieres = db.matieres
                                       .Where(m => m.cours.Any(c => c.Id == idCour))
                                       .ToList();

                    couree.NomCours = txtNomCours.Text;
                    couree.Description = txtDescription.Text;

                    if (cmbMatiere.SelectedValue != null)
                    {
                        int matiereId = Convert.ToInt32(cmbMatiere.SelectedValue);
                        var matiere = db.matieres.FirstOrDefault(m => m.Id == matiereId);

                       
                    }
                    db.SaveChanges();

                    refresh(); 

                    MessageBox.Show("Cours modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var row = dataGridView1.Rows[e.RowIndex];

            
                txtNomCours.Text = row.Cells["NomCours"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();

                if (row.Cells["Matiere"].Value != null)
                {
                    string nomMatiere = row.Cells["Matiere"].Value.ToString();

                    var matiere = db.matieres.FirstOrDefault(m => m.NomMatiere == nomMatiere);
                    if (matiere != null)
                    {
                        cmbMatiere.SelectedValue = matiere.Id; 
                    }
                }
            }
        }

        private void clear()
        {
           
            cmbMatiere.SelectedIndex = -1;
           
            txtDescription.Text = "";
            txtNomCours.Text = "";

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var idCour = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                var couree = db.cours.FirstOrDefault(c => c.Id == idCour);

                if (couree != null)
                {
                    couree.matieres = db.matieres
                                       .Where(m => m.cours.Any(c => c.Id == idCour))
                                       .ToList();

                    couree.NomCours = txtNomCours.Text;
                    couree.Description = txtDescription.Text;

                    if (cmbMatiere.SelectedValue != null)
                    {
                        int matiereId = Convert.ToInt32(cmbMatiere.SelectedValue);
                        var matiere = db.matieres.FirstOrDefault(m => m.Id == matiereId);


                    }
                    db.cours.Remove(couree);
                    db.SaveChanges();

                    refresh();

                    MessageBox.Show("Cours Supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }

<<<<<<< Updated upstream
=======
        private void btnListeClasse_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idCour = Convert.ToInt32(txtId.Text);
                ListClasse forme = new ListClasse(idCour);
                forme.ShowDialog();
            }
        }

        private void btnAtribCoursClasse_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idCour = Convert.ToInt32(txtId.Text);
                AttribCourClasseForm form = new AttribCourClasseForm(idCour);
                form.ShowDialog();
            }
>>>>>>> Stashed changes
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddMat_Click(object sender, EventArgs e)
        {
            int coursId = Convert.ToInt32(txtId.Text);

            MatiereForm form = new MatiereForm(coursId);
            form.ShowDialog();

        }

        private void btnListMat_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idCours = Convert.ToInt32(txtId.Text);
                ListMatiereForm listeMatiere = new ListMatiereForm(idCours);
                listeMatiere.ShowDialog();
            }
        }
    }
}
