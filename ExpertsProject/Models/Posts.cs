using System;

namespace ExpertsProject.Models
{
    public class Posts
    {
        public int Id { get; set; } 
        public string Subject { get; set; } 
        public DateTime OriginalDate { get; set; } 
        public DateTime LastDate { get; set; }
        public string Body { get; set; }
    }
}