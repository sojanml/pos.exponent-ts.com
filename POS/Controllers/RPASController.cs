using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace POS.Controllers {
  public class RPASController : Controller {
    private Models.ExponentPortal db = new Models.ExponentPortal();
    // GET: RPAS
    public ActionResult Index() {
      return View();
    }

    public async Task<ActionResult> Data() {
      String[] SortFields = { "Reference", "RPASSerial", "RPASManufacture", "RPASModel", "CreatedOn" };
      System.Collections.Specialized.NameValueCollection QueryString = Request.QueryString;
      DataTables.DataTableQuery query = new DataTables.DataTableQuery(Request.QueryString);
      DataTables.DataTableResult result = new DataTables.DataTableResult();
      int ShopID = int.Parse(Session["UserID"].ToString());


      var DataQuery = db.POS_Customer
        .Where(w => w.ShopID == ShopID);
      result.draw = query.draw;
      result.recordsTotal = DataQuery.Count();

      if(!String.IsNullOrEmpty(query.search.value)) {
        DataQuery = DataQuery.Where(w =>
          w.Reference.Contains(query.search.value) ||
          w.RPASSerial.Contains(query.search.value) ||
          w.RPASManufacture.Contains(query.search.value) ||
          w.RPASModel.Contains(query.search.value) 
        );
      }

      var ViewQuery =
        from d in DataQuery
        select new ViewModels.POS_Customer {
          Reference = d.Reference,
          RPASSerial = d.RPASSerial,
          RPASManufacture = d.RPASManufacture,
          RPASModel = d.RPASModel,
          CreatedOn = d.CreatedOn
        };

      result.recordsFiltered = ViewQuery.Count();

      result.data =  await ViewQuery
        .OrderBy(SortFields[query.order.column], query.order.Ascending)
        .Skip(query.start)
        .Take(query.length)
        .ToListAsync();

      return Json(result, JsonRequestBehavior.AllowGet);
    }



  }
}