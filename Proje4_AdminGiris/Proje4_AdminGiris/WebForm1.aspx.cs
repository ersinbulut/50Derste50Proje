using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje4_AdminGiris
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=BULUTS-PC\BULUTS;Initial Catalog=Proje4AdminDB;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLADMİN where KULLANICI=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Veriler.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş Yaptınız!");
            }
            baglanti.Close();
        }
    }
}