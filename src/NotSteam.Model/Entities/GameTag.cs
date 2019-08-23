namespace NotSteam.Model.Models
{
    public class GameTag : ModelBase
    {
        public int GameId { get; set; }
        public int TagId { get; set; }

        public Game Game { get; set; }
        public Tag Tag { get; set; }
    }
}
