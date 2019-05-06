using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalTaskReminder
    {
        public Guid DeviceId { get; set; }
        public Guid? RecordId { get; set; }
        public DateTime Date { get; set; }
        public string StationName { get; set; }
        public string ReminderName { get; set; }
        public bool ReminderControlled { get; set; }
        public string ReminderDescription { get; set; }

        public long? Tag { get; set; }
    }
}
