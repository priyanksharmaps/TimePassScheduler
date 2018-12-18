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
        private List<Staff> MockDataStaffMembers()
        {

            var StaffMembers = new List<Staff>();
            StaffMembers.Add(new Staff { ID = 1, Name = "James Smith" });
            StaffMembers.Add(new Staff { ID = 2, Name = "Michael Smith" });
            StaffMembers.Add(new Staff { ID = 3, Name = "Robert Smith" });
            StaffMembers.Add(new Staff { ID = 4, Name = "David Smith" });
            StaffMembers.Add(new Staff { ID = 5, Name = "Maria Garcia" });
            StaffMembers.Add(new Staff { ID = 6, Name = "Maria Hernandez" });
            StaffMembers.Add(new Staff { ID = 7, Name = "Chistopher Smith" });
            StaffMembers.Add(new Staff { ID = 8, Name = "Daniel Smith" });
            StaffMembers.Add(new Staff { ID = 9, Name = "Thomas Garcia" });
            StaffMembers.Add(new Staff { ID = 10, Name = "Paul Hernandez" });
            StaffMembers.Add(new Staff { ID = 11, Name = "Steven Smith" });
            StaffMembers.Add(new Staff { ID = 12, Name = "Ronald Smith" });
            
            return StaffMembers;
        }
        private List<County> MockDataCounty()
        {
            var counties = new List<County>();

            //county 1
            counties.Add(new County { ID = 1, Name = "Atlantic" });

            //county 2
            counties.Add(new County { ID = 2, Name = "Bergen" });

            //county 3
            counties.Add(new County { ID = 3, Name = "Burlington" });

            return counties;
        }
        // GET: Api
        public JsonResult GetCounties()
        {
            var result = new SchedulerViewModal();
            result.Counties = MockDataCounty();
            result.StaffMembers = MockDataStaffMembers();
            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SubmitSchedule(ScheduleResponseViewModel response)
        {
            return Json(new {  }, JsonRequestBehavior.AllowGet);
        }
    }
}