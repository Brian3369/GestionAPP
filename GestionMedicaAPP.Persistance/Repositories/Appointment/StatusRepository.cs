using GestionMedicaAPP.Domain.Entities.Appointmet;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Appointment;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicaAPP.Persistance.Repositories.Appointment
{
    public sealed class StatusRepository(GestionMedicaContext context, ILogger<StatusRepository> logger) : BaseRepository<StatusModel>(context), IStatusRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<StatusRepository> logger = logger;


    }
}
