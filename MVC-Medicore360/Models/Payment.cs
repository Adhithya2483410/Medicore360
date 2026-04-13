namespace MediCore360.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string Status { get; set; } = "Completed";

        public Invoice Invoice { get; set; }
    }
}
