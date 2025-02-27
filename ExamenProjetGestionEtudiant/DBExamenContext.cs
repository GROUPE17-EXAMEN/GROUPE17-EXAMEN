using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class DBExamenContext : DbContext
    {
        public DBExamenContext() : base("examenConnect") { }

        public DbSet<Classe> classes { get; set; }
        public DbSet<Cours> cours { get; set; }
        public DbSet<Etudiant> etudiants { get; set; }
        public DbSet<Matiere> matieres { get; set; }
        public DbSet<Notes> notes { get; set; }
        public DbSet<OTPCodes> otpcodes { get; set; }
        public DbSet<Professeur> professeurs { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }

        
        //public DbSet<ClassesCours> classesCours { get; set; }
        //public DbSet<CoursMatieres> coursMatieres { get; set; }
        //public DbSet<ProfesseursMatieres> professeursMatieres { get; set; }
        //public DbSet<ProfesseursClasses> professeursClasses { get; set; }
    }
}
