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
    public class BorrowingController : ControllerBase
    {

        protected readonly IBorrowingService _borrowingService;

        public BorrowingController(IBorrowingService borrowingService)
        {
            _borrowingService = borrowingService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBorrowingBySSN(int SSN)
        {
            var p = await _borrowingService.GetBorrowingBySSN(SSN);
            return Ok(p);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CreateBorrowing([FromBody] Borrowing borrowing)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }

            try
            {
                _borrowingService.CreateBorrowing(borrowing);

                return Ok(borrowing);

            }
            catch (Exception e)
            {
                return NotFound();
            }


        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ReturnBorrowing([FromBody] int borrowingId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }

            try
            {
                _borrowingService.ReturnBorrowing(borrowingId);

                return Ok();

            }
            catch (Exception e)
            {
                return NotFound();
            }


        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult RenewBorrowing([FromBody] int borrowingId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }

            try
            {
                _borrowingService.RenewBorrowing(borrowingId);

                return Ok();

            }
            catch (Exception e)
            {
                return NotFound();
            }


        }

    }
}
