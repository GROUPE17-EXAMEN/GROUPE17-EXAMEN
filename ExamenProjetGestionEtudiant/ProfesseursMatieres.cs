using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class ProfesseursMatieres
    {

        [Key, Column(Order = 0)]
        public int IdProfesseur { get; set; }
        [Key, Column(Order = 1)]
        public int IdMatiere { get; set; }
        [ForeignKey("IdProfesseur")]
        public Professeur professeur { get; set; }
        [ForeignKey("IdMatiere")]
        public Matiere matiere { get; set; }
    }
}
