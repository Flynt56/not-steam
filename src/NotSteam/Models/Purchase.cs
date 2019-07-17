using System;

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
        public decimal TotalPrice { get; set; }
    }
}