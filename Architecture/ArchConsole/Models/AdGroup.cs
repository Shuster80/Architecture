namespace ArchConsole.Models
{
    public class AdGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
