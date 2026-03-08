using System.Numerics;

namespace FreelanceMarketplace.Models.Reviews
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ContractId { get; set; }
        public string ReviewerId { get; set; }
        public string RevieweeId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
