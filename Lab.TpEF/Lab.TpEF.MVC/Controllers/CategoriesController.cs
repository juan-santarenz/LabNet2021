using Lab.TpEF.Entities;
using Lab.TpEF.Logic;
using Lab.TpEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.TpEF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            List<Categories>  categories = logic.GetAll();

            List<CategoriesView> categoriesViews = categories.Select(s => new CategoriesView
            {
                Id = s.CategoryID,
                Name = s.CategoryName,
                Description = s.Description,
            }).ToList();
            
            return View(categoriesViews);
        }

        public ActionResult Insert()
        {
            ViewBag.Message = "Insert";
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryName = categoriesView.Name,
                    Description = categoriesView.Description
                };
                
                logic.Add(categoryEntity);

                return RedirectToAction("index");
            }
            catch (Exception)
            {

                return RedirectToAction("index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);

            return RedirectToAction("index");
        }

        public ActionResult Update(int id)
        {
            try
            {
                Categories categorieUpdate = logic.GetOne(id);
                CategoriesView categoriesView = new CategoriesView
                {
                    Id = categorieUpdate.CategoryID,
                    Name = categorieUpdate.CategoryName,
                    Description = categorieUpdate.Description
                };

                ViewBag.Message = "Update";
                return View("insert", categoriesView);
            }
            catch (Exception)
            {

                return RedirectToAction("index", "Error");
            }
        }
        [HttpPost]
        public ActionResult Update(CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryID = categoriesView.Id,
                    CategoryName = categoriesView.Name,
                    Description = categoriesView.Description
                };
                logic.Update(categoryEntity);
                return RedirectToAction("index");
            }
            catch (Exception)
            {

                return RedirectToAction("index", "Error");
            }
        }
    }
}