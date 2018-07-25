using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArchivosPlanosWeb.Services
{
    public class hey : System.Web.UI.Page
    {
        public void hey2()
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "script", "Show();", true);
        }
       
    }
}