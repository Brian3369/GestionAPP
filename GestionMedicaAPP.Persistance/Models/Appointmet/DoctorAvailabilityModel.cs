namespace GestionMedicaAPP.Domain.Entities.Appointmet
{
    public sealed class DoctorAvailabilityModel
    {
        public int AvailabilityID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AvalitableDate { get; set; }
        public TimeSpan StarTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
