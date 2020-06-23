using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNetDemo.Models;

namespace dotNetDemo.Controllers
{
    public class DeviceInfoController : Controller
    {
        // GET: DeviceInfo/Index
        public ActionResult Index()
        {
            using (DB_dotNetDemo db = new DB_dotNetDemo())
            {
                return View(db.DeviceInfo.ToList());
            }
        }

        // GET: DeviceInfo/Details/5
        public ActionResult Details(int id)
        {
            using (DB_dotNetDemo db = new DB_dotNetDemo())
            {
                return View(db.DeviceInfo.Where(x => x.DeivceId == id).FirstOrDefault());
            }
        }

        // GET: DeviceInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceInfo/Create
        [HttpPost]
        public ActionResult Create(DeviceInfo device)
        {
            try
            {
                // TODO: Add insert logic here
                using (DB_dotNetDemo db = new DB_dotNetDemo())
                {
                    db.DeviceInfo.Add(device);
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DeviceInfo/Edit/5
        public ActionResult Edit(int id)
        {
            using (DB_dotNetDemo db = new DB_dotNetDemo())
            {
                return View(db.DeviceInfo.Where(x => x.DeivceId == id).FirstOrDefault());
            }
        }

        // POST: DeviceInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DeviceInfo device)
        {
            try
            {
                // TODO: Add update logic here
                using (DB_dotNetDemo db = new DB_dotNetDemo())
                {
                    db.Entry(device).State = EntityState.Modified;
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DeviceInfo/Delete/5
        public ActionResult Delete(int id)
        {
            using (DB_dotNetDemo db = new DB_dotNetDemo())
            {
                return View(db.DeviceInfo.Where(x => x.DeivceId == id).FirstOrDefault());
            }
        }

        // POST: DeviceInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, DeviceInfo device)
        {
            try
            {
                // TODO: Add delete logic here
                using (DB_dotNetDemo db = new DB_dotNetDemo())
                {
                    device = db.DeviceInfo.Where(x => x.DeivceId == id).FirstOrDefault();
                    db.DeviceInfo.Remove(device);
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Search(DeviceInfo device)
        {
            using (DB_dotNetDemo db = new DB_dotNetDemo())
            {
                var deviceId = device.DeivceId;
                //db.DeviceInfo.Where(x => x.DeivceId == device.DeivceId).FirstOrDefault();
                return RedirectToAction("Details", new {id = deviceId});
            }
        }
    }
}
