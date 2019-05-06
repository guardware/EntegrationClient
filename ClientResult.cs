using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdenfitGuardware.Client
{
    public class ClientResult
    {
        public bool State { get; set; }
        public long? Tag { get; set; }
        public string Message { get; set; }
    }
}
