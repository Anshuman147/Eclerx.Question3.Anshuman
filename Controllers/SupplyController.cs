using Eclerx.Question3.Anshuman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eclerx.Question3.Anshuman.Controllers
{
    public class SupplyController : Controller
    {
        private ApplicationDbContext adb = null;
        public SupplyController()
        {
            adb = new ApplicationDbContext();
        }
        // GET: Supply
        public ActionResult Index()
        {
            var supplies = adb.supplier .ToList();
            return View(supplies);//return list of product
        }
        public ActionResult Create()
        {
            var supplies = adb.supplier.ToList();
            ViewBag.Supplies = supplies;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                adb.supplier.Add(supplier);
                adb.SaveChanges();
                return RedirectToAction("Index");
            }

            var supplies = adb.supplier.ToList();
            ViewBag.Supplies = supplies;
            return View();
        }
        public ActionResult Edit(int id)
        {
            var supply = adb.supplier.FirstOrDefault(p => p.SupplierId  == id);
            if (supply != null)
            {
                return View(supply);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                var dataFromDb = adb.supplier .FirstOrDefault(p => p.SupplierId == supplier.SupplierId);
                dataFromDb.ComapanyName = supplier.ComapanyName;
                dataFromDb.ContactName = supplier.ContactName;
                dataFromDb.Address = supplier.Address;
                dataFromDb.City = supplier.City;
                dataFromDb.Pincode = supplier.Pincode;
                dataFromDb.Pincode = supplier.Pincode;
                dataFromDb.MobileNo = supplier.MobileNo;
                dataFromDb.EmailId = supplier.EmailId;
                dataFromDb.ModifiedDate = supplier.ModifiedDate;

                adb.SaveChanges();
                return RedirectToAction("Index");
            }
            var supplies = adb.supplier.ToList();
            ViewBag.Supplies = supplies;
            
            return View(supplies);
        }
    }
}