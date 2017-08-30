using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearning.Models
{
    public class RegisterModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string country { get; set; }
        public string month { get; set; }
        public int day { get; set; }
        public int year { get; set; }
        public string gender { get; set; }
        public double phone { get; set; }
        public string email { get; set; }



    }
}