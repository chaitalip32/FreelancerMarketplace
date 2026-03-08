namespace FreelanceMarketplace.Models.Proposals
{
    public class Proposal
    {
        public int ProposalId { get; set; }
        public int ProjectId { get; set; }
        public string FreelancerId { get; set; }
        public decimal BidAmount { get; set; }
        public int EstimatedDays { get; set; }
        public string CoverLetter { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
