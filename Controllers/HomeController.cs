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
        public IActionResult CreateNewStudent(Student student)
        {


            //string formStudentFirstName = HttpContext.Request.Form["studentName"].ToString();
            //string formStudentLastName = HttpContext.Request.Form["studentLastName"].ToString();
            //int formStudentGrade = int.Parse(HttpContext.Request.Form["studentGrade"].ToString());


            Student lastStudent = null;
            if (StudentContext.studentList.Count>0)
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
        public  IActionResult Update(int id)
        {
            Student willUpdateStudent = StudentContext.studentList.FirstOrDefault(studentInstance => studentInstance.StudentId == id);

            return View(willUpdateStudent);
        }
        [HttpPost]
        public IActionResult Update()
        {
            var id = int.Parse(HttpContext.Request.Form["studentId"].ToString());
            var willUpdateStudent = StudentContext.studentList.Find(studentInstance => studentInstance.StudentId == id);

            willUpdateStudent.StudentName = HttpContext.Request.Form["studentName"].ToString();
            willUpdateStudent.StudentLastName = HttpContext.Request.Form["studentLastName"].ToString();
            willUpdateStudent.StudentGrade = int.Parse(HttpContext.Request.Form["studentGrade"].ToString());


            return RedirectToAction("Index");
        }



    }
}
