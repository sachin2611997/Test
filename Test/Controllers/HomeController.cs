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
            var Educationquery = q.educationlist();
            var Educationlist = Educationquery.ToList();
            ViewBag.educalist = new SelectList(Educationlist, "Index1", "Value");

            var OccupationQuery = q.occupationlist();
            var Occupationlist = OccupationQuery.ToList();
            ViewBag.occulist = new SelectList(Occupationlist, "Index1", "Value");

            var MaritalQuery = q.maritallist();
            var Maritallist = MaritalQuery.ToList();
            ViewBag.maritilist = new SelectList(Maritallist, "Index1", "Value");

            var ReligionQuery =q.religionlist();
            var Religionllist = ReligionQuery.ToList();
            ViewBag.religlist = new SelectList(Religionllist, "Index1", "Value");

            var StatusQuery = q.statuslist();
            var Statuslist = StatusQuery.ToList();
            ViewBag.statuslist = new SelectList(Statuslist, "Index1", "Value");

            var RelativeQuery = q.relativelist();
            var Relativelist = RelativeQuery.ToList();
            ViewBag.relativelist = new SelectList(Relativelist, "Index1", "Value");

            var MenopauseQuery = q.menopauselist();
            var Menolist = MenopauseQuery.ToList();
            ViewBag.menolist = new SelectList(Menolist, "Index1", "Value");

            var HygieneQuery = q.hygienelist();
            var Hygienelist = HygieneQuery.ToList();
            ViewBag.hygienelist = new SelectList(Hygienelist, "Index1", "Value");


            var ConditionQuery = q.conditionlist();
            var Conditionlist = ConditionQuery.ToList();
            ViewBag.conditionlist = new SelectList(Conditionlist, "Index1", "Value");


            var HabitQuery = q.habitlist();
            var Habitlist = HabitQuery.ToList();
            ViewBag.habitlist = new SelectList(Habitlist, "Index1", "Value");


            var LifeStyleQuery = q.lifeStylelist() ;
            var LifeStylelist = LifeStyleQuery.ToList();
            ViewBag.lifestylelist = new SelectList(LifeStylelist, "Index1", "Value");

          


            return View();
        }


        [HttpPost]
        
        public ActionResult CreatePost(Main m)
        {
           
               dd.AddRecord(m);
         
             return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {


            var data = dd.GetRecords().First(x => x.Demos.P_ID == id);

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
        public ActionResult EditPost(Main main)
        {

            var m = dd.EditRecord(main);
            UpdateModel(m);
            db.SaveChanges();


            return RedirectToAction("Create");
        }


        [HttpGet]
        public ActionResult edittest(string id)
            {
            
            var data = dd.gettest().FirstOrDefault(x=>x.P_ID==id);
     
           
            return View(data);
        }

        [HttpPost]
        [ActionName("edittest")]
        public ActionResult EditPost(test t)
        {
            var data = dd.edittest(t);
            UpdateModel(data);
            db.SaveChanges();
           
            return RedirectToAction("test");
        }


        [HttpGet]
        public ActionResult EditPage(string id)
        {
            var data = dd.GetRecords().First(x => x.Demos.P_ID == id);

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
            return RedirectToAction("EditPage", "Home", new { id = P_ID });
        }



        [HttpGet]
        public ActionResult createtest()
        {
           
            return View();
        }
        [HttpPost]
        [ActionName("createtest")]
        public ActionResult create(test t)
        {
           
          
           dd.addtest1(t);
            return RedirectToAction("createtest");
        }

        public ActionResult test()
        {
           
          var list= dd.gettest();
            
            return View(list);
        }

       
    }
}