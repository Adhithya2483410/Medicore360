namespace MediCore360.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public int? UserID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly DOB { get; set; }
        public string? Gender { get; set; }
        public string? BloodGroup { get; set; }
        public string ContactInfo { get; set; } = string.Empty;
        public string? EmergencyContact { get; set; }
        public string? MedicalHistory { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime RegisteredDate { get; set; } = DateTime.UtcNow;

        public User? User { get; set; }

        public ICollection<Record> Records { get; set; } = new List<Record>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}