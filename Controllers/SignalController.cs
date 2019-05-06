using IdenfitGuardware.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdenfitGuardware.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignalController : ControllerBase
    {
        [HttpPost("TaskStart")]
        public ClientResult Post([FromBody] SignalTaskStart signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskStart"
            };
        }
        [HttpPost("TaskFnish")]
        public ClientResult Post([FromBody] SignalTaskFnish signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskFnish"
            };
        }
        [HttpPost("TaskRead")]
        public ClientResult Post([FromBody] SignalTaskRead signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskRead"
            };
        }
        [HttpPost("TaskReminder")]
        public ClientResult Post([FromBody] SignalTaskReminder signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskReminder"
            };
        }
        [HttpPost("TaskNotRead")]
        public ClientResult Post([FromBody] SignalTaskNotRead signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskNotRead"
            };
        }
        [HttpPost("TaskSkipped")]
        public ClientResult Post([FromBody] SignalTaskSkipped signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskSkipped"
            };
        }
        [HttpPost("TaskStationTimeViolation")]
        public ClientResult Post([FromBody] SignalTaskStationViolation signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskStationViolation"
            };
        }
        [HttpPost("DeviceSession")]
        public ClientResult Post([FromBody] SignalDeviceSession signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalDeviceSession"
            };
        }
        [HttpPost("DeviceOff")]
        public ClientResult Post([FromBody] SignalDeviceOff signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalDeviceOff"
            };
        }
        [HttpPost("DeviceStatus")]
        public ClientResult Post([FromBody] SignalDeviceStatus signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalDeviceStatus"
            };
        }
        [HttpPost("EmergencyCall")]
        public ClientResult Post([FromBody] SignalEmergencyCall signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalEmergencyCall"
            };
        }
        [HttpPost("EmergencySms")]
        public ClientResult Post([FromBody] SignalEmergencySms signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalEmergencySms"
            };
        }
        [HttpPost("Event")]
        public ClientResult Post([FromBody] SignalEvent signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalEvent"
            };
        }
        [HttpPost("JudicalEvent")]
        public ClientResult Post([FromBody] SignalJudicialEvent signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalJudicialEvent"
            };
        }
        [HttpPost("Mandown")]
        public ClientResult Post([FromBody] SignalMandown signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal Mandown"
            };
        }
        [HttpPost("OutsideLocation")]
        public ClientResult Post([FromBody] SignalOutsideLocation signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalOutsideLocation"
            };
        }
        [HttpPost("Sos")]
        public ClientResult Post([FromBody] SignalSos signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalSos"
            };
        }
        [HttpPost("TaskComplate")]
        public ClientResult Post([FromBody] SignalTaskComplate signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskComplate"
            };
        }
        [HttpPost("TaskInComplate")]
        public ClientResult Post([FromBody] SignalTaskIncomplate signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskIncomplate"
            };
        }
        [HttpPost("TaskNotVisited")]
        public ClientResult Post([FromBody] SignalTaskNotVisited signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal SignalTaskNotVisited"
            };
        }
    }
}
