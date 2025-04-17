﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTask.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // Tu peux ajouter du hash plus tard

        public ICollection<TaskItem> TachesCreees { get; set; }
        public ICollection<TaskItem> TachesAssignees { get; set; }
    }
}
