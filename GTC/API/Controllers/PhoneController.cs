using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PhoneController : ControllerBase
    {

        protected readonly IPhoneService _phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllPhones()
        {
            var p = await _phoneService.GetAllPhones();
            return Ok(p);
            
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CreatePhone([FromBody] Phone phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }

            try
            {               
                _phoneService.CreatePhone(phone);

                return Ok(phone);                
               
            }
            catch(Exception e)
            {
                return BadRequest();
            }
           
            
        }
    }
}
