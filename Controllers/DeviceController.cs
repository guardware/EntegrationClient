using System;
using IdenfitGuardware.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdenfitGuardware.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        [HttpPost]
        public ClientResult Post(Guid id, [FromBody] Device device)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Device Save Signal ({id})"
            };
        }
    
        [HttpPut]
        public ClientResult Put(Guid id, [FromBody] Device device)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Device Update Signal ({id})"
            };
        }

        [HttpDelete]
        public ClientResult Delete(Guid id)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Device Delete Signal ({id})"
            };
        }
    }
}
