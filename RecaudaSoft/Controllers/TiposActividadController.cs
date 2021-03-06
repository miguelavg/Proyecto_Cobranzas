﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecaudaSoft.Models;

namespace RecaudaSoft.Controllers
{
    public class TiposActividadController : Controller
    {
        //
        // GET: /TiposActividad/

        public ActionResult Index()
        {
            using (var db = new CobranzasEntities())
            {
                return View(db.TipoActividads.ToList());
            }
        }

        //
        // GET: /TiposActividad/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TiposActividad/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /TiposActividad/Create

        [HttpPost]
        public ActionResult Create(TipoActividad tipoActividad)
        {
            try
            {
                using (var db = new CobranzasEntities())
                {
                    db.TipoActividads.Add(tipoActividad);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /TiposActividad/Edit/5
 
        public ActionResult Edit(int id)
        {
            using (var db = new CobranzasEntities())
            {
                return View(db.TipoActividads.Find(id));
            }
        }

        //
        // POST: /TiposActividad/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, TipoActividad tipoActividad)
            {
            try
            {
                using (var db = new CobranzasEntities())
                {
                    db.Entry(tipoActividad).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TiposActividad/Delete/5
 
        public ActionResult Delete(int id)
        {
            using (var db = new CobranzasEntities())
            {
                return View(db.TipoActividads.Find(id));
            }
        }

        //
        // POST: /TiposActividad/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, TipoActividad tipoActvidad)
        {
         try
            {
                using (var db = new CobranzasEntities())
                {
                    db.Entry(tipoActvidad).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
