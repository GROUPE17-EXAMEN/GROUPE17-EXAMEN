using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenProjetGestionEtudiant
{
    public partial class UtilisateurForm : Form
    {
        public UtilisateurForm()
        {
            InitializeComponent();
        }

        private void UtilisateurForm_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();
            dataGridViewUser.DataSource = null;
            dataGridViewUser.DataSource = db.utilisateurs.ToList();
            txtNomUt.Text = string.Empty;
            txtMotDePasse.Text = string.Empty;
            txtTel.Text = string.Empty;
            cmbRole.SelectedIndex = -1;
            cmbRole.Text = "sélectionnez...";
            dataGridViewUser.DataSource = db.utilisateurs.Select(e => new  { Id = e.Id, Nom_Utilisateur = e.NomUtilisateur, Mot_De_Passe = e.MotDePasse, Telephone = e.Telephone, Role = e.Role}).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(var db = new DBExamenContext())
            {
                try
                {
                    Utilisateur ut = new Utilisateur();
                    ut.NomUtilisateur = txtNomUt.Text;
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(txtMotDePasse.Text);
                    ut.MotDePasse = passwordHash;
                    ut.Role = cmbRole.Text;
                    ut.Telephone = txtTel.Text;
                    db.utilisateurs.Add(ut);
                    db.SaveChanges();
                    actualise();
                    MessageBox.Show("Utilisateur ajouté avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUser.Rows.Count)
            {
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
                labelPassword.Visible = false;
                txtMotDePasse.Visible = false;
                btnResetPwd.Visible = true;
                if (Convert.ToInt32(dataGridViewUser.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using( var db = new DBExamenContext())
                    {
                        Utilisateur ut = db.utilisateurs.FirstOrDefault(u => u.Id == id);
                        if (ut != null)
                        {
                            txtId.Text = ut.Id.ToString();
                            txtNomUt.Text = ut.NomUtilisateur;
                            txtMotDePasse.Text = ut.MotDePasse;
                            cmbRole.Text = ut.Role;
                            txtTel.Text = ut.Telephone;
                        }
                        else
                        {
                            MessageBox.Show("Étudiant introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
                }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(var db = new DBExamenContext())
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Utilisateur ut = db.utilisateurs.Find(id);
                    if (ut != null)
                    {
                        ut.NomUtilisateur = txtNomUt.Text;
                        ut.MotDePasse = txtMotDePasse.Text;
                        ut.Role = cmbRole.Text;
                        ut.Telephone = txtTel.Text;
                        db.SaveChanges();
                        actualise();
                        btnSave.Enabled = true;
                        MessageBox.Show("Utilisateur Mise à jour avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomUt.Text = string.Empty;
                        txtMotDePasse.Text = string.Empty;
                        txtTel.Text = string.Empty;
                        cmbRole.Text = "sélectionnez le rôle...";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimé cet utilisateur ", "Alerte!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new DBExamenContext())
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Utilisateur ut = db.utilisateurs.Find(id);
                    if (ut != null)
                    {
                        db.utilisateurs.Remove(ut);
                        db.SaveChanges();
                        MessageBox.Show("Utilisateur supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualise();
                    }
                }
            }
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int id = Convert.ToInt32(txtId.Text);
                Utilisateur ut = db.utilisateurs.Find(id);
                if (ut != null)
                {
                    ResetPasswordForm resetForm = new ResetPasswordForm(id);
                    resetForm.ShowDialog();
                    actualise();
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMotDePasse.Text = string.Empty;
            txtNomUt.Text = string.Empty;
            txtTel.Text = string.Empty;
            cmbRole.Text = string.Empty;
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

