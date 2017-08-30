using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearning.View_Model
{
    public class StartPage_ViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "This is a required field")]
        public string username { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This is a required field")]
        public string password { get; set; }

    }
}