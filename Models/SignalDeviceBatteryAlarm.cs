﻿using System;

namespace IdenfitGuardware.Client.Models
{
    public class SignalDeviceBatteryAlarm
    {
        public Guid Id { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid BranchId { get; set; }

        public Guid DeviceId { get; set; }

        public byte BatteryLevel { get; set; }

        public DateTime Date { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public long? Tag { get; set; }
    }
}
