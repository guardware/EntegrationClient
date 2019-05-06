using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalDeviceStatus
    {
        public Guid DeviceId { get; set; }
        public DateTime Date { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime LastOfflineTimeStamp { get; set; }
        public DateTime LastOnlineTimeStamp { get; set; }
        public float BatteryLevel { get; set; }
        public string Brand { get; set; }
        public bool Charging { get; set; }
        public bool ConnectedMobile { get; set; }
        public bool ConnectedWifi { get; set; }
        public string Imei { get; set; }
        public string Model { get; set; }
        public string OperatorName { get; set; }
        public int RxKB { get; set; }
        public int TxKB { get; set; }
        public string VersionRelease { get; set; }
    }
}
