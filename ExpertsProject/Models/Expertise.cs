using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class Expertise
    {
        public string ExpertiseID { get; set; }
        public string ExpertID { get; set; }
        public string Category { get; set; }

        public virtual Expert Expert { get; set; }
    }
}