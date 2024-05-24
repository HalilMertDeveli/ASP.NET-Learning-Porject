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
    }
}
