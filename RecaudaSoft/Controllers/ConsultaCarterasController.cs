﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecaudaSoft.Models;

namespace RecaudaSoft.Controllers
{
    public class ConsultaCarterasController : Controller
    {
        //
        // GET: /ConsultaCarteras/

        public ActionResult Index()
        {
            using (var db = new CobranzasEntities())
            {
                var listaCarteras = db.Carteras.Include("Acreedor");
                listaCarteras = listaCarteras.Include("Parametro");
                return View(listaCarteras.ToList());
            }
        }

        //
        // GET: /ConsultaCarteras/Details/5

        public ActionResult Details(int id)
        {
            using (var db = new CobranzasEntities())
            {
                var listaCarteras = db.Carteras.Include("Parametro").Include("Acreedor");
                Cartera cartera = listaCarteras.First(a => a.idCartera == id);

                ViewBag.esVencida = new SelectList(db.Parametroes.Where(p => p.tipo == "TIPO_CARTERA"), "idParametro", "valor", cartera.esVencida).ToList();
                ViewBag.idAcreedor = new SelectList(db.Acreedors, "idAcreedor", "nombre", cartera.idAcreedor).ToList();

                return View(cartera);
            }
        }

        //
        // GET: /ConsultaCarteras/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ConsultaCarteras/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /ConsultaCarteras/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ConsultaCarteras/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ConsultaCarteras/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ConsultaCarteras/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
