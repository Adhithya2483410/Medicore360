namespace MediCore360.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public string? Category { get; set; }
        public string Status { get; set; } = "Unread";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
    }
}
