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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());

            Txtıd.Text = x.ToString();
            Txtıd.Enabled = false; //Taşıdığımız ıd değeri değiştirelemesin, müdahale edilemesin. 


            if (Page.IsPostBack == false) // Sayfa ilk yüklendiğinde hafızaya aldığın verileri koru. -Update işlemi olmuyor yoksa
            {
                List<EntityOgrenci> OgrList = BusinessLogicLayer_Ogrenci.BusinessLogicLayer_DetayListele(x);

                TxtAd.Text = OgrList[0].AD.ToString();
                TxtSoyad.Text = OgrList[0].SOYAD.ToString();
                TxtNumara.Text = OgrList[0].BAKİYE.ToString();
                TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
                TxtSifre.Text = OgrList[0].SİFRE.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();

            entityOgrenci.AD = TxtAd.Text;
            entityOgrenci.SOYAD = TxtSoyad.Text;
            entityOgrenci.SİFRE = TxtSifre.Text;
            entityOgrenci.NUMARA = TxtNumara.Text;
            entityOgrenci.FOTOGRAF = TxtFoto.Text;
            entityOgrenci.İD = Convert.ToInt32(Txtıd.Text);

            BusinessLogicLayer_Ogrenci.OgrenciUpdate_BLL(entityOgrenci);
            Response.Redirect("OgrenciListesi.aspx"); // Yönlendirme Yaptım
        }
    }
}