namespace MediCore360.Models
{
    public class ComplianceReport
    {
        public int ReportID { get; set; }
        public string Scope { get; set; }
        public string? Metrics { get; set; }
        public DateTime GeneratedDate { get; set; } = DateTime.UtcNow;
    }
}
