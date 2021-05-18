
﻿using System;
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
    public class MemberController : ControllerBase
    {

        protected readonly IMemberService _MemberService;

        public MemberController(IMemberService MemberService)
        {
            _MemberService = MemberService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMembersByName(string FirstName, string LastName)
        {
            var p = await _MemberService.GetMembersByName(FirstName, LastName);
            return Ok(p);

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMembersWithActiveBorrowing()
        {
            var p = await _MemberService.GetMembersWithActiveBorrowing();
            return Ok(p);

        }
    }
}