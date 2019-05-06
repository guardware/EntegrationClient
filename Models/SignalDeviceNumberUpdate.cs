using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalDeviceNumberUpdate
    {
        public Guid DeviceId { get; set; }

        public long PhoneNumber { get; set; }
    }
}
