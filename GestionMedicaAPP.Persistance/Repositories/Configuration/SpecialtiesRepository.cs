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
    public sealed class SpecialtiesRepository(GestionMedicaContext context, ILogger<SpecialtiesRepository> logger) : BaseRepository<Specialties>(context), ISpecialtiesRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<SpecialtiesRepository> logger = logger;


    }
}
