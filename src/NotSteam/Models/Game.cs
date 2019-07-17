using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(19,4)")]
        public decimal BasePrice { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}