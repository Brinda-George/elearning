using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearning.Models
{
    public class MaterialModel
    {
        public int id { get; set; }
       [Display(Name = "Select technology")]
        public string technology { get; set; }
        public string material1 { get; set; }
        public string material2 { get; set; }
        public string material3 { get; set; }
        public string material4 { get; set; }

    }
}