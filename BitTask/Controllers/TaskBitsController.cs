using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitTask.Models;

namespace BitTask.Controllers
{
    public class TaskBitsController : Controller
    {
        private TaskBitContext db = new TaskBitContext();

        // GET: TaskBits
        public ActionResult Index()
        {
            return View(db.TaskBit.ToList());
        }

        // GET: TaskBits/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskBit taskBit = db.TaskBit.Find(id);
            if (taskBit == null)
            {
                return HttpNotFound();
            }
            return View(taskBit);
        }

        // GET: TaskBits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskBits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EstimatedTime,ActualTime,ShortTaskDescription,LongTaskDescription,Date")] TaskBit taskBit)
        {
            if (ModelState.IsValid)
            {
                taskBit.ID = Guid.NewGuid();
                db.TaskBit.Add(taskBit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskBit);
        }

        // GET: TaskBits/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskBit taskBit = db.TaskBit.Find(id);
            if (taskBit == null)
            {
                return HttpNotFound();
            }
            return View(taskBit);
        }

        // POST: TaskBits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EstimatedTime,ActualTime,ShortTaskDescription,LongTaskDescription,Date")] TaskBit taskBit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskBit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskBit);
        }

        // GET: TaskBits/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskBit taskBit = db.TaskBit.Find(id);
            if (taskBit == null)
            {
                return HttpNotFound();
            }
            return View(taskBit);
        }

        // POST: TaskBits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            TaskBit taskBit = db.TaskBit.Find(id);
            db.TaskBit.Remove(taskBit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
