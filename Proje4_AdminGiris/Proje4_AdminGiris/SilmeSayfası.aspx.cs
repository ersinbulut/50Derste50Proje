using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje4_AdminGiris
{
    public partial class SilmeSayfası : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"].ToString());
            DataSet1TableAdapters.TBLADMİNTableAdapter dt = new DataSet1TableAdapters.TBLADMİNTableAdapter();
            dt.AdminSil(x);
            Response.Redirect("Veriler.aspx");
        }
    }
}