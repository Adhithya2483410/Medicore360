namespace MediCore360.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int? ReceptionistID { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int DurationMinutes { get; set; } = 30;
        public string? Type { get; set; }
        public string Status { get; set; } = "Scheduled";
        public string? CancellationReason { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
        public User? Receptionist { get; set; }
        public Invoice? Invoice { get; set; }
    }
}