namespace ArchConsole.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
