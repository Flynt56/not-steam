using System;

namespace NotSteam.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}