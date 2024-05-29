using Microsoft.AspNetCore.Mvc;
using middleware_edit.Models;

namespace middleware_edit.ViewComponents
{
    public class News:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var list =  NewsContext.List;
            return View(list);
        }
    }
}
