using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TODOList.Models;

namespace TODOList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View(MvcApplication.ViewModel);
        }

        [HttpPost]
        public ActionResult _AddTask(IndexViewModel model)
        {           
            MvcApplication.ViewModel.TodoList.Add(model.Task);
            return RedirectToAction("Index"); 
        }


        [HttpPost]
        public ActionResult _EditTask(IndexViewModel model)
        {
            //Commit1
            int index = -1;
            index = MvcApplication.ViewModel.TodoList.FindIndex(t => t.ID == model.Task.ID);
            if (index == -1)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          
            MvcApplication.ViewModel.TodoList[index].IsDone = model.Task.IsDone;
            MvcApplication.ViewModel.TodoList[index].Description = model.Task.Description;
           
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult _DeleteTask(IndexViewModel model)
        {
            var item = MvcApplication.ViewModel.TodoList.Where(t=> t.ID == model.Task.ID).FirstOrDefault();
            if (item == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MvcApplication.ViewModel.TodoList.Remove(item);
            return RedirectToAction("Index");
        }

    }
}