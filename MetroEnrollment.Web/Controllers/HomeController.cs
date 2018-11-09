using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MetroEnrollment.Web.Models;
using SimpleCsvParser;
using System.IO;

namespace MetroEnrollment.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ParseCsv(HomeViewModel model)
        {
            string fileContents;

            using (var reader = new StreamReader(model.File.OpenReadStream()))
            {
                fileContents = await reader.ReadToEndAsync();
            }

            var list = CsvParser.Parse<CSVMetroEnrollmentEntry>(fileContents, new CsvStreamOptions() { RemoveEmptyEntries = true });

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
