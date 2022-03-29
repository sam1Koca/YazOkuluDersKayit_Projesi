using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer; // reference vermeyi unutma.


namespace DataAccesLayer
{
    public class DalOgrenci
    {
        public static int OgrenciAdd(EntityOgrenci entityOgrenci)
        { // int yapma sebebimiz şu: Bana geriye bir kayıt sayısı döndürecek(bunu ExecuteNonQuery ile yapacak) o yüzden.

            SqlCommand command1 = new SqlCommand("insert into TBLOGRENCİ " +
                "(OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Connection.connection);

            if (command1.Connection.State != ConnectionState.Open)
            {
                // Eğer bağlantım kapalıysa (varsayılan bağlant durumu - open'a eşit değilse içe gi ve aç)
                command1.Connection.Open(); // Bağlantımı aç.
            }
            command1.Parameters.AddWithValue("@p1", entityOgrenci.AD);
            command1.Parameters.AddWithValue("@p2", entityOgrenci.SOYAD);
            command1.Parameters.AddWithValue("@p3", entityOgrenci.NUMARA);
            command1.Parameters.AddWithValue("@p4", entityOgrenci.FOTOGRAF);
            command1.Parameters.AddWithValue("@p5", entityOgrenci.SİFRE);

            return command1.ExecuteNonQuery(); // Etkilenen kayıt sayısını geriye göndür.


        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand commandAll = new SqlCommand("Select * From TBLOGRENCİ", Connection_db.connection); // db'deki tüm öğrencileri çek.

            if (commandAll.Connection.State != ConnectionState.Open) // Bağlantı kapalıysa aç
            {
                commandAll.Connection.Open();
            }
            SqlDataReader dataReader = commandAll.ExecuteReader();

            while (dataReader.Read()) // Okuma işlemi gerçekleştiği sürece..
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();
                entityOgrenci.İD = Convert.ToInt32(dataReader["OGRID"].ToString());
                entityOgrenci.AD = dataReader["OGRAD"].ToString();
                entityOgrenci.SOYAD = dataReader["OGRSOYAD"].ToString();
                entityOgrenci.NUMARA = dataReader["OGRNUMARA"].ToString();
                entityOgrenci.FOTOGRAF = dataReader["OGRFOTOGRAF"].ToString();
                entityOgrenci.SİFRE = dataReader["OGRSİFRE"].ToString();
                entityOgrenci.BAKİYE = Convert.ToDouble(dataReader["OGRBAKİYE"].ToString());
                degerler.Add(entityOgrenci);
            }
            dataReader.Close();
            return degerler;

        }
    }
}