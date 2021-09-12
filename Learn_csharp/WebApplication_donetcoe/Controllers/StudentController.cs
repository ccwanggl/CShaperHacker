using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_donetcoe.Models;

namespace WebApplication_donetcoe.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student{ID = 1, Name = "student_1"},
                new Student{ID = 2, Name = "student_2"},
                new Student{ID = 3, Name = "student_3"},
                new Student{ID = 4, Name = "student_4"},
                new Student{ID = 5, Name = "student_5"},
                new Student{ID = 6, Name = "student_6"},
                new Student{ID = 7, Name = "student_7"},
                new Student{ID = 8, Name = "student_8"},
                new Student{ID = 9, Name = "student_9"}
            };
            return View(students);
        }
    }
}
