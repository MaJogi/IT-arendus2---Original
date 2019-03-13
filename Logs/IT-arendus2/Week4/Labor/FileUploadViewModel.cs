using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Labor
{
    public class FileUploadViewModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
