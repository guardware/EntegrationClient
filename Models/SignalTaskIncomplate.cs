using System;
using System.Collections.Generic;

namespace IdenfitGuardware.Client.Models
{
    public class SignalTaskIncomplate
    {
        public Guid DeviceId { get; set; }
        public Guid? RecordId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan TotalTime { get; set; }
        public List<string> MissingStations { get; set; }

        public long? Tag { get; set; }

        public SignalTaskIncomplate()
        {
            MissingStations = new List<string>();
        }
    }
}
