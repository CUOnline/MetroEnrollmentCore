using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEnrollment.Web.Models
{
    public class HomeViewModel
    {
        public string Term { get; set; }
        public IFormFile File { get; set; }
    }
}
