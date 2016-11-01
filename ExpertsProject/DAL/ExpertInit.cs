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
                new Expert { FName="Bob",LName="Ross", Prefix=Prefix.Mr,},
                new Expert { FName="Stephen",LName="Hawkins", Prefix=Prefix.Dr,}
            };

            experts.ForEach(s => context.Experts.Add(s));
            context.SaveChanges();

            var expertises = new List<Expertise>
            {
                new Expertise { ExpertID=1,ExpertiseID=1,Category="Art",},
                new Expertise { ExpertID=1,ExpertiseID=2,Category="Physics", }
            };
            expertises.ForEach(s => context.Expertises.Add(s));
            context.SaveChanges();
        }
    }
}