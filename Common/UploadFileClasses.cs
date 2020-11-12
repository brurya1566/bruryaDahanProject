using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;
using Microsoft.AspNetCore.Http;

namespace Common
{
    public class FormModel
    {
        public string FileName { get; set; }
        public IFormFile FormFile { get; set; }
    }
    public enum UploadStatus
    {
        success=1,badRequest=2,serverError=3
    }
}
