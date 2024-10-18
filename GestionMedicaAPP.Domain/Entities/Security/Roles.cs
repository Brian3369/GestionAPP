using GestionMedicaAPP.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace GestionMedicaAPP.Domain.Entities.Security
{
    public class Roles : BaseEntity
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
