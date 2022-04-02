using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccesLayer
{
    public class DalDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand commandAll = new SqlCommand("Select * From TBLDERSLER", Connection_db.connection); // db'deki tüm öğrencileri çek.

            if (commandAll.Connection.State != ConnectionState.Open) // Bağlantı kapalıysa aç
            {
                commandAll.Connection.Open();
            }
            SqlDataReader dataReader = commandAll.ExecuteReader();

            while (dataReader.Read()) // Okuma işlemi gerçekleştiği sürece..
            {
                EntityDers entityDers = new EntityDers();
                entityDers.İD = Convert.ToInt32(dataReader["DERSID"].ToString());
                entityDers.DERSAD = dataReader["DERSAD"].ToString();
                entityDers.MİN = int.Parse(dataReader["DERSMINKONT"].ToString());
                entityDers.MAX = int.Parse(dataReader["DERSMAKSKONT"].ToString());

                degerler.Add(entityDers);
            }
            dataReader.Close();
            return degerler;

        }
    }
}
