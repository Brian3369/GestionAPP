using GestionMedicaAPP.Domain.Entities.Security;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Security;
using Microsoft.Extensions.Logging;

namespace GestionMedicaAPP.Persistance.Repositories.Security
{
    public sealed class DoctorsRepository(GestionMedicaContext context, ILogger<DoctorsRepository> logger) : BaseRepository<Doctors>(context), IDoctorsRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<DoctorsRepository> logger = logger;


    }
}
