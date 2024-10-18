using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Domain.Entities.Appointmet
{
    public class DoctorAvailability
    {
        [Key]
        public int AvailabilityID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AvalitableDate { get; set; }
        public TimeSpan StarTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
