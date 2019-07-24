using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Purchase : BaseModel
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        [DataType(DataType.Date, ErrorMessage = "Input must be date formatted!")]
        public DateTime DateOfPurchase { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        [Range(0, 99.99, ErrorMessage = "{0} must be between {1} and {2}!")]
        [Column(TypeName = "decimal(19,4)")]
        public decimal TotalPrice { get; set; }
    }
}