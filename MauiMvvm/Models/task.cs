using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class task
    {
        public int  Id { get; set; }
        public string Titre { get; set; }
        public string Desc { get; set; }
        public enum Etat { en_cours, fini, pas_commencer }
        public DateTime Date_rendu { get; set; }
        public DateTime updated_at { get; set; }
    }
}
