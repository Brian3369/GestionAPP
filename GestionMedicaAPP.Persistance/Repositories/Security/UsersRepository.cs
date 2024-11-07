using GestionMedicaAPP.Domain.Entities.Security;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Security;
using Microsoft.Extensions.Logging;

namespace GestionMedicaAPP.Persistance.Repositories.Security
{
    public sealed class UsersRepository(GestionMedicaContext context, ILogger<UsersRepository> logger) : BaseRepository<Users>(context), IUsersRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<UsersRepository> logger = logger;


    }
}
