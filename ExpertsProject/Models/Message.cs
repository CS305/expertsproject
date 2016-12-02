using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class Message
    {
        public int Id { get; set; } 
        public string ToEmail { get; set; } 
        public string FromEmail { get; set; }
    }
}