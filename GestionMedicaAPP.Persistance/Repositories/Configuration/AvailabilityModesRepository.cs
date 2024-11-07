using GestionMedicaAPP.Domain.Entities.Appointmet;
using GestionMedicaAPP.Domain.Entities.Configuration;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Appointment;
using GestionMedicaAPP.Persistance.Interfaces.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Persistance.Repositories.Configuration
{
    public sealed class AvailabilityModesRepository(GestionMedicaContext context, ILogger<AvailabilityModesRepository> logger) : BaseRepository<AvailabilityModes>(context), IAvailabilityModesRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<AvailabilityModesRepository> logger = logger;


    }
}
