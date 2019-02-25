using Graded_unit.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Graded_unit.Models.ViewModels;

namespace Graded_unit.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Index()
        {
            DatabaseModel model = new DatabaseModel();
            List<Member> mem = model.Member.ToList();
            return View(mem);
        }
        //TODO: Delete
        public ActionResult Add()
        {
            Member mem = new Member
            {
                Id = "id",
                MemberType = MemberType.Junior,
                Name = "alex"
            };
            DatabaseModel db = new DatabaseModel();
            db.Member.Add(mem);
            db.SaveChanges();

            return null;
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewMember m)
        {
            Console.WriteLine(m.ToString());
            return View();
        }
    }
}