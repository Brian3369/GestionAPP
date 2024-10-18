using GestionMedicaAPP.Domain.Entities.Insurase;
using GestionMedicaAPP.Domain.Entities.Security;
using GestionMedicaAPP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Persistance.Interfaces.Security
{
    public interface IRolesRepository : IBaseRepository<Roles>
    {
    }
}
