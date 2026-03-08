namespace FreelanceMarketplace.Models.Users
{
    public class UserProfile
    {
        public int ProfileId { get; set; }
        public string UserId { get; set; }
        public string Bio { get; set; }
        public decimal HourlyRate { get; set; }
        public string ExperienceYears { get; set; }
        public DateTime CreatedDate {  get; set; }
    }
}
