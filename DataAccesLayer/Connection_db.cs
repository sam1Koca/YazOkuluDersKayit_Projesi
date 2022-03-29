using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Bu eklediğim birinci kütüphanem.
using System.Data.SqlClient; // Bu da eklediğim ikinci kütüphanem.


namespace DataAccesLayer
{
    public class Connection_db
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }

}



/* Notes!
 * Bu projenin Türkçe karşılığı : Veri Erişim Katmanı
 * Not: Data Sınıfında SqlClient sınıfı yoktu; Gittim ve Tools > NuGet Package Manager > SqlClient Download yaparak projeme indirdim.
 * Bu projede Sorgularımı yazacağım(Delete,Update,İnsert gibi işlemler)
 * Her bir tablo için Ayrıayrı değerler oluşturacağım. ("Öğrenci" , "Öğretmen" , "BasvuruFormu" için ayrı dal oluşturacağız bu katman içerisinde.)
 * 
 */
