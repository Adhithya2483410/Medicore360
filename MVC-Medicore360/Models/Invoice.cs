namespace MediCore360.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int PatientID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = "Pending";

        public Patient Patient { get; set; }
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
