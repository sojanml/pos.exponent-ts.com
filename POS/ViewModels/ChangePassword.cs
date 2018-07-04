using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.ViewModels {
  public class ChangePassword {
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [Required(ErrorMessage ="Please enter the password to change")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Required(ErrorMessage = "You need to enter the same password again here")]
    [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
    public string ConfirmPassword { get; set; }
  }
}