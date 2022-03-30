using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;

namespace YazOkuluDersKayit_Projesi
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]); // Diğer formdan taşınan değeri "x" adlı değişkene ata. 
            Response.Write(x);

            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.İD = x;
            BusinessLogicLayer_Ogrenci.OgrenciDelete_BLL(entityOgrenci.İD);
            Response.Redirect("OgrenciListesi.aspx"); // Tekrar Yönlendir


        }
    }
}