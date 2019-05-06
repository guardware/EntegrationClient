using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalTaskStart
    {
        public Guid BranchId { get; set; }
        public Guid DeviceId { get; set; }
        public Guid? RecordId { get; set; }
        public string Employee { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan PlanEndTime { get; set; }
        public TimeSpan PlanStartTime { get; set; }
        public string TaskName { get; set; }
        public string TaskType { get; set; }
        public bool NoPlan { get; set; }

        public long? Tag { get; set; }
    }
}
