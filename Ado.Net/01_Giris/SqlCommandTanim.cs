using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Giris
{
    class SqlCommandTanim
    {
        public SqlCommandTanim()
        { int id = 5;
            SqlConnection cnn = new SqlConnection("server=.;database=Northwind;user id = sa; password=12345");

            //SqlCommand//F12
            SqlCommand cmd = new SqlCommand("select*from Products where productID="+id, cnn);
          
            cmd.Parameters.AddWithValue("@ProductID", 5);
            SqlCommand cmd2 = new SqlCommand("select*from Products where productID=@productID" + id, cnn);
            cmd.CommandType = CommandType.StoredProcedure;//select ile baslayamam
            // cmd.CommandType  default degeri text'tir.
           // cmd.CommandTimeout;

            if (cnn.State != ConnectionState.Open) 
            {
                cnn.Open();
            }
            try
            {
                //  cmd.ExecuteNonQuery();//etkilenen satir sayisi
                // cmd.ExecuteScalar();//result ekranindaki ilk hucreyi doner
                // cmd.ExecuteReader();//result ekranini doner
                int etkilenenSatirSayisi = cmd.ExecuteNonQuery();//etkilenen satir sayisi
                decimal deger = (decimal)cmd.ExecuteScalar();
                //decimal dondugunu farzedelim)
                SqlDataReader rd = cmd.ExecuteReader();
            }
            catch (global::System.Exception)
            {
                throw;
            }

        }




    }
}
