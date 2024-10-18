using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Domain.Entities.Appointmet
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
