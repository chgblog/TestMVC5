using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class CeShiController : Controller
    {
        private CeShiDBContext db = new CeShiDBContext();

        // GET: /CeShi/
        public ActionResult Index()
        {
            return View(db.CeShis.ToList());
        }

        // GET: /CeShi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CeShi ceshi = db.CeShis.Find(id);
            if (ceshi == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(ceshi);
        }

        // GET: /CeShi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /CeShi/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,NianLing,XingMing")] CeShi ceshi)
        {
            if (ModelState.IsValid)
            {
                db.CeShis.Add(ceshi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ceshi);
        }

        // GET: /CeShi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CeShi ceshi = db.CeShis.Find(id);
            if (ceshi == null)
            {
                return HttpNotFound();
            }
            return View(ceshi);
        }

        // POST: /CeShi/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,NianLing,XingMing")] CeShi ceshi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ceshi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ceshi);
        }

        // GET: /CeShi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CeShi ceshi = db.CeShis.Find(id);
            if (ceshi == null)
            {
                return HttpNotFound();
            }
            return View(ceshi);
        }

        // POST: /CeShi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CeShi ceshi = db.CeShis.Find(id);
            db.CeShis.Remove(ceshi);
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
