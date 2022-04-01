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


            EntityOgrenci entityOgrenci = new EntityOgrenci();
            List<EntityOgrenci> OgrList = BusinessLogicLayer_Ogrenci.BusinessLogicLayer_DetayListele(x);

            TxtAd.Text = OgrList[0].AD.ToString();
            TxtSoyad.Text = OgrList[0].SOYAD.ToString();
            TxtNumara.Text = OgrList[0].BAKİYE.ToString();
            TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
            TxtSifre.Text = OgrList[0].SİFRE.ToString();
            
        }
    }
}