using ELearning.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ELearning.Data
{
    public class Context: DbContext
    {
        public Context()
            : base("name=MyDb")
        {

        }
        public DbSet<RegisterModel> reg { get; set; }
        public DbSet<CountryModel> ConDrop { get; set; }
        public DbSet<BirthdateModel> Birth { get; set; }
        public DbSet<MaterialModel> mat { get; set; }
       
    }
    
}