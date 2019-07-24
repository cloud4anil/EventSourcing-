using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Transfer.Application.Interface;
using Transfer.Domain.Model;

namespace Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {

        private readonly IAccountTransferService _accountTransferService;

        public TransferController(IAccountTransferService accountTransferService)
        {
            _accountTransferService = accountTransferService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_accountTransferService.GetTransferLog());
        }

       
    }
}
