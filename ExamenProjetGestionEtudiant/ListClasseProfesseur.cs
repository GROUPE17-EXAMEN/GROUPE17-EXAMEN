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
    public partial class ListClasseProfesseur : Form
    {
        private int professeurId;
        public ListClasseProfesseur(int id)
        {
            InitializeComponent();
            professeurId = id;
        }

        private void ListClasseProfesseur_Load(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                var classes = db.classes
                                .Where(cl => cl.professeurs.Any(p => p.Id == professeurId))
                                .Select(cl => new
                                {
                                    cl.Id,
                                    cl.NomClasse
                                })
                                .ToList();

                if (classes.Any())
                {
                    dataGridViewListeClasseProfesseur.DataSource = classes;
                }
                else
                {
                    MessageBox.Show("Aucune classe trouvée pour ce professeur.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
