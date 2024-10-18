using GestionMedicaAPP.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace GestionMedicaAPP.Domain.Entities.Configuration
{
    public class AvailabilityModes : BaseEntity
    {
        [Key]
        public int SAvailabilityModelID { get; set; }
        public string AvailabilityMode { get; set; }
    }
}
