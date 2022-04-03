using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicLayer_Ders
    {
        public static List<EntityDers> BusinessLogicLayerDers_Listele()
        {
            return DalDers.DersListesi();
        }

        public static int TalepEkleBLL(EntityBasvuruForm form)
        {
            if (form.BASVURUOGRTİD != null && form.BASVURUDERSİD != null)
            {
                return DalDers.TalepEkle(form);
            }
            return -1;
        }
    }
}
