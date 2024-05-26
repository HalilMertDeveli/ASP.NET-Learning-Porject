using Microsoft.AspNetCore.Mvc;
using RepeatOperationForAspNet.Models;
using System.Diagnostics;

namespace RepeatOperationForAspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> studentList = StudentContext.studentList;

            return View(studentList);
        }
        public IActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {





            Student lastStudent = null;
            if (StudentContext.studentList.Count > 0)
            {
                lastStudent = StudentContext.studentList.Last();
            }


            student.StudentId = 1;

            if (lastStudent != null)
            {
                student.StudentId = lastStudent.StudentId + 1;
            }

            StudentContext.studentList.Add(student);


            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {

            var willRemoveStudent = StudentContext.studentList.Find(c => c.StudentId == id);

            if (willRemoveStudent != null)
            {
                StudentContext.studentList.Remove(willRemoveStudent);
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Student willUpdateStudent = StudentContext.studentList.FirstOrDefault(studentInstance => studentInstance.StudentId == id);

            return View(willUpdateStudent);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            var willUpdateStudent = StudentContext.studentList.Find(studentInstance => studentInstance.StudentId == student.StudentId);

            willUpdateStudent.StudentName = student.StudentName;
            willUpdateStudent.StudentLastName = student.StudentLastName;
            willUpdateStudent.StudentGrade = student.StudentGrade;


            return RedirectToAction("Index");
        }



    }
}
