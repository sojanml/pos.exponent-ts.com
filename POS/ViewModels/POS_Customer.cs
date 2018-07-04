using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS.ViewModels {
  public class POS_Customer {
    public int CustomerID { get; set; }
    public string RPASSerial { get; set; }
    public string RPASManufacture { get; set; }
    public string RPASModel { get; set; }
    public System.DateTime CreatedOn { get; set; }
    public string Reference { get; set; }

  }
}