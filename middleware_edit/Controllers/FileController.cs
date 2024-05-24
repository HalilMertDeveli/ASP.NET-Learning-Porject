using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace middleware_edit.Controllers
{
    public class FileController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files"));

            var files = directoryInfo.GetFiles();
            return View(files);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string fileName)
        {
            FileInfo fileInfo = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files",fileName));

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            return RedirectToAction("List");
        }
    }
}
