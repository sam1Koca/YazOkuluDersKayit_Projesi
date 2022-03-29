using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogicLayer_Ogrenci
    {
        public static int OgrenciAdd_BLL(EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.AD != null && entityOgrenci.SOYAD != null && entityOgrenci.NUMARA != null && entityOgrenci.SİFRE != null && entityOgrenci.FOTOGRAF != null)
            {
                // Yukarıdakiler null'dan farklı ise eğer;

                return DalOgrenci.OgrenciAdd(entityOgrenci); // Bunlara bir değer atanmışmı akar ve eğer öyleyse bunları bize döndürür.
            }
            return -1; // işlemi yapma | Boş döndür
        }

        public List<EntityOgrenci> BusinessLogicLayer_Listele()
        {
            return DalOgrenci.OgrenciListesi();

        }

    }

}
