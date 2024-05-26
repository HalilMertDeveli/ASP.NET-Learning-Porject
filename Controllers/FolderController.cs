using Microsoft.AspNetCore.Mvc;

namespace RepeatOperationForAspNet.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot"));
            var folders = directoryInfo.GetDirectories();
            return View(folders);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string folderName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            DirectoryInfo directoryInfo2 = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));

            var folders = directoryInfo2.GetDirectories();
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            return View("List", folders);
        }
        public IActionResult Remove(string folderName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete(true);
            }
            return RedirectToAction("List");
        }
    }
}
