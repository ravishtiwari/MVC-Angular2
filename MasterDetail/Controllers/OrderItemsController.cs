using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MasterDetail.DataLayer;
using MasterDetail.Models;
using PagedList;

namespace MasterDetail.Controllers
{
    public class OrderItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrderItems
        public ActionResult Index(int OrderID,int? page)
        {
            ViewBag.OrderID = OrderID;
            var orderItems = db.OrderItems.Include(oi => oi.Order).Include(oi => oi.Product).OrderByDescending(oi => oi.OrderItemID);
            int pageSize = 3;
            int pageNumber = page ?? 1;
            return PartialView(orderItems.Where(oi => oi.OrderID == OrderID).ToPagedList(pageNumber,pageSize));
        }

        // GET: OrderItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItem orderItem = db.OrderItems.Find(id);
            if (orderItem == null)
            {
                return HttpNotFound();
            }
            return View(orderItem);
        }

        // GET: OrderItems/Create
        public ActionResult Create(int OrderID)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderID = OrderID;
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "ProductName");
            return PartialView(orderItem);
        }

        // POST: OrderItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderItemID,OrderID,ProductID,Amount")] OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                db.OrderItems.Add(orderItem);
                db.SaveChanges();
                return Json(new {success=true});
            }

            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "ProductName", orderItem.ProductID);
            return PartialView(orderItem);
        }

        // GET: OrderItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItem orderItem = db.OrderItems.Find(id);
            if (orderItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "ProductName", orderItem.ProductID);
            return PartialView(orderItem);
        }

        // POST: OrderItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderItemID,OrderID,ProductID,Amount")] OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderItem).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true });
            }
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "ProductName", orderItem.ProductID);
            return PartialView(orderItem);
        }

        // GET: OrderItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItem orderItem = db.OrderItems.Find(id);
            if (orderItem == null)
            {
                return HttpNotFound();
            }
            return View(orderItem);
        }

[HttpPost]
        public ActionResult Delete(int id)
        {

            try
            {
                OrderItem orderItem = db.OrderItems.Find(id);
                db.OrderItems.Remove(orderItem);
                db.SaveChanges();
                return Json(new { success = true, Message = "" });
            }
            catch (Exception exp)
            {
                return Json(new { success = false, ErrorMessage = exp.Message });
            }

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
