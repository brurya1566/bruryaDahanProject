using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BL
{
    public static class UploadForm
    {
        public static UploadStatus uploadFile(FormModel file)
        {
            return DAL.UploadFile.uploadFile(file);

        }
    }
}
