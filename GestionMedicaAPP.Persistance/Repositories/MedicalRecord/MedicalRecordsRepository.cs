using GestionMedicaAPP.Domain.Entities.MedicalRecord;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.MedicalRecord;
using Microsoft.Extensions.Logging;


namespace GestionMedicaAPP.Persistance.Repositories.MedicalRecord
{
    public sealed class MedicalRecordsRepository(GestionMedicaContext context, ILogger<MedicalRecordsRepository> logger) : BaseRepository<MedicalRecords>(context), IMedicalRecordsRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<MedicalRecordsRepository> logger = logger;


    }
}
