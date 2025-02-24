using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class ClassesCours
    {
        [Key, Column(Order = 0)]
        public int IdClasse { get; set; }
        [Key, Column(Order = 1)]
        public int IdCours { get; set; }
        [ForeignKey("IdClasse")]
        public Classe classe { get; set; }
        [ForeignKey("IdCours")]
        public Cours cours { get; set; }
    }
}
