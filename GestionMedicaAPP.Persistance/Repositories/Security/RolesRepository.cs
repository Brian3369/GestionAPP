using GestionMedicaAPP.Domain.Entities.Security;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Security;
using Microsoft.Extensions.Logging;

namespace GestionMedicaAPP.Persistance.Repositories.Security
{
    public sealed class RolesRepository(GestionMedicaContext context, ILogger<RolesRepository> logger) : BaseRepository<Roles>(context), IRolesRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<RolesRepository> logger = logger;


    }
}
