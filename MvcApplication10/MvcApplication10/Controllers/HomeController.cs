using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication10.Commands;
using MvcApplication10.ViewModels.Home;

namespace MvcApplication10.Controllers
{
    public class HomeController : Controller
    {
        // とりあえずテストで内部で保持するための変数
        private static String _name { get; set; }
        private static String _description { get; set; }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(new IndexViewModel { Name = _name, Description = _description });
        }

        #region Edit
        public ActionResult Edit()
        {
            return View(new EditInputModel { Name = _name, Description = _description });
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditCommit(EditInputModel inputModel)
        {
            if (ModelState.IsValid)
            {
                new HomeEditValidateCommand().Execute(inputModel, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return View("Edit", inputModel);
            }

            _name = inputModel.Name;
            _description = inputModel.Description;

            return RedirectToAction("Index");
        }
        #endregion
    }
}
