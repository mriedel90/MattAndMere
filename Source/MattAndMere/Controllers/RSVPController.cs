using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MattAndMere.Data;
using MattAndMere.Entities;
using MattAndMere.Models;

namespace MattAndMere.Views.Home
{
    public class RSVPController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Reservations
        public ActionResult Index()
        {
            return View();
        }
        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ReservationModel model)
        {
            if (!CustomValidation(model)) return View(model);

            model.DateCreated = DateTime.Now;
            if (!model.WillAttend.HasValue || !model.WillAttend.Value)
            {
                model.Shuttle = false;
                model.MealChoice = MealChoice.None;
            }
            if (!model.Shuttle.HasValue || !model.Shuttle.Value)
                model.Hotel = null;

            var reservation = Mapper.Map<Reservation>(model);
            db.Reservations.Add(reservation);
            db.SaveChanges();
            return RedirectToAction(model.WillAttend.HasValue && model.WillAttend.Value ? "confirm" : "decline");
        }

        private bool CustomValidation(ReservationModel model)
        {
            if (!model.WillAttend.HasValue || !model.WillAttend.Value)
            {
                RemoveModelStateError("Shuttle");
                RemoveModelStateError("MealChoice");
                RemoveModelStateError("Hotel");
            }
            else if (model.MealChoice != MealChoice.Pork && model.MealChoice != MealChoice.Ravioli && model.MealChoice != MealChoice.Salmon)
            {
                ChangeModelStateError("MealChoice", "Please select a valid dinner preference");
            }

            if (!model.Shuttle.HasValue || !model.Shuttle.Value)
                RemoveModelStateError("Hotel");

            if (!string.IsNullOrEmpty(model.Hotel) && model.Hotel != "Holiday" && model.Hotel != "Hampton")
                ChangeModelStateError("Hotel", "Please select a valid hotel option");

            return ModelState.IsValid;
        }

        private void RemoveModelStateError(string property)
        {
            if (!ModelState.ContainsKey(property)) return;
            if (ModelState[property].Errors?.Count > 0)
                ModelState[property].Errors.Clear();
        }

        private void ChangeModelStateError(string property, string newMessage)
        {
            if (!ModelState.ContainsKey(property)) return;
            if (ModelState[property].Errors?.Count > 0)
                ModelState[property].Errors[0] = new ModelError(newMessage);
            else
                ModelState.AddModelError(property, newMessage);
        }

        public ActionResult Confirm()
        {
            return View();
        }
        public ActionResult Decline()
        {
            return View();
        }


        public ActionResult ViewAllReservations()
        {
            var reservations = db.Reservations.Select(Mapper.Map<ReservationModel>).ToList();
            return View(reservations);
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
