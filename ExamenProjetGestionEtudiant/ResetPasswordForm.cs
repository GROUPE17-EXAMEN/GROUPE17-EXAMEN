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
    public partial class ResetPasswordForm : Form
    {
        private int utilisateurId;
        public ResetPasswordForm(int id)
        {
            InitializeComponent();
            utilisateurId = id;
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            using(var db = new DBExamenContext())
            {
                Utilisateur ut = db.utilisateurs.Find(utilisateurId);
                if (ut != null)
                {
                    if (string.IsNullOrEmpty(txtAncienPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmNewPassword.Text))
                    {
                        MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!BCrypt.Net.BCrypt.Verify(txtAncienPassword.Text, ut.MotDePasse.ToString()))
                    {
                        MessageBox.Show("Mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                    {
                        MessageBox.Show("Les nouveaux mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ut.MotDePasse = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text);
                    db.SaveChanges();
                    MessageBox.Show("Mot de passe mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
