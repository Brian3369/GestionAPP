using GestionMedicaAPP.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Domain.Entities.Configuration
{
    public class Specialties : BaseEntity
    {
        [Key]
        public int SpecialtyID { get; set; }
        public string SpecialtyName { get; set; }
    }
}
