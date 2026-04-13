namespace MediCore360.Models
{
    public class AuditLog
    {
        public long AuditID { get; set; }
        public int UserID { get; set; }
        public string Action { get; set; } = string.Empty;
        public string? TableAffected { get; set; }
        public string? RecordID { get; set; }
        public string? IPAddress { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public User User { get; set; } = null!;
    }
}