using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsinTransientAndApartment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Type = AsinTransientAndApartment.Models.Type;

namespace AsinTransientAndApartment.Controllers
{
    public class GuestController : Controller
    {
        private readonly ReservationDBContext _DB;
        public GuestController(ReservationDBContext DB)
        {
            _DB = DB;
        }
        public IQueryable<Reserve> reserves => _DB.Reserve;
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult GetTypes()
        //{
        //    var createTest = new Type
        //    {
        //        Name = "test"
        //    };
        //    _DB.types.Add(createTest);
        //    _DB.SaveChanges();
        //    var model = _DB.types.Where(x => x.Name == "test").ToList();
        //    return Json(model);
        //}
        public IActionResult AddGuest(string firstName, string lastName, string contactNumber, int numberOfGuest, int numberOfNight, Reserve createTest)
        {
            var test = new Guest
            {
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contactNumber,
                NumberOfGuest = numberOfGuest,
                NumberOfNight = numberOfNight
            };
            _DB.Reserve.Add(createTest);
            _DB.SaveChanges();
            var model = _DB.Reserve.Where(x => x.FirstName == firstName).ToList();
            return Json(model);
        }

        public IActionResult AddGuestById(int id)
        {
            Guest model = _DB.guests.Where(x => x.Id == id).FirstOrDefault();
            _DB.guests.Attach(model);
            _DB.SaveChanges();
            return Json(model);

        }
        //public IActionResult DeleteType()
        //{
        //    Type model = _DB.types.Where(x => x.Name == "test").FirstOrDefault();
        //    _DB.types.Remove(model);
        //    _DB.SaveChanges();
        //    return Json(model);

        //}
        //public IActionResult DeleteTypeById(int id)
        //{
        //    Type model = _DB.types.Where(x => x.Id == id).FirstOrDefault();
        //    _DB.types.Remove(model);
        //    _DB.SaveChanges();
        //    return Json(model);

        //}
        //public IActionResult LoadTypes()
        //{
        //    List<Type> typeList = _DB.types.Where(x => x.Name != null).ToList();
        //    return Json(typeList);
        //}
        //public IActionResult EditTypeById(string name, int id)
        //{
        //    Type model = _DB.types.Where(x => x.Id == id).FirstOrDefault();
        //    model.Name = name;
        //    _DB.types.Update(model);
        //    _DB.SaveChanges();
        //    return Json(model);

        //}
    }
}