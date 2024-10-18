using GestionMedicaAPP.Domain.Entities.Security;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Security;
using Microsoft.Extensions.Logging;

namespace GestionMedicaAPP.Persistance.Repositories.Security
{
    public sealed class PatiensRepository(GestionMedicaContext context, ILogger<PatiensRepository> logger) : BaseRepository<Patiens>(context), IPatiensRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<PatiensRepository> logger = logger;


    }
}
