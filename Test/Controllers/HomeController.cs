using demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        DbEntity db = new DbEntity();
        Query q = new Query();
        DBAccessLayer dd = new DBAccessLayer();
        // GET: Home


        [HttpGet]
        public ActionResult Create()
        {
            var Sexquery = dd.Getmaster("Gender");
            var Sexlist = Sexquery.ToList();
            ViewBag.sexlist = new SelectList(Sexlist, "INDEX", "VALUE");

            var Educationquery = dd.Getmaster("Education");
            var Educationlist = Educationquery.ToList();
            ViewBag.educalist = new SelectList(Educationlist, "INDEX", "VALUE");

            var OccupationQuery = dd.Getmaster("Occupation");
            var Occupationlist = OccupationQuery.ToList();
            ViewBag.occulist = new SelectList(Occupationlist, "INDEX", "VALUE");

            var MaritalQuery = dd.Getmaster("Marital");
            var Maritallist = MaritalQuery.ToList();
            ViewBag.maritilist = new SelectList(Maritallist, "INDEX", "VALUE");

            var ReligionQuery = dd.Getmaster("Religion");
            var Religionllist = ReligionQuery.ToList();
            ViewBag.religlist = new SelectList(Religionllist, "INDEX", "VALUE");

            var StatusQuery = dd.Getmaster("Status");
            var Statuslist = StatusQuery.ToList();
            ViewBag.statuslist = new SelectList(Statuslist, "INDEX", "VALUE");

            var RelativeQuery = dd.Getmaster("Relative");
            var Relativelist = RelativeQuery.ToList();
            ViewBag.relativelist = new SelectList(Relativelist, "INDEX", "VALUE");

            var MenopauseQuery = dd.Getmaster("Menopause");
            var Menolist = MenopauseQuery.ToList();
            ViewBag.menolist = new SelectList(Menolist, "INDEX", "VALUE");

            var HygieneQuery = dd.Getmaster("Hygiene");
            var Hygienelist = HygieneQuery.ToList();
            ViewBag.hygienelist = new SelectList(Hygienelist, "INDEX", "VALUE");


            var ConditionQuery = dd.Getmaster("Condition");
            var Conditionlist = ConditionQuery.ToList();
            ViewBag.conditionlist = new SelectList(Conditionlist, "INDEX", "VALUE");


            var HabitQuery = dd.Getmaster("Habit");
            var Habitlist = HabitQuery.ToList();
            ViewBag.habitlist = new SelectList(Habitlist, "INDEX", "VALUE");


            var LifeStyleQuery = dd.Getmaster("Lifestyle");
            var LifeStylelist = LifeStyleQuery.ToList();
            ViewBag.lifestylelist = new SelectList(LifeStylelist, "INDEX", "VALUE");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePost(Main m)
        {
            if (db.Demos.Any(x=>x.P_ID==m.Demos.P_ID))
            {
                ModelState.AddModelError(m.Demos.P_ID,"already exists");
            }
           dd.AddRecord(m);
          
         
             return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {


            var data = dd.GetRecords().Where(x=>x.Demos.P_ID==id).FirstOrDefault();
           

            var Sexquery = dd.Getmaster("Gender");
            var Sexlist = Sexquery.ToList();
            ViewBag.sexlist = new SelectList(Sexlist, "INDEX", "VALUE");

            var Educationquery = dd.Getmaster("Education");
            var Educationlist = Educationquery.ToList();
            ViewBag.educalist = new SelectList(Educationlist, "INDEX", "VALUE");

            var OccupationQuery = dd.Getmaster("Occupation");
            var Occupationlist = OccupationQuery.ToList();
            ViewBag.occulist = new SelectList(Occupationlist, "INDEX", "VALUE");

            var MaritalQuery = dd.Getmaster("Marital");
            var Maritallist = MaritalQuery.ToList();
            ViewBag.maritilist = new SelectList(Maritallist, "INDEX", "VALUE");

            var ReligionQuery = dd.Getmaster("Religion");
            var Religionllist = ReligionQuery.ToList();
            ViewBag.religlist = new SelectList(Religionllist, "INDEX", "VALUE");

            var StatusQuery = dd.Getmaster("Status");
            var Statuslist = StatusQuery.ToList();
            ViewBag.statuslist = new SelectList(Statuslist, "INDEX", "VALUE");

            var RelativeQuery = dd.Getmaster("Relative");
            var Relativelist = RelativeQuery.ToList();
            ViewBag.relativelist = new SelectList(Relativelist, "INDEX", "VALUE");

            var MenopauseQuery = dd.Getmaster("Menopause");
            var Menolist = MenopauseQuery.ToList();
            ViewBag.menolist = new SelectList(Menolist, "INDEX", "VALUE");

            var HygieneQuery = dd.Getmaster("Hygiene");
            var Hygienelist = HygieneQuery.ToList();
            ViewBag.hygienelist = new SelectList(Hygienelist, "INDEX", "VALUE");


            var ConditionQuery = dd.Getmaster("Condition");
            var Conditionlist = ConditionQuery.ToList();
            ViewBag.conditionlist = new SelectList(Conditionlist, "INDEX", "VALUE");


            var HabitQuery = dd.Getmaster("Habit");
            var Habitlist = HabitQuery.ToList();
            ViewBag.habitlist = new SelectList(Habitlist, "INDEX", "VALUE");


            var LifeStyleQuery = dd.Getmaster("Lifestyle");
            var LifeStylelist = LifeStyleQuery.ToList();
            ViewBag.lifestylelist = new SelectList(LifeStylelist, "INDEX", "VALUE");


            return View(data);
        }

        [HttpPost]       
        public ActionResult EditPost(Main main)
        {

            var m = dd.EditRecord(main);
            UpdateModel(m);
            db.SaveChanges();


            return RedirectToAction("Create");
        }




        //[HttpPost]
        //[ActionName("edittest")]
        //public ActionResult EditPost(test t)
        //{
        //    var data = dd.EditRecord(t);
        //    UpdateModel(data);
        //    db.SaveChanges();

        //    return RedirectToAction("test");
        //}


        //[HttpGet]
        //public ActionResult EditPage(string id)
        //{
        //    var data = dd.GetRecords().First(x => x.Demos.P_ID == id);

        //    var query = (from s in db.Masters where s.Name == "Education" select s);
        //    var list = query.ToList();
        //    ViewBag.educalist = new SelectList(list, "Index1", "Value");

        //    var OccupationQuery = (from s in db.Masters where s.Name == "Occupation" select s);
        //    var Occupationlist = OccupationQuery.ToList();
        //    ViewBag.occulist = new SelectList(Occupationlist, "Index1", "Value");

        //    var MaritalQuery = (from s in db.Masters where s.Name == "Marital" select s);
        //    var Maritallist = MaritalQuery.ToList();
        //    ViewBag.maritilist = new SelectList(Maritallist, "Index1", "Value");

        //    var ReligionQuery = (from s in db.Masters where s.Name == "Religion" select s);
        //    var Religionllist = ReligionQuery.ToList();
        //    ViewBag.religlist = new SelectList(Religionllist, "Index1", "Value");







        //    return View(data);
        //}

        [HttpPost]
        [ActionName("EditPage")]
        public ActionResult EditPageId(string P_ID)
        {

            return RedirectToAction("Edit", "Home", new { id = P_ID });
        }




        public ActionResult Page()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Page")]
        public ActionResult PageId(string P_ID)
        {
            return RedirectToAction("Edit", "Home", new { id = P_ID });
        }



       
       
       

       
    }
}