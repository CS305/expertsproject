using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class MessageModels2
    {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public string UserID { get; set; }
            public DateTime lastDate { get; set; }
            public DateTime originalDate { get; set; }
        }
    }