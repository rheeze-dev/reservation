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
    public class TypeController : Controller
    {
        private readonly ReservationDBContext _DB;
        public TypeController(ReservationDBContext DB)
        {
            _DB = DB;
        }
        public IQueryable<Type> types => _DB.types;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetTypes()
        {
            var createTest = new Type
            {
                Name = "test"
            };
            _DB.types.Add(createTest);
            _DB.SaveChanges();
            var model = _DB.types.Where(x => x.Name == "test").ToList();
            return Json(model);
        }
        public IActionResult InsertType(string name)
        {
            var createTest = new Type
            {
                Name = name
            };
            _DB.types.Add(createTest);
            _DB.SaveChanges();
            var model = _DB.types.Where(x => x.Name == name).ToList();
            return Json(model);
        }
        public IActionResult DeleteType()
        {
            Type model = _DB.types.Where(x => x.Name == "test").FirstOrDefault();
            _DB.types.Remove(model);
            _DB.SaveChanges();
            return Json(model);

        }
        public IActionResult DeleteTypeById(int id)
        {
            Type model = _DB.types.Where(x => x.Id == id).FirstOrDefault();
            _DB.types.Remove(model);
            _DB.SaveChanges();
            return Json(model);

        }
        public IActionResult LoadTypes()
        {
            List<Type> typeList = _DB.types.Where(x => x.Name != null).ToList();
            return Json(typeList);
        }
        public IActionResult EditTypeById(string name, int id)
        {
            Type model = _DB.types.Where(x => x.Id == id).FirstOrDefault();
            model.Name = name;
            _DB.types.Update(model);
            _DB.SaveChanges();
            return Json(model);

        }
    }
}