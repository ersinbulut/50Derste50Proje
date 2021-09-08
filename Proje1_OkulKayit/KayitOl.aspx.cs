using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Proje1_OkulKayit
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENCİTableAdapter dt = new DataSet1TableAdapters.TBLOGRENCİTableAdapter();
            dt.OgrenciEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            
        }

    }
}