using GestionAPP.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAPP.Domain.Entities.Configuration
{
    public class Doctor : BaseEntity
    {
        public int? DoctorID { get; set; }
        public int? SpecialtyID { get; set; }
        public string? linceseNumber { get; set; }
        public int? YearsOfExperience { get; set; }
        public string? Education {  get; set; }
        public string Bio {  get; set; }
        public decimal ConsultationFee { get; set; }
        public string ClinicAdress {  get; set; }
        public int AvailabilityModeld { get; set; }
        public DateTime? LicenseExpirationDate { get; set; }
    }
}
