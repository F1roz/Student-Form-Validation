using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Model.Models
{
    public class Student
    {
        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[1-3]{1}$", ErrorMessage = "Id format did not matched")]
        public string Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z -. a-z]+$", ErrorMessage = "Name format did not matched")]
        public string Name { get; set; }
        [Required] 
        public string DoB { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]

       [RegularExpression(@"^([a-z0-9\+_\-]+)(\.[a-z0-9\+_\-]+)*@([a-z0-9\-]+\.)+[a-z]{2,6}$", ErrorMessage = "Email format did not matched")] 
        public string Email { get; set; }
    }
}