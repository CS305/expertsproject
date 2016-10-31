using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class Expertise
    {
        public int ExpertiseID { get; set; }
        public int ExpertID { get; set; }
        public string Category { get; set; }

        public virtual Expert Expert { get; set; }
    }
}