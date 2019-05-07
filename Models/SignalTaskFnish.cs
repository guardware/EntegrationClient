using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalTaskFnish
    {
        public Guid DeviceId { get; set; }

        public Guid BranchId { get; set; }
        public Guid? RecordId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TotalTime { get; set; }
        public short VisitedStationCount { get; set; }
        public short WaitingStationCount { get; set; }
        public short SkippedStationCount { get; set; }
        public short MissingStationCount { get; set; }
        public short TotalStationCount { get; set; }
        public short VisitedReminderCount { get; set; }
        public short MissingReminderCount { get; set; }
        public short WaitingReminderCount { get; set; }
        public byte EventCount { get; set; }
        public byte EventEmergencyCount { get; set; }
        public bool NoPlan { get; set; }
        public bool TimesUp { get; set; }

        public string TaskName { get; set; }
        public string Employee { get; set; }

        public long? Tag { get; set; }
    }
}
