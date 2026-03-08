namespace FreelanceMarketplace.Models.Messaging
{
    public class Message
    {
        public int MessageId { get; set; }
        public int ContractId { get; set; }
        public string SenderId { get; set; }
        public string MessageText { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }

    }
}
