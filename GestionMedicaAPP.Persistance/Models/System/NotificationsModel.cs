﻿namespace GestionMedicaAPP.Persistance.Models.System
{
    public sealed class NotificationsModel
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
