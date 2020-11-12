using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Common;
using BL;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/accountmovements")]
    public class AccountMovementsController : ControllerBase
    {

        private readonly ILogger<AccountMovementsController> _logger;

        public AccountMovementsController(ILogger<AccountMovementsController> logger)
        {
            _logger = logger;
        }

        [Route("GetAccountMovement"), HttpGet]
        public List<AccountMovementsResponse> GetAccountMovement(int skip)
        {
            return BL.AccountMovements.getAccountMovements(skip);
        }
        [Route("GetAccountMovementByPkReferenceCode"), HttpGet]
        public AccountMovementsResponse GetAccountMovementByPkReferenceCode(int pkReferenceCode)
        {
            return BL.AccountMovements.GetAccountMovementByPkReferenceCode(pkReferenceCode);
        }
        [Route("GetBranchList"), HttpGet]
        public List<branch> GetBranchList()
        {
            return BL.AccountMovements.GetBranchList();
        }        
        [Route("GetCityList"), HttpGet]
        public List<city> GetCityList()
        {
            return BL.AccountMovements.GetCityList();
        }
        [HttpGet]
        public List<AccountMovementsResponse> Get(int skip)
        {
            return BL.AccountMovements.getAccountMovements(skip);
        }
        [HttpPost]
        [Route("uploadFile")]
        public UploadStatus uploadFile(FormModel form)
        {
            return BL.UploadForm.uploadFile(form);
        }
    }
}
