using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicLayer_Ogrenci
    {
        // Öğrenci için Ad yada herhangi birine boş değer girmememiz gerekmektedir.

        public static int OgrenciAdd_BLL(EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.AD != null && entityOgrenci.SOYAD != null && entityOgrenci.NUMARA != null && entityOgrenci.SİFRE != null && entityOgrenci.FOTOGRAF != null)
            {
                // Yukarıdakiler null'dan farklı ise eğer;

                return DalOgrenci.OgrenciAdd(entityOgrenci); // Bunlara bir değer atanmışmı akar ve eğer öyleyse bunları bize döndürür.
            }
            return -1; // işlemi yapma | Boş döndür
        }

        public static List<EntityOgrenci> BusinessLogicLayer_Listele()
        {
            return DalOgrenci.OgrenciListesi();

        }

        public static bool OgrenciDelete_BLL(int i)
        {
            if (i >= 0) // Bir id değeri varsa anlamına gelmektedir. 
            {
                return DalOgrenci.OgrenciDelete(i);
            }
            else
            {
                return false;
            }
        }

        public static List<EntityOgrenci> BusinessLogicLayer_DetayListele(int p)
        {
            return DalOgrenci.OgrenciDetayListesi(p);

        }
        public static bool OgrenciUpdate_BLL(EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.AD != null && entityOgrenci.SOYAD != null && 
                entityOgrenci.NUMARA != null && entityOgrenci.SİFRE != null && entityOgrenci.FOTOGRAF != null && entityOgrenci.İD > 0)
            {
                return DalOgrenci.OgrenciUpdate(entityOgrenci);
            }
            return false;
        }

    }

}
