using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferLogsController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferLogsController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        // GET: api/TransferLogs
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return Ok(_transferService.GetTranferLogs());
        }
    }
}
