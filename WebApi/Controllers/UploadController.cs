using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Common;
using BL;
using Microsoft.AspNetCore.Http;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/Upload")]
    public class UploadController : ControllerBase
    {

        private readonly ILogger<UploadController> _logger;

        public UploadController(ILogger<UploadController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("uploadFile")]
        public UploadStatus uploadFile(FormModel form)
        {
            return BL.UploadForm.uploadFile(form);
        }
    }
}
