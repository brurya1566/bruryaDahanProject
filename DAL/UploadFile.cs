using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Common;

namespace DAL
{
    public static class UploadFile
    {
        public static UploadStatus uploadFile(FormModel file)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.FormFile.CopyTo(stream);
                }
                return UploadStatus.success;
            }
            catch
            {
                return UploadStatus.serverError;
            }

        }
    }
}
