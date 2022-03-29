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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.AD = TxtAd.Text;
            entityOgrenci.SOYAD = TxtSoyad.Text;
            entityOgrenci.NUMARA = TxtNumara.Text;
            entityOgrenci.SİFRE = TxtŞifre.Text;
            entityOgrenci.FOTOGRAF = TxtFoto.Text;

            BusinessLogicLayer_Ogrenci.OgrenciAdd_BLL(entityOgrenci); //Benim BLL'de yazdığım şarta uyuyorsa ekleem işlemini yapacak.

        }
    }
}