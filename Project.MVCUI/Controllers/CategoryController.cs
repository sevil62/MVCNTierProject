using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository _crep;
        public CategoryController()
        {
            _crep = new CategoryRepository();
        }
        // GET: Category
        public ActionResult CategoryList()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _crep.GetActives()
            };

            return View(cvm);
        }
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            _crep.Add(category);
            return RedirectToAction("CategoryList");
        }

        public ActionResult UpdateCategory(int id)
        {
            return View();
        }


        [HttpPost]

        public ActionResult UpdateCategory(Category category) 
        {
            _crep.Update(category);

            return RedirectToAction("CategoryList");
        }

        public ActionResult DeleteCategory(int id)
        {
            _crep.Delete(_crep.Find(id));
            return RedirectToAction("CategoryList");
        }

    }
}