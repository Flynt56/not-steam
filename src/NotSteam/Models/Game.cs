using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must provide a Title!")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "You must provide a Release Date!")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(19,4)")]
        [Range(0, 99.99)]
        public decimal BasePrice { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}