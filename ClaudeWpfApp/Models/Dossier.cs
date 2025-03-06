using System;

namespace ClaudeWpfApp.Models
{
    public class Dossier
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        public string Description { get; set; }
        
        public Dossier()
        {
            DateCreation = DateTime.Now;
        }
    }
}