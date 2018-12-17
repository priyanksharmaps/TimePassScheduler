using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimePassScheduler.Models;

namespace TimePassScheduler.Controllers
{
   

    public class ApiController : Controller
    {
        private List<County> MockData()
        {
            var counties = new List<County>();
            //county 1
            var county1 = new County { ID = 1, Name = "Atlantic" };
            county1.StaffMembers = new List<Staff>();
            county1.StaffMembers.Add(new Staff { ID = 1, Name = "James Smith" });
            county1.StaffMembers.Add(new Staff { ID = 2, Name = "Michael Smith" });
            county1.StaffMembers.Add(new Staff { ID = 3, Name = "Robert Smith" });
            county1.StaffMembers.Add(new Staff { ID = 4, Name = "David Smith" });
            counties.Add(county1);

            //county 2
            var county2 = new County { ID = 1, Name = "Bergen" };
            county2.StaffMembers = new List<Staff>();
            county2.StaffMembers.Add(new Staff { ID = 5, Name = "Maria Garcia" });
            county2.StaffMembers.Add(new Staff { ID = 6, Name = "Maria Hernandez" });
            county2.StaffMembers.Add(new Staff { ID = 7, Name = "Chistopher Smith" });
            county2.StaffMembers.Add(new Staff { ID = 8, Name = "Daniel Smith" });
            counties.Add(county2);

            //county 2
            var county3 = new County { ID = 1, Name = "Burlington" };
            county3.StaffMembers = new List<Staff>();
            county3.StaffMembers.Add(new Staff { ID = 9, Name = "Thomas Garcia" });
            county3.StaffMembers.Add(new Staff { ID = 10, Name = "Paul Hernandez" });
            county3.StaffMembers.Add(new Staff { ID = 11, Name = "Steven Smith" });
            county3.StaffMembers.Add(new Staff { ID = 12, Name = "Ronald Smith" });
            counties.Add(county3);

            return counties;
        }
        // GET: Api
        public JsonResult GetCounties()
        {
            var counties = new SchedulerViewModal();
            counties.Counties = MockData();
            return Json(new { counties }, JsonRequestBehavior.AllowGet);
        }
    }
}