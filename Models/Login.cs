using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLTHPT.Models
{
    public partial class Login
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        

        
    // [Required]
    // [EmailAddress]
    // public string Email { get; set; }

    // [Required]
    // [DataType(DataType.Password)]
    // public string Password { get; set; }

    // [Display(Name = "Remember me")]
    // public bool RememberMe { get; set; }
       
    }
}