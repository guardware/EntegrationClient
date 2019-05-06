using System;
using System.Collections.Generic;

namespace IdenfitGuardware.Client.Models
{
    public class Device  {
        public string Name { get; set; }
        public Guid SerialNumber { get; set; }
        public bool LocationControl { get; set; }
        public List<Guid> Braches { get; set; }

        public Device()
        {
            Braches = new List<Guid>();
        }
    }
}
