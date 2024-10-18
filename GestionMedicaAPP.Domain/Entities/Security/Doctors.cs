using GestionMedicaAPP.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Domain.Entities.Security
{
    public class Doctors : Users
    {
        [Key]
        public int DoctorID { get; set; }
        public int SpecialtyID { get; set; }
        public string linceseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsOfExperience { get; set; }
        public string Education { get; set; }
        public string? Bio { get; set; }
        public decimal? ConsultationFee { get; set; }
        public string? ClinicAdress { get; set; }
        public int? AvailabilityModeld { get; set; }
        public DateTime LicenseExpirationDate { get; set; }
    }
}
