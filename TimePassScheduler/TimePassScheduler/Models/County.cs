using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimePassScheduler.Models
{
    public class County
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Staff> StaffMembers { get; set; }
    }
}