using GestionAPP.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAPP.Domain.Entities.Configuration
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
    }
}
