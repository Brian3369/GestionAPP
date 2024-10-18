using GestionMedicaAPP.Domain.Entities.Configuration;
using GestionMedicaAPP.Domain.Entities.Insurase;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Configuration;
using GestionMedicaAPP.Persistance.Interfaces.Insurase;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Persistance.Repositories.Insurase
{
    public sealed class InsuraseProviderRepository(GestionMedicaContext context, ILogger<InsuraseProviderRepository> logger) : BaseRepository<InsuraseProvider>(context), IInsuraseProviderRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<InsuraseProviderRepository> logger = logger;


    }
}
