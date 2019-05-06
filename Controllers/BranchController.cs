using System;
using IdenfitGuardware.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdenfitGuardware.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        [HttpPost]
        public ClientResult Post(Guid id, [FromBody] Branch branch)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Branch Save Signal ({id})"
            };
        }
    
        [HttpPut]
        public ClientResult Put(Guid id, [FromBody] Branch branch)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Branch Update Signal ({id})"
            };
        }

        [HttpDelete]
        public ClientResult Delete(Guid id)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Branch Delete Signal ({id})"
            };
        }
    }
}
