using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS.DataTables {

  public class DataTableResult {
    public int draw { get; set; } = 1;
    public int recordsTotal { get; set; } = 0;
    public int recordsFiltered { get; set; } = 0;
    public object data { get; set; }
  }


  public class DataTableQuery {
    public int draw { get; set; } = 0;    
    public int start { get; set; } = 0;
    public int length { get; set; } = 50;
    public DataTableQuerySearch search { get; set; } = new DataTableQuerySearch();
    public DataTableQueryOrderBy order { get; set; } = new DataTableQueryOrderBy();

    public DataTableQuery(System.Collections.Specialized.NameValueCollection QueryString) {

      foreach (var name in QueryString.Keys) {
        Console.WriteLine(name);
        String sKey = name.ToString();
        switch (sKey) {
        case "draw":
          int.TryParse(QueryString[sKey], out int tdraw);
          this.draw = tdraw;
          break;
        case "length":
          int.TryParse(QueryString[sKey], out int tlength);
          this.length = tlength;
          break;
        case "search[value]":
          this.search.value = QueryString[sKey];
          break;
        case "search[regex]":
          this.search.regex = String.Equals(QueryString[sKey], "true");
          break;
        case "order[0][column]":
          int.TryParse(QueryString[sKey], out int torder);
          this.order.column = torder;
          break;
        case "order[0][dir]":
          this.order.Ascending = String.Equals(QueryString[sKey], "asc");
          break;
        }
      }
    }
  }
  public class DataTableQueryOrderBy {
    public int column { get; set; } = 0;
    public bool Ascending { get; set; } = true;
  }

  public class DataTableQueryColumn {
    public String data { get; set; }
    public String name { get; set; }
    public bool searchable { get; set; }
    public bool orderable { get; set; }
    public DataTableQuerySearch search { get; set; } = new DataTableQuerySearch();
  }

  public class DataTableQuerySearch {
    public String value { get; set; }
    public bool regex { get; set; }
  }
}