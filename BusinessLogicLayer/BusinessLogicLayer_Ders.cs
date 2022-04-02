using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    class BusinessLogicLayer_Ders
    {
        public static List<EntityDers> BusinessLogicLayerDers_Listele()
        {
            return DalDers.DersListesi();

        }
    }
}
