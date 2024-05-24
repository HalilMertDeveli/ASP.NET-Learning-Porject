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
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewStudent()
        {
            string formStudentFirstName = HttpContext.Request.Form["studentName"].ToString();
            string formStudentLastName = HttpContext.Request.Form["studentLastName"].ToString();
            int formStudentGrade = int.Parse(HttpContext.Request.Form["studentGrade"].ToString());

            Student lastStudent = StudentContext.studentList.Last();

            int lastStudentId = lastStudent.StudentId +1;



            StudentContext.studentList.Add(new Student()
            {
                StudentId = lastStudentId,
                StudentName = formStudentFirstName,
                StudentLastName = formStudentLastName,
                StudentGrade = formStudentGrade,

            });
            

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remove(int StudentId)
        {

            var willRemoveStudent = StudentContext.studentList.Find(studentInstance => studentInstance.StudentId == StudentId);
            
            if (willRemoveStudent != null)
            {
                StudentContext.studentList.Remove(willRemoveStudent);
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public  IActionResult Update(int studentId)
        {
            Student willUpdateStudent = StudentContext.studentList.FirstOrDefault(studentInstance => studentInstance.StudentId == studentId);

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
