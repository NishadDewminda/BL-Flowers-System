using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication6.Models;

namespace WebApplication6
{
    /// <summary>
    /// Summary description for seller
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class seller : System.Web.Services.WebService
    {
       
        [WebMethod]
        public string InsertProduct(string sellerName, string sellerContactNumber, string sellerContactEmail)
        {
            Seller seller = new Seller
            {
                SellerName = sellerName,
                SellerContactNumber = sellerContactNumber,
                SellerContactEmail = sellerContactEmail,
               
            };
            string status = seller.Insert();
            if (status != "Failed")
                return "addded";
            return status;
        }
    }
}
