using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetTask.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public DateTime Echeance { get; set; }

        public string Statut { get; set; } = "à faire";
        public string Priorite { get; set; } = "moyenne";
        public string Categorie { get; set; }

        // Relations
        public int AuteurId { get; set; }
        [ForeignKey("AuteurId")]
        public User Auteur { get; set; }

        public int? RealisateurId { get; set; }
        [ForeignKey("RealisateurId")]
        public User? Realisateur { get; set; }
    }
}
