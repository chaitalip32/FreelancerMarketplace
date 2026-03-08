namespace FreelanceMarketplace.Models.Contracts
{
    public class Contract
    {
        public int ContractId { get; set; }
        public int ProjectId { get; set; }
        public string ClientId { get; set; }
        public string FreelancerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
    }
}
