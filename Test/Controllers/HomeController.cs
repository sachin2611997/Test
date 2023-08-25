using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        DbEntity db = new DbEntity();
        DBAccessLayer dd = new DBAccessLayer();
        // GET: Home


        [HttpGet]
        public ActionResult Create()
        {
            var query = (from s in db.Masters where s.Name == "Education" select s);
            var list = query.ToList();
            ViewBag.educalist = new SelectList(list, "Index1", "Value");

            var OccupationQuery = (from s in db.Masters where s.Name == "Occupation" select s);
            var Occupationlist = OccupationQuery.ToList();
            ViewBag.occulist = new SelectList(Occupationlist, "Index1", "Value");

            var MaritalQuery = (from s in db.Masters where s.Name == "Marital" select s);
            var Maritallist = MaritalQuery.ToList();
            ViewBag.maritilist = new SelectList(Maritallist, "Index1", "Value");

            var ReligionQuery = (from s in db.Masters where s.Name == "Religion" select s);
            var Religionllist = ReligionQuery.ToList();
            ViewBag.religlist = new SelectList(Religionllist, "Index1", "Value");
            return View();
        }


        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create(Main m, string Red_patch_mouth,string White_patch_mouth)
        {
            dd.AddRecord(m);
            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {


            var data = dd.GetRecords().First(x => x.Demos.P_id == id);

            var query = (from s in db.Masters where s.Name == "Education" select s);
            var list = query.ToList();
            ViewBag.educalist = new SelectList(list, "Index1", "Value");

            var OccupationQuery = (from s in db.Masters where s.Name == "Occupation" select s);
            var Occupationlist = OccupationQuery.ToList();
            ViewBag.occulist = new SelectList(Occupationlist, "Index1", "Value");

            var MaritalQuery = (from s in db.Masters where s.Name == "Marital" select s);
            var Maritallist = MaritalQuery.ToList();
            ViewBag.maritilist = new SelectList(Maritallist, "Index1", "Value");

            var ReligionQuery = (from s in db.Masters where s.Name == "Religion" select s);
            var Religionllist = ReligionQuery.ToList();
            ViewBag.religlist = new SelectList(Religionllist, "Index1", "Value");


            return View(data);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(Main main)
        {

            var m = dd.EditRecord(main);
            UpdateModel(m);
            db.SaveChanges();


            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult EditPage()
        {
            return View();
        }

        [HttpPost]
        [ActionName("EditPage")]
        public ActionResult EditPageId(string P_id)
        {

            return RedirectToAction("Edit", "Home", new { id = P_id });
        }


        public ActionResult test()
        {
            return View();
        }
    }
}