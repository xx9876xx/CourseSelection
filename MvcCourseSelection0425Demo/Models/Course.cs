using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCourseSelection0425Demo.Models
{
    public class Course
    {
        public int id { get; set; }
        public string courseName { get; set; }
        public string college { get; set; }
        public string department { get; set; }
        public int term { get; set; }
        public int day { get; set; }
        public string period { get; set; }
        public string teacher { get; set; }
        public int limit_up { get; set; }

    }
}