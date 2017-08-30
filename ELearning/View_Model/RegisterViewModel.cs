using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearning.View_Model
{
    public class RegisterViewModel
    {
        public int id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This is a required field")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This is a required field")]
        public string lastName { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "This is a required field")]
        public string username { get; set; }

        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This is a required field")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "The new password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "This is a required field")]
        public string conPassword { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "This is a required field")]
        public string country { get; set; }

        [Display(Name = "Month")]
        [Required(ErrorMessage = "This is a required field")]
        public string month { get; set; }

        [Display(Name = "Day")]
        [Required(ErrorMessage = "This is a required field")]
        public int day { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "This is a required field")]
        public int year { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "This is a required field")]
        public string gender { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "This is a required field")]
        [Phone]
        public double phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "This is a required field")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string email { get; set; }
    }
}