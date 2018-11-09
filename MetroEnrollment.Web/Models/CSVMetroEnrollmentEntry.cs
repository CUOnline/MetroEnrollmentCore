using SimpleCsvParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroEnrollment.Web.Models
{
    public class CSVMetroEnrollmentEntry
    {
        [CsvProperty("first name")]
        public string FirstName { get; set; }
        [CsvProperty("last name")]
        public string LastName { get; set; }
        [CsvProperty("email")]
        public string Email { get; set; }
        [CsvProperty("id")]
        public int Id { get; set; }
        [CsvProperty("course code")]
        public string CourseCode { get; set; }
        [CsvProperty("course number")]
        public int CourseNumber { get; set; }
        [CsvProperty("section number")]
        public string SectionNumber { get; set; }
    }

}
