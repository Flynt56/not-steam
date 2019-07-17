using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotSteam.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public DateTime DateOfPurchase { get; set; }
        [Column(TypeName = "decimal(19,4)")]
        public decimal TotalPrice { get; set; }
    }
}