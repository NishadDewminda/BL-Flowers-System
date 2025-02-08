using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication6.Models;

namespace WebApplication6
{
    /// <summary>
    /// Summary description for supplier
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class supplier : System.Web.Services.WebService
    {

      
        [WebMethod]
        public string InsertSupplier(string supplierName, string supplierContactNumber, string supplierEmail)
        {
            Seller supplier = new Seller
            {
                SellerName = supplierName,
                SellerContactNumber = supplierContactNumber,
                SellerContactEmail = supplierEmail

            };
            string status = supplier.Insert();
            if (status != "Failed")
                return "addded";
            return status;
        }
    }
}
