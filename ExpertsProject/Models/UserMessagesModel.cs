using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertsProject.Models
{
    public class UserMessagesModel
    {
           
        public String userID { get; set; }
        public DateTime postDate { get; set; }
        public dateTime dateOfLastMessage { get; set; }
        public DateTime currentDate { get; set; }
        public String subject { get; set; }
        public String messageID { get; set; }
        public String body { get; set; }
        public String ResponseID { get; set; }
        
    }
}