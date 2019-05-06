using System;
using IdenfitGuardware.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdenfitGuardware.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public ClientResult Post(Guid id, [FromBody] Customer customer)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Customer Save Signal ({id})"
            };
        }
    
        [HttpPut]
        public ClientResult Put(Guid id, [FromBody] Customer customer)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Customer Update Signal ({id})"
            };
        }

        [HttpDelete]
        public ClientResult Delete(Guid id)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Customer Delete Signal ({id})"
            };
        }
    }
}
