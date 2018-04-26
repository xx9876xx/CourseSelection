using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCourseSelection0425Demo.Models
{
    public class Course
    {
        [Display(Name = "課程代碼")]
        public int id { get; set; }
        [Display(Name = "課程名稱")]
        public string courseName { get; set; }
        [Display(Name = "開課學院")]
        public string college { get; set; }
        [Display(Name = "開課系所")]
        public string department { get; set; }
        [Display(Name = "項次")]
        public int term { get; set; }
        [Display(Name = "星期")]
        public int day { get; set; }
        [Display(Name = "時段")]
        public string period { get; set; }
        [Display(Name = "老師")]
        public string teacher { get; set; }
        [Display(Name = "人數上限")]
        public int limit_up { get; set; }

    }
}