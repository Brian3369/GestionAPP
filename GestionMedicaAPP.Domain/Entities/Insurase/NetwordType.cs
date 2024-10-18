using GestionMedicaAPP.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace GestionMedicaAPP.Domain.Entities.Insurase
{
    public class NetwordType : BaseEntity
    {
        [Key]
        public int NetworkTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
