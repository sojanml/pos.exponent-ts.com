using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;

namespace POS {
  public static class Utilities {
    private static Models.ExponentPortal db = new Models.ExponentPortal();
    private static Random randomIns = new Random();

    public static String Right(String str, int Length) {
      int L = str.Length;
      if (L < Length)
        Length = L;
      return str.Substring(L - Length);
    }

    public static String RandomString(int Length) {
      var charsALL = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";      
      var rndChars = 
        Enumerable.Range(0, Length)
        .Select(_ => charsALL[randomIns.Next(charsALL.Length)])
        .ToArray();
      return new String(rndChars);
    }

    public static string MD5(string input) {
      using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create()) {
        // Convert the input string to a byte array and compute the hash.
        byte[] data = md5Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));

        // Create a new Stringbuilder to collect the bytes
        // and create a string.
        System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();

        // Loop through each byte of the hashed data 
        // and format each one as a hexadecimal string.
        for (int i = 0; i < data.Length; i++) {
          sBuilder.Append(data[i].ToString("x2"));
        }

        // Return the hexadecimal string.
        return sBuilder.ToString();
      }
    }

    public static IOrderedQueryable<TEntity> OrderBy<TEntity>(
      this IQueryable<TEntity> source,
      string orderByProperty, bool desc) {
      string command = desc ? "OrderByDescending" : "OrderBy";
      var type = typeof(TEntity);
      var property = type.GetProperty(orderByProperty);
      var parameter = Expression.Parameter(type, "p");
      var propertyAccess = Expression.MakeMemberAccess(parameter, property);
      var orderByExpression = Expression.Lambda(propertyAccess, parameter);
      var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
          source.Expression, Expression.Quote(orderByExpression));
      return (IOrderedQueryable<TEntity>)source.Provider.CreateQuery<TEntity>(resultExpression);
    }



  }
}