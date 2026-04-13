namespace MediCore360.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = "Active";

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
