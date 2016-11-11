using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExpertsProject.Models;
using IdentitySample.Models;

namespace ExpertsProject.DAL
{
    public class ExpertInit : System.Data.Entity. DropCreateDatabaseIfModelChanges<ExpertContext>
    {
        protected override void Seed(ExpertContext context)
        {
            var experts = new List<ApplicationUser>
            {
                new ApplicationUser { firstName="Bob",lastName="Ross", }, //Prefix=Prefix.Mr,},
                new ApplicationUser { firstName="Stephen",lastName="Hawkins", } //Prefix=Prefix.Dr,}
            };

            experts.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var expertises = new List<Expert>
            {
                new Models.Expert { Category="Art", },
                new Models.Expert { Category="Physics", }
            };
            expertises.ForEach(s => context.Experts.Add(s));
            context.SaveChanges();
        }
    }
}