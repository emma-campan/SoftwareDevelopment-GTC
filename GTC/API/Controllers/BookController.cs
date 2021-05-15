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
    public class BookController : ControllerBase
    {

        protected readonly IBookService _BookService;

        public BookController(IBookService BookService)
        {
            _BookService = BookService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBookByAuthor(string FirstName, string LastName)
        {
            var p = await _BookService.GetBookByAuthor(FirstName, LastName);
            return Ok(p);
            
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBookByName(string name)
        {
            var p = await _BookService.GetBookByName(name);
            return Ok(p);

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBookIsRare()
        {
            var p = await _BookService.GetBookIsRare();
            return Ok(p);

        }
    }
}
