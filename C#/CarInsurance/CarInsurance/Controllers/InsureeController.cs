using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();

                int quoteBase = 50;  //  Set base quote to 50 dollars a month
                decimal quote;  //  Define the quote varriable to be a decimal

                int age = Convert.ToInt32(DateTime.Now.Year - insuree.DateOfBirth.Year);  //  Calculate Age from user input and store as an integer
                //  Add an amount to quote based on age
                if (age < 18)
                {
                    quote = quoteBase + 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    quote = quoteBase + 50;
                }
                else
                {
                    quote = quoteBase + 25;
                }

                //  Add an amount to quote if car was made before 2000 or after 2015
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote = quote + 25;
                }

                //  Add an amount to quote if the make of the car is Porsche
                if (insuree.CarMake == "Porsche")
                {
                    quote = quote + 25;
                }

                //  Add an amount to quote if the car is a Porsche 911 Carrera
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    quote = quote + 25;
                }

                //  Add 10 dollars a month for each speeding ticket the insuree has
                int tickets = insuree.SpeedingTickets * 10;
                quote = quote + tickets;

                //  If insuree has had a DUI then add an additional 25% to quote
                if (insuree.DUI)
                {
                    decimal twentyFivePercent = 0.25m;
                    decimal dui = Decimal.Multiply(twentyFivePercent, quote);
                    quote = dui + quote;
                }

                //  Add an additional 50% to quote if for full coverage
                if (insuree.CoverageType)
                {
                    decimal fiftyPercent = 0.50m;
                    decimal full = Decimal.Multiply(fiftyPercent, quote);
                    quote = quote + full;
                }

                insuree.Quote = quote;  //  Set the quote for the user after all considerations
                db.SaveChanges();  //  Save value of the quote to the dB
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public ActionResult Admin()  // Allows access to admin view
        {
            return View(db.Insurees.ToList());
        }
    }
}
