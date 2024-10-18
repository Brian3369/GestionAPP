using GestionMedicaAPP.Domain.Entities.Appointmet;
using GestionMedicaAPP.Domain.Result;
using GestionMedicaAPP.Persistance.Base;
using GestionMedicaAPP.Persistance.Context;
using GestionMedicaAPP.Persistance.Interfaces.Appointment;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GestionMedicaAPP.Persistance.Repositories.Appointment
{
    public sealed class AppointmentsRepository(GestionMedicaContext context, ILogger<AppointmentsRepository> logger) : BaseRepository<AppointmentsModel>(context), IAppointmentsRepository
    {
        private readonly GestionMedicaContext context = context;
        private readonly ILogger<AppointmentsRepository> logger = logger;

        public async override Task<OperationResult> Save(AppointmentsModel entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                if (entity == null)
                {
                    result.Success = false;
                    result.Message = "La cita no puede ser nula.";
                    return result;
                }

                if (entity.AppointmentDate == default)
                {
                    result.Success = false;
                    result.Message = "La fecha de la cita es requerida.";
                    return result;
                }

                // Verificar si ya existe una cita para el mismo doctor y paciente en la misma fecha
                if (await base.Exists(a => a.DoctorID == entity.DoctorID && a.PatientID == entity.PatientID && a.AppointmentDate == entity.AppointmentDate))
                {
                    result.Success = false;
                    result.Message = "Ya existe una cita programada para este paciente y doctor en esa fecha.";
                    return result;
                }

                await base.Save(entity);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrió un error guardando la cita.";
                result.Success = false;
                logger.LogError(result.Message, ex.ToString());
            }

            return result;
        }

        public async override Task<OperationResult> Update(AppointmentsModel entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                if (entity == null)
                {
                    result.Success = false;
                    result.Message = "La cita no puede ser nula.";
                    return result;
                }

                if (entity.AppointmentDate == default)
                {
                    result.Success = false;
                    result.Message = "La fecha de la cita es requerida.";
                    return result;
                }

                await base.Update(entity);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrió un error actualizando la cita.";
                result.Success = false;
                logger.LogError(result.Message, ex.ToString());
            }

            return result;
        }
        public async override Task<OperationResult> GetAll()
        {
            OperationResult result = new OperationResult();

            try
            {
                result.Data = await (from appointment in this.context.Appointments
                                     where appointment.StatusID == 1 // Asumiendo que StatusID 1 es "activo"
                                     select new AppointmentsModel()
                                     {
                                         AppointmentsID = appointment.AppointmentsID,
                                         PatientID = appointment.PatientID,
                                         DoctorID = appointment.DoctorID,
                                         AppointmentDate = appointment.AppointmentDate,
                                         StatusID = appointment.StatusID,
                                         CreatedAt = appointment.CreatedAt,
                                         UpdatedAt = appointment.UpdatedAt
                                     })
                                    .AsNoTracking()
                                    .ToListAsync();
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrió un error obteniendo las citas.";
                result.Success = false;
                logger.LogError(result.Message, ex.ToString());
            }

            return result;
        }
        public async override Task<OperationResult> GetEntityBy(int Id)
        {
            OperationResult result = new OperationResult();

            try
            {
                var appointment = await (from a in this.context.Appointments
                                         where a.AppointmentsID == Id
                                         select new AppointmentsModel()
                                         {
                                             AppointmentsID = a.AppointmentsID,
                                             PatientID = a.PatientID,
                                             DoctorID = a.DoctorID,
                                             AppointmentDate = a.AppointmentDate,
                                             StatusID = a.StatusID,
                                             CreatedAt = a.CreatedAt,
                                             UpdatedAt = a.UpdatedAt
                                         })
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync();

                if (appointment == null)
                {
                    result.Success = false;
                    result.Message = "No se encontró la cita.";
                    return result;
                }

                result.Data = appointment;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrió un error obteniendo la cita.";
                result.Success = false;
                logger.LogError(result.Message, ex.ToString());
            }

            return result;
        }
    }
}
