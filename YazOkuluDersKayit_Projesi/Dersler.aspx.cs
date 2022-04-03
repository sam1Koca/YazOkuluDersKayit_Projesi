using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccesLayer;

namespace YazOkuluDersKayit_Projesi
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa Yüklendiğinde Boş TextBoxlara veri getiriyorum.

            if (Page.IsPostBack == false)
            {
                List<EntityDers> entityDers = BusinessLogicLayer_Ders.BusinessLogicLayerDers_Listele();
                DropDownList1.DataSource = BusinessLogicLayer_Ders.BusinessLogicLayerDers_Listele();
                DropDownList1.DataTextField = "DERSAD";  // Bizim db'de gözükecek alanımız.
                DropDownList1.DataValueField = "İD";
                DropDownList1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // DERSAD'ı seçtikten sonra gelen id'yi string formatında buraya getir.

            // TextBox1.Text = DropDownList1.SelectedValue.ToString();

            EntityBasvuruForm entityBasvuru = new EntityBasvuruForm();
            entityBasvuru.BASVURUOGRTİD = int.Parse(TextBox1.Text);
            entityBasvuru.BASVURUDERSİD = int.Parse(DropDownList1.SelectedValue.ToString());

            BusinessLogicLayer_Ders.TalepEkleBLL(entityBasvuru);

        }
    }
}