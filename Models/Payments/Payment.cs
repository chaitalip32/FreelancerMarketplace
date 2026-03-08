namespace FreelanceMarketplace.Models.Payments
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ContractId { get; set; }
        public string ClientId { get; set; }
        public string FreelancerId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionId { get; set; }
        public string Status { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
