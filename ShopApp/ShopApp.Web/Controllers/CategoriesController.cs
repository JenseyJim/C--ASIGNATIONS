using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;

namespace ShopApp.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesDb categories;

        public CategoriesController(ICategoriesDb categoriesDb)
        {
            this.categories = categoriesDb;
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            var categories = this.categories.GetCategories();

            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var category = this.categories.GetCategories(id);
            return View(category);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesAddModel addModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addModel);
            }

            try
            {
                addModel.creation_date = DateTime.Now;
                addModel.creation_user = 1; 
                this.categories.SaveCategories(addModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
        
                ModelState.AddModelError(string.Empty, "Ocurrió un error al crear la categoría: " + ex.Message);
                return View(addModel);
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var categories = this.categories.GetCategories(id);
            return View(categories);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesUpdateModel updateModel)
        {
            try
            {
                updateModel.modify_date = DateTime.Now;
                updateModel.modify_user = 1;

                this.categories.UpdateCategories(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}