using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Lab.TpEf.API.Models;
using Lab.TpEF.Data;
using Lab.TpEF.Entities;
using Lab.TpEF.Logic;

namespace Lab.TpEf.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers:"*", methods:"*")]
    public class CategoriesController : ApiController
    {
        private CategoriesLogic logic = new CategoriesLogic();

        // GET: api/Categories
        public List<CategoriesView> GetCategories()
        {
            List<Categories> categories = logic.GetAll();

            List<CategoriesView> categoriesViews = categories.Select(s => new CategoriesView
            {
                CategoryID = s.CategoryID,
                CategoryName = s.CategoryName,
                Description = s.Description,
            }).ToList();

            return categoriesViews;
        }

        // GET: api/Categories/5
        [ResponseType(typeof(CategoriesView))]
        public IHttpActionResult GetCategories(int id)
        {
            Categories categories = logic.GetOne(id);
            if (categories == null)
            {
                return NotFound();
            }

            try
            {
                
                CategoriesView categoriesView = new CategoriesView
                {
                    CategoryID = categories.CategoryID,
                    CategoryName = categories.CategoryName,
                    Description = categories.Description
                };

                return Ok(categoriesView);
            }
            catch (Exception)
            {

                return InternalServerError();
            }
        }

        // PUT: api/Categories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategories(int id, CategoriesView categories)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categories.CategoryID)
            {
                return BadRequest();
            }
            try
            {
                Categories categoriesView = new Categories
                {
                    CategoryID = categories.CategoryID,
                    CategoryName = categories.CategoryName,
                    Description = categories.Description
                };
                logic.Update(categoriesView);

                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception)
            {

                return InternalServerError();
            }
            
        }

        // POST: api/Categories
        [ResponseType(typeof(CategoriesView))]
        public IHttpActionResult PostCategories(CategoriesView categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryID = categories.CategoryID,
                    CategoryName = categories.CategoryName,
                    Description = categories.Description
                };
                logic.Add(categoryEntity);

                return CreatedAtRoute("DefaultApi", new { id = categories.CategoryID }, categories);
            }
            catch (Exception)
            {

                return InternalServerError();
            }
            
        }

        // DELETE: api/Categories/5
        [ResponseType(typeof(Categories))]
        public IHttpActionResult DeleteCategories(int id)
        {
            Categories categories = logic.GetOne(id);
            if (categories == null)
            {
                return NotFound();
            }
            try
            {
                logic.Delete(id);

                return Ok(categories);
            }
            catch (Exception)
            {

                return InternalServerError();
            }
        }

    }
}