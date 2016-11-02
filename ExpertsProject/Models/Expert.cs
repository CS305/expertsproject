using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class Expert
    {
        public string ExpertID { get; set; }
        //public string FName { get; set; }
        //public string LName { get; set; }
        public string ExpertiseId { get; set; }
        //public string Email { get; set; }
        //public int PhoneNumber { get; set; }
        public IsVerified IsVerified { get; set; }
        public Prefix Prefix { get; set; }
    }

    public enum Prefix
    {
        None = 0,
        Dr,
        Mr,
        Ms,
        Mrs
    }
    public enum IsVerified
    {
        No = 0,
        Yes
    }
}