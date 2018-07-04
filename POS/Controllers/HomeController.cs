using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace POS.Controllers {
  public class HomeController : Controller {
    private Models.ExponentPortal db = new Models.ExponentPortal();
    public ActionResult Index() {
      return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Index(ViewModels.LoginForm loginForm) {
      if (ModelState.IsValid) {
        if(loginForm.IsValidLogin) {
          Session["UserID"] = loginForm.ID;
          Session["FullName"] = loginForm.FullName;
          Session["OrganizationLogo"] = loginForm.Organization.OrganizationLogo;
          Session["OrganizationName"] = loginForm.Organization.OrganizationName;
          Session["OrganizationID"] = loginForm.Organization.OrganizationID;          
          return RedirectToAction("Index", "Home");
        }
        ModelState.AddModelError("", "Invalid Email address or Password or Both. Please try again.");
      }
      return View(loginForm);
    }

    public ActionResult Create() {
      if (Session["UserID"] == null)
        return RedirectToAction("Index", "Home");
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(Models.POS_Customer customer) {
      if (Session["UserID"] == null)
        return RedirectToAction("Index", "Home");

      if (ModelState.IsValid) {
        if(customer.IsValid) {
          customer.SetFields(this.HttpContext);
          db.POS_Customer.Add(customer);
          try { 
          await db.SaveChangesAsync();
          } catch(System.Data.Entity.Validation.DbEntityValidationException e) {
            foreach (var eve in e.EntityValidationErrors) {
              ModelState.AddModelError("", $"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
              foreach (var ve in eve.ValidationErrors) {
                ModelState.AddModelError("", $"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
              }
            }
            return View(customer);
          }
          return View("Created", customer);
        } else {
          ModelState.AddModelError("CustomerPassportID", "Passport ID is required when Emirates ID Is not available");
          ModelState.AddModelError("CustomerNationality", "Nationality is required when Emirates ID Is not available");
        }
      }
      return View(customer);
    }//public async Task<ActionResult> Create(Models.POS_Customer customer)

    [ChildActionOnly]
    public async Task<ActionResult> Created(int id = 0) {
      if (Session["UserID"] == null)
        return RedirectToAction("Index", "Home");

      int ShopID = int.Parse(Session["UserID"].ToString());
      var customer = db.POS_Customer
        .Where(w => 
          w.CustomerID == id &&
          w.ShopID == ShopID
        );
      if (!customer.Any())
        return HttpNotFound();
      var thisCustomer = await customer.FirstOrDefaultAsync();
      return View(thisCustomer);
    }


    public ActionResult Logout() {
      Session.Abandon();
      return RedirectToAction("Index");
    }

    public ActionResult ResetPassword() {
      if (Session["UserID"] == null)
        return RedirectToAction("Index", "Home");
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> ResetPassword(ViewModels.ChangePassword changePassword) {
      if (Session["UserID"] == null)
        return RedirectToAction("Index", "Home");

      if (ModelState.IsValid) {
        int ShopID = int.Parse(Session["UserID"].ToString());
        var shop = await db.POS_Shop.Where(w => w.ShopID == ShopID).FirstOrDefaultAsync();
        shop.ShopPassword = Utilities.MD5(changePassword.Password);
        db.POS_Shop.Attach(shop);
        db.Entry(shop).Property(x => x.ShopPassword).IsModified = true;
        await db.SaveChangesAsync();
        return View("PasswordChanged");
      }
      return View();
    }

    [ChildActionOnly]
    public ActionResult PasswordChanged() {
      if (Session["UserID"] == null)
        return RedirectToAction("Index", "Home");
      return View();
    }

  }
}