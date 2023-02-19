namespace ArchConsole.Models
{
    public class Ad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public int AdGroupId { get; set; }
        public AdGroup AdGroup { get; set; }
    }
}
