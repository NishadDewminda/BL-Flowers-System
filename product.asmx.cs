using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication6.Models;

namespace WebApplication6
{
    /// <summary>
    /// Summary description for product
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class product : System.Web.Services.WebService
    {
       
        [WebMethod]
        public string InsertProduct(string productTitle, string productCategory, string productImageUrl, string productDescription, int productStock)
        {
            Product product = new Product
            {
                ProductTitle = productTitle,
                ProductCategory = productCategory,
                ProductImageUrl = productImageUrl,
                ProductDescription = productDescription,
                ProductStock = productStock
            };
            string status = product.Insert();
            if (status != "Failed")
                return "addded";
            return status;
        }
    }
}
