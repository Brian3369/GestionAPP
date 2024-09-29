using GestionAPP.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAPP.Domain.Entities.Configuration
{
    public class Patients : BaseEntity
    {
        public int? PatienID { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Adress { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone { get; set; }
        public string? BloodType { get; set; }
        public string? Allergies { get; set; }
        public int? InsuranceProviderID { get; set; }
    }
}
