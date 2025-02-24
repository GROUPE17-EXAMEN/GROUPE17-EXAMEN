using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class CoursMatieres
    {
        [Key, Column(Order = 0)]
        public int IdCours { get; set; }
        [Key, Column(Order = 1)]
        public int IdMatiere { get; set; }
        [ForeignKey("IdCours")]
        public Cours cours { get; set; }
        [ForeignKey("IdMatiere")]
        public Matiere matiere { get; set; }
    }
}
