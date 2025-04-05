using System;
using System.ComponentModel.DataAnnotations;

namespace Template.Web.Models
{
    public class Visitatore
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cognome { get; set; }

        public string Azienda { get; set; }

        [Required]
        public DateTime DataIngresso { get; set; } = DateTime.Now;

        public DateTime? DataUscita { get; set; }

        public string MotivoVisita { get; set; }
    }
}
