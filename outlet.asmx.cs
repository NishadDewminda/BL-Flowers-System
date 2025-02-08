using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication6.Models;

namespace WebApplication6
{
    /// <summary>
    /// Summary description for outlet
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class outlet : System.Web.Services.WebService
    {
   

        [WebMethod]
        public string InsertOutlet(string location, string contactNumber, string adress)
        {
            Outlet outlet = new Outlet
            {
                Location = location,
                ContactNumber = contactNumber,
                Adress = adress
            };
            string status = outlet.Insert();
            if (status != "Failed")
                return "addded";
            return status;
        }
    }
}

