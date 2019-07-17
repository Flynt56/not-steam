using System;

namespace NotSteam.Models
{
    public class Library
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public DateTime DateAcquired { get; set; }
        public int TotalPlayTimeHours { get; set; }
        public DateTime LastPlayedDate { get; set; }
    }
}