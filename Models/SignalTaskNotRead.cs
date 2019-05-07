using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalTaskNotRead
    {
        public Guid DeviceId { get; set; }
        public Guid BranchId { get; set; }
        public Guid? RecordId { get; set; }
        public string StationName { get; set; }
        public string NotReadName { get; set; }
        public string NotReadDescription { get; set; }

        public string TaskName { get; set; }
        public string Employee { get; set; }

        public long? Tag { get; set; }
    }
}
