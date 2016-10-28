using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class Expert
    {
        public string UserID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string ExpertiseId { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public IsVerified IsVerified { get; set; }
    }
    public enum IsVerified
    {
        Yes = 0,
        No
    }
}