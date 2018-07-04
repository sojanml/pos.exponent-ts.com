using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.ViewModels {
  public class LoginForm {
    private Models.ExponentPortal db = new Models.ExponentPortal();
    public Models.POS_Organization Organization { get; private set; } = new Models.POS_Organization();
    public int ID { get; private set; } = 0;
    public String FullName { get; private set; } = String.Empty;


    [Display(Name = "Please enter your registered email address.")]
    [Required(ErrorMessage = "Email address is requried")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string LoginEmail { get; set; }

    [Required(ErrorMessage = "Please enter your password (Case Sensitive)")]
    [Display(Name = "Login Password")]
    [DataType(DataType.Password)]
    public String LoginPassword { get; set; }
    

    public bool IsValidLogin {
      get {
        String PasswordMD5 = Utilities.MD5(this.LoginPassword);
        var query = db.POS_Shop.Where(w => 
          w.ShopEmail ==  this.LoginEmail && 
         w.ShopPassword == PasswordMD5);
        if(query.Any()) {
          var Record = query.FirstOrDefault();
          ID = Record.ShopID;
          FullName = Record.ShopName;

          Organization = db.POS_Organization
            .Where(w => w.OrganizationID == Record.OrganizationID)
            .FirstOrDefault();

          return true;
        }
        return false;
      }
    }

  }
}