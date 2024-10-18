using GestionMedicaAPP.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace GestionMedicaAPP.Domain.Entities.MedicalRecord
{
    public class MedicalRecords
    {
        [Key]
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime DateOfVisiy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
