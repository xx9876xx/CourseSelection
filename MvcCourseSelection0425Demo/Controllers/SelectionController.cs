using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCourseSelection0425Demo.Models;

namespace MvcCourseSelection0425Demo.Controllers
{
    public class SelectionController : Controller
    {
        // GET: Selection
        public ActionResult Selection()
        {
            List<Course> courses = new List<Course>
            {
                new Course{ id=1001, courseName="英文", department="共同科目", college="文學院",term=1 , day=1, period="0800-1000", teacher="Peter", limit_up=10},
                new Course{ id=1002, courseName="國文", department="共同科目", college="文學院",term=1 , day=2, period="0800-1000", teacher="Alice", limit_up=10},
                new Course{ id=1003, courseName="微積分", department="共同科目", college="理學院",term=1 , day=3, period="0900-1200", teacher="John", limit_up=10},
                new Course{ id=1004, courseName="數位邏輯", department="電子系", college="工學院",term=1 , day=4, period="0900-1200", teacher="Allen", limit_up=4},
                new Course{ id=1005, courseName="電子電路實習(一)", department="資工系", college="工學院",term=1 , day=5, period="0800-1100", teacher="Freeman", limit_up=3},
                new Course{ id=1006, courseName="計算機概論", department="資工系", college="工學院",term=1 , day=2, period="1400-1600", teacher="Van", limit_up=5},
                new Course{ id=1007, courseName="C++與物件導向", department="資工系", college="工學院",term=1 , day=4, period="1500-1700", teacher="Finkes", limit_up=4}
            };

            return View(courses);
        }
    }
}