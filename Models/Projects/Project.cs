namespace FreelanceMarketplace.Models.Projects
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ClientId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Decimal Budget { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
