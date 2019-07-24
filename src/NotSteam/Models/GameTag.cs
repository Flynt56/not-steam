namespace NotSteam.Models
{
    public class GameTag : BaseModel
    {
        // One game can have only one of each tag.
        // There must not be duplicate tags per game.
        // Any game can have any tags as long as there are no duplicates.

        public int GameId { get; set; }

        public Game Game { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}