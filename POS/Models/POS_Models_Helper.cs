using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Models {

  [MetadataType(typeof(POS_CustomerHelper))]
  public partial class POS_Customer {

    public bool IsValid  {
      get { 
      if (String.IsNullOrEmpty(CustomerEmiratesID)) {
          if (String.IsNullOrEmpty(CustomerPassportID) || String.IsNullOrEmpty(CustomerNationality))
            return false;
      }//if (String.IsNullOrEmpty(CustomerEmiratesID))
        return true;
    }//Validate
    }

    public bool SetFields(HttpContextBase context) {
      this.CreatedOn = DateTime.UtcNow;
      this.ShopID = int.Parse(context.Session["UserID"].ToString());
      this.OrganizationID = int.Parse(context.Session["OrganizationID"].ToString());
      this.Reference =
        Utilities.RandomString(4) + "-" +
        Utilities.RandomString(4) + "-" +
        Utilities.RandomString(6);
      this.UserLoginKey = Utilities.RandomString(32);
      return true;
    }


  }

  public class POS_CustomerHelper {
    [Display(Name = "Customer Name")]
    [Required]
    public String CustomerName { get; set; }

    [Display(Name = "Customer Email Address")]
    [Required]
    [EmailAddress]
    public String CustomerEmail { get; set; }

    [Required(ErrorMessage = "Please Enter the Mobile Phone Number")]
    [Display(Name = "Mobile Phone Number")]
    [RegularExpression(@"^(\+)?([0-9\s-]{8,20})$", ErrorMessage = "Please enter valid phone no.")]
    public String CustomerTelephone { get; set; }

    [Display(Name = "Emirates ID")]
    public String CustomerEmiratesID { get; set; }

    [Display(Name = "Passport Number")]
    public String CustomerPassportID { get; set; }

    [Display(Name = "Nationality")]
    public String CustomerNationality { get; set; }

    [Display(Name = "RPAS License Number (with DCAA)")]
    public String RPASLicenseNumber { get; set; }
    [Display(Name = "RPAS License Expiry Date (with DCAA)")]
    public DateTime RPASLicenseExpiry { get; set; }

    [Display(Name = "RPAS Serial Number")]
    [Required(ErrorMessage = "Please Enter the RPAS Serial Number")]
    public String RPASSerial { get; set; }

    [Display(Name = "RPAS Manufacture")]
    [Required(ErrorMessage = "Please Enter the RPAS Manufacture")]
    public String RPASManufacture { get; set; }

    [Display(Name = "RPAS Model")]
    [Required(ErrorMessage = "Please Enter the RPAS Model")]
    public String RPASModel { get; set; }



  }

}