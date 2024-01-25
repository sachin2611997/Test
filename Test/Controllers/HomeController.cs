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

            var StatusQuery = (from s in db.Masters where s.Name == "Status" select s);
            var Statuslist = StatusQuery.ToList();
            ViewBag.statuslist = new SelectList(Statuslist, "Index1", "Value");

            var RelativeQuery = (from s in db.Masters where s.Name == "Relative" select s);
            var Relativelist = RelativeQuery.ToList();
            ViewBag.relativelist = new SelectList(Relativelist, "Index1", "Value");

            var MenopauseQuery = (from s in db.Masters where s.Name == "Menopause" select s);
            var Menolist = MenopauseQuery.ToList();
            ViewBag.menolist = new SelectList(Menolist, "Index1", "Value");





            return View();
        }











        [HttpPost]
        
        public ActionResult CreatePost(Main m)
        {
           
            

            dd.AddRecord(m);
            string id = m.Demos.P_id;

         // var add=  m.Demos.Address.Take(3);
       //  var a=   m.Demos.Address.Substring(0, 3);
          //  var g = db.Demos.Max(u => (string.IsNullOrEmpty(u.P_id)));
           var rw= db.Demos.DefaultIfEmpty().Max(r => r.P_id == null);
        //  var f=  string.Join("", add + id);
         //  var d= id + 000001;          
              
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
        public ActionResult EditPost(Main main)
        {

            var m = dd.EditRecord(main);
            UpdateModel(m);
            db.SaveChanges();


            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult EditPage(string id)
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
        [ActionName("EditPage")]
        public ActionResult EditPageId(string P_id)
        {

            return RedirectToAction("Edit", "Home", new { id = P_id });
        }




        public ActionResult Page()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Page")]
        public ActionResult PageId(string P_id)
        {
            return RedirectToAction("EditPage", "Home", new { id = P_id });
        }



        public string getstringid(Main m)
        {
          string value=  db.Demos.Where(x => x.P_id == m.Demos.P_id).Max(x => x.P_id);
            m.Demos.P_id = value + 1;
            return m.Demos.P_id ;
        }
    }
}