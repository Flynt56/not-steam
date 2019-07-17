using System;

namespace NotSteam.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}