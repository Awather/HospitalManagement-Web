using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalManagement_Web.DBAccess;
using HospitalManagement_Web.Models;

namespace HospitalManagement_Web.Controllers
{
    public class RegistrationController : Controller
    {
        private HospitalContext db = new HospitalContext();

        //GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registration
        //public ActionResult Index()
        //{
        //    var registrations = db.Registrations.Include(r => r.Department).Include(r => r.Patient);
        //    return View(registrations.ToList());
        //}

        //// GET: Registration/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Registration registration = db.Registrations.Find(id);
        //    if (registration == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(registration);
        //}

        //// GET: Registration/Create
        //public ActionResult Create()
        //{
        //    ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title");
        //    ViewBag.PatientID = new SelectList(db.Patients, "ID", "LastName");
        //    return View();
        //}

        //// POST: Registration/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "RegistrationID,DepartmentID,PatientID")] Registration registration)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Registrations.Add(registration);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title", registration.DepartmentID);
        //    ViewBag.PatientID = new SelectList(db.Patients, "ID", "LastName", registration.PatientID);
        //    return View(registration);
        //}

        //// GET: Registration/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Registration registration = db.Registrations.Find(id);
        //    if (registration == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title", registration.DepartmentID);
        //    ViewBag.PatientID = new SelectList(db.Patients, "ID", "LastName", registration.PatientID);
        //    return View(registration);
        //}

        //// POST: Registration/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "RegistrationID,DepartmentID,PatientID")] Registration registration)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(registration).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title", registration.DepartmentID);
        //    ViewBag.PatientID = new SelectList(db.Patients, "ID", "LastName", registration.PatientID);
        //    return View(registration);
        //}

        //// GET: Registration/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Registration registration = db.Registrations.Find(id);
        //    if (registration == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(registration);
        //}

        //// POST: Registration/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Registration registration = db.Registrations.Find(id);
        //    db.Registrations.Remove(registration);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
