using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            List<student> stlist = new List<student>()
            {
                new student{SId=101, SName="Peeyush", SMarks=95},
                new student{SId=102, SName="Arsh", SMarks=96},
                new student{SId=103, SName="Nikhil", SMarks=97},
            };
            return View(stlist);
        }
    }
}