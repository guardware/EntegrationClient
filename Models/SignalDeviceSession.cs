using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalDeviceSession
    {
        public Guid DeviceId { get; set; }
        public string Employee { get; set; }
        public DateTime Date { get; set; }
        public string SessionEventType { get; set; }
    }
}


