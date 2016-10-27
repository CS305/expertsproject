using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class MessageModel
    {
        public string MessageId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; }
        public string ExpertiseId { get; set; }
        public DateTime Date { get; set; }

    }
}