using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje2_OgrenciKayit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENCİLERTableAdapter dt = new DataSet1TableAdapters.TBLOGRENCİLERTableAdapter();
            dt.OgrenciEkle(TxtAdSoyad.Text, TxtNumara.Text, TxtMail.Text, DropDownList1.SelectedItem.ToString(), DropDownList2.SelectedItem.ToString());
        }
    }
}