using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_VentaMoviles.Models.ViewModel;
using Servicios.Servicios;
using Servicos.Servicios;


namespace MVC_VentaMoviles.Controllers
{
    public class DispositivosController : Controller
    {
        // GET: Dispositivos
        public ActionResult Index()
        {
            var _servicio = DependencyResolver.Current.
                GetService<IServicios<DispositivosViewModel>>();

            return View(_servicio.Get());
        }

        // GET: Dispositivos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dispositivos/Create
        public ActionResult Create()
        {
            return View(new DispositivosViewModel());
        }

        // POST: Dispositivos/Create
        [HttpPost]
        public ActionResult Create(DispositivosViewModel model)
        {
            var _servicio = DependencyResolver.Current.
                   GetService<IServicios<DispositivosViewModel>>();

            if (ModelState.IsValid)
            {
                _servicio.Add(model);
                return RedirectToAction("index", "Dispositivos");
            }
            return View(model);
        }

        // GET: Dispositivos/Edit/5
        public ActionResult Edit(int id)
        {
            var _servicio = DependencyResolver.Current.
                   GetService<IServicios<DispositivosViewModel>>();

            return View(_servicio.Get(id));
        }

        // POST: Dispositivos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DispositivosViewModel model)
        {
            try
            {
                var _servicio = DependencyResolver.Current.
                   GetService<IServicios<DispositivosViewModel>>();

                _servicio.Update(id, model);

                return RedirectToAction("index", "Dispositivos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dispositivos/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    var _servicio = DependencyResolver.Current.
        //           GetService<IServicios<DispositivosViewModel>>();
            
        //    return View(_servicio.Get(id));
           
        //}

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var _servicio = DependencyResolver.Current.
                   GetService<IServicios<DispositivosViewModel>>();

                _servicio.Delete(id);

                return RedirectToAction("index", "Dispositivos");
            }
            catch
            {
                return View();
            }
        }
    }
}
