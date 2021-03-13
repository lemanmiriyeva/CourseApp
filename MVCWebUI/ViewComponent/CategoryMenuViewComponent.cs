using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.DataAccess;

namespace MVCWebUI.ViewComponent
{
    public class CategoryMenuViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString()=="Index")
            
                ViewBag.SelectedCategory = RouteData?.Values["id"];
                return View(CategoryRepository.Categories());
            
            
        }
    }
}
