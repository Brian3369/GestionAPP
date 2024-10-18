using GestionMedicaAPP.Domain.Entities.Appointmet;
using GestionMedicaAPP.Domain.Entities.Configuration;
using GestionMedicaAPP.Domain.Entities.Insurase;
using GestionMedicaAPP.Domain.Entities.MedicalRecord;
using GestionMedicaAPP.Domain.Entities.Security;
using GestionMedicaAPP.Persistance.Repositories.Appointment;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GestionMedicaAPP.Persistance.Context
{
    public partial class GestionMedicaContext : DbContext
    {
        public GestionMedicaContext(DbContextOptions<GestionMedicaContext> options) : base(options)
        {
        }

        #region "Appointmet Entities"
        public DbSet<AppointmentsModel> Appointments { get; set; }
        public DbSet<DoctorAvailabilityModel> DoctorAvailability { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        #endregion

        #region "Configuration Entities"
        public DbSet<AvailabilityModes> AvailabilityModes { get; set; }
        public DbSet<Specialties> Specialties { get; set; }
        #endregion

        #region "Insurase Entities"
        public DbSet<InsuraseProvider> InsuraseProvider { get; set; }
        public DbSet<NetwordType> NetwordType { get; set; }
        #endregion

        #region "MedicalRecord Entities"
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
        #endregion

        #region "Security Entities"
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patiens> Patiens { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }

        public static implicit operator GestionMedicaContext(DoctorAvailabilityRepository v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
