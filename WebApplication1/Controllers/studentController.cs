using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> stlist = new List<Student>()
            {
                new Student{SId=101, SName="Peeyush", SMarks=95},
                new Student{SId=102, SName="Arsh", SMarks=96},
                new Student{SId=103, SName="Nikhil", SMarks=97},
            };
            return View(stlist);
        }
    }
}