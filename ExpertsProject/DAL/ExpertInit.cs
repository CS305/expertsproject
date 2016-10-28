using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExpertsProject.Models;

namespace ExpertsProject.DAL
{
    public class ExpertInit : System.Data.Entity. DropCreateDatabaseIfModelChanges<ExpertContext>
    {
        protected override void Seed(ExpertContext context)
        {
            var experts = new List<Expert>
            {

            };
            context.SaveChanges();
        }
    }
}