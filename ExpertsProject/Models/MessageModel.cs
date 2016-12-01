using System;

namespace ExpertsProject.Models
{
    public class MessageModel
    {
        public int Id { get; set; } 
        public string Subject { get; set; } 
        public string Body { get; set; } 
        public string UserID { get; set; } 
        public DateTime Date { get; set; }
    }
}