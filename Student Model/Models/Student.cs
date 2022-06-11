using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Model.Models
{
    public class Student
    {
        [Required]public string Id { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string DoB { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
       
        public string Email { get; set; }
    }
}