﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimePassScheduler.Models
{
    public class ScheduleResponseViewModel
    {
        public List<OncallConditionalStaffModel> OncallConditionalStaffs { get; set; }
     
    }
    public class OncallConditionalStaffModel
    {
        public int OncallConditionId { get; set; }
        public List<int> SelectedFirst { get; set; }
        public List<int> SelectedSecond { get; set; }
        public List<int> SelectedThird { get; set; }
    }
}