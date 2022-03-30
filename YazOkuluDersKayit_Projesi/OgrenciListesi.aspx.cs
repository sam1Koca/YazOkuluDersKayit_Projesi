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
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrList = BusinessLogicLayer_Ogrenci.BusinessLogicLayer_Listele();

            Repeater1.DataSource = ogrList; // Repeater'a veri kaynağı olarak bu listeyi ver.

            Repeater1.DataBind();
            
        }
    }
}