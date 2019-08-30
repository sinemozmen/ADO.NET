using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace _01_Giris
{
    class SqlConnectionTanim
    {
        //  SqlConnection//F12
        // connectionString : Hangi sunucuya hangi sifre ile vs baglandigini gosterir
        // https://www.connectionstrings.com/
        //protected override void Dispose(bool disposing);Islem bitince ramdeki datanin silinmesi icin kullanilir.
        //ConnectionState : baglanti durumunu gosterir.
        public SqlConnectionTanim()
        {
            //1-Constructor icine
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;user id = sa; password=12345");//local server'da default instance'a baglanir.
                                                                                                              //2-Property icine
            SqlConnection cnn2 = new SqlConnection();
            cnn2.ConnectionString = "server=.;database=Northwind;user id = sa; password=12345";
  
            //4-class icine
            SqlConnection cnn3 = new SqlConnection(Bagci.BaglantiCumlecigi);
            SqlConnection cnn4 = new SqlConnection();
            cnn4.ConnectionString = Bagci.BaglantiCumlecigi;
            //3-app.config icine
            //referanslara system configiration ekle 
            SqlConnection cnn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["BaglantiCumlecigim"].ConnectionString);

            SqlConnection cnn6 = new SqlConnection();
             cnn6.ConnectionString = ConfigurationManager.ConnectionStrings["BaglantiCumlecigim"].ConnectionString;

            if(cnn.State!=System.Data.ConnectionState.Open)
            {
                cnn.Open();
            }
            SqlTransaction transaction = cnn.BeginTransaction(IsolationLevel.ReadUncommitted);//begin tran
            try
            {
                //sorgulari burada calistir
                transaction.Commit();//commit tran
            }
            catch (Exception)
            {
                transaction.Rollback();
                //mesaj goster
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();//ilgili connection nesnesini ram'den temizleriz.
            }

        }





    }


}
