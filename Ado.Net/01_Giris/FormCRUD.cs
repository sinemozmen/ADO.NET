using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Giris
{
    public partial class FormCRUD : Form
    {
        SqlConnection _cnn;

        public FormCRUD()
        {
            InitializeComponent();
            // _cnn = new SqlConnection("server=176.43.149.228,1433;database=Northwind;user id = sa;password =Alaf9090");
            _cnn = new SqlConnection("server=.;database=Northwind;Integrated security=true");
            this.Load += SelectKategorileriYukle;
            this.Load += UpdateKategoriDoldur;
            this.Load += DeleteKategoriDoldur;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                return;
            }
            #endregion
            //SqlConnection cnn = new SqlConnection("server=.;database=Northwind;Trusted_Connection=true");
            // SqlConnection cnn = new SqlConnection("Server=localhost;Database=Northwind;Integrated Security=true;");

            SqlCommand cmd = new SqlCommand("insert into Categories(CategoryName,Description) values (@CategoryName,@Description)", _cnn);
            // komuta ilk connection verilmesi gerekir.
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {   
                int ess = cmd.ExecuteNonQuery();//insert oldugu icin bir resultset dondurmeyecek bu durumda ExevuteReader ya da Scalar kullanilmasina gerek yoktur
                txtEtkilenenSatirSayisi.Text = ess.ToString();

                if (ess > 0)
                {
                  //  MessageBox.Show("Kayit basarilidir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata nedeniyle islem yapilamadi..");
            }

            _cnn.Close();

        }

        private void btnCiroHesapla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select sum(UnitPrice*Quantity*(1-Discount)) from [Order Details] ", _cnn);
            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                double ciro = (double)cmd.ExecuteScalar();
                txtCiro.Text = ciro.ToString();
                MessageBox.Show("Ciro Hesaplandi");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ciro Hesaplanmadi");
            }
            finally
            {
                _cnn.Close();
            }
        }

        private void SelectKategorileriYukle(object sender, EventArgs e)
        {
            SqlCommand cmdCategori = new SqlCommand("select*from Categories", _cnn);
            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                SqlDataReader reader = cmdCategori.ExecuteReader();
                if (reader.HasRows)
                {
                    List<Category> kategoriler = new List<Category>();
                    while (reader.Read())//Get Next gibi calisir.Boolean
                    {
                        Category ctg = new Category();
                        ctg.Id = (int)reader["CategoryID"];
                        ctg.Ad = reader["CategoryName"].ToString();
                        ctg.Aciklama = reader["Description"].ToString();
                        kategoriler.Add(ctg);

                    }
                    reader.Close();

                    cmbKategoriler.ValueMember = "Id";
                    cmbKategoriler.DisplayMember = "Ad";
                    cmbKategoriler.DataSource = kategoriler;
   

                    //  MessageBox.Show("Veri Yüklendi");
                }
                else
                {
                    MessageBox.Show("Yüklenecek veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }
            finally
            {
                _cnn.Close();
            }
        }

        private void DeleteKategoriDoldur(object sender,EventArgs e)
        {
            SqlCommand cmdCategori = new SqlCommand("select*from Categories", _cnn);
            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                SqlDataReader reader = cmdCategori.ExecuteReader();
                if (reader.HasRows)
                {
                    List<Category> kategoriler = new List<Category>();
                    while (reader.Read())//Get Next gibi calisir.Boolean
                    {
                        Category ctg = new Category();
                        ctg.Id = (int)reader["CategoryID"];
                        ctg.Ad = reader["CategoryName"].ToString();
                        ctg.Aciklama = reader["Description"].ToString();
                        kategoriler.Add(ctg);

                    }
                    reader.Close();

                    cmbKategoriDelete.ValueMember = "Id";
                    cmbKategoriDelete.DisplayMember = "Ad";
                    cmbKategoriDelete.DataSource = kategoriler;
       
                    //  MessageBox.Show("Veri Yüklendi");
                }
                else
                {
                    MessageBox.Show("Yüklenecek veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }
            finally
            {
                _cnn.Close();
            }

        }

        private void UpdateKategoriDoldur(object sender, EventArgs e)
        {
            SqlCommand cmdCategori = new SqlCommand("select*from Categories", _cnn);
            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                SqlDataReader reader = cmdCategori.ExecuteReader();
                if (reader.HasRows)
                {
                    List<Category> kategoriler = new List<Category>();
                    while (reader.Read())//Get Next gibi calisir.Boolean
                    {
                        Category ctg = new Category();
                        ctg.Id = (int)reader["CategoryID"];
                        ctg.Ad = reader["CategoryName"].ToString();
                        ctg.Aciklama = reader["Description"].ToString();
                        kategoriler.Add(ctg);

                    }
                    reader.Close();

                     cmbKategoriUpdate.ValueMember = "Id";
                     cmbKategoriUpdate.DisplayMember = "Ad";
                     cmbKategoriUpdate.DataSource = kategoriler;

                    //  MessageBox.Show("Veri Yüklendi");
                }
                else
                {
                    MessageBox.Show("Yüklenecek veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }
            finally
            {
                _cnn.Close();
            }

        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kategorisi secildiginde ürünleri getirsin

        }

        private void DeleteUrunYukle(object sender, EventArgs e)
        {
            lstSilUrun.Items.Clear();

            ListControl cmb = sender as ComboBox;//(Combobox)sender // bu durumda bu kodu sadece combobox'ta degil listbox'ta da kullanabilirim.
            //ComboBox cmb = sender as ComboBox;
            int categoryID = (int)cmb.SelectedValue;//selected value Base'i ListControl'den geliyor.

            SqlCommand cmd = new SqlCommand("select*from products where categoryID=@categoryID", _cnn);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //todo : burayı unutmaa// View->TaskList
                        Product urun = new Product();
                        urun.Id = (int)rd["productID"];
                        urun.Ad = rd["ProductName"].ToString();
                        urun.BirimFiyat = (decimal)rd["UnitPrice"];
                        urun.Stok = (short)rd["UnitsinStock"];
                        urun.SatisiDevamEdiyorMu = (bool)rd["Discontinued"];
                        lstSilUrun.Items.Add(urun);

                    }
                    rd.Close();
                    lstSilUrun.ValueMember = "Id";
                    lstSilUrun.DisplayMember = "Ad";


                    // MessageBox.Show("Veri basariyla yuklendi.");
                }
                else
                {
                    MessageBox.Show("Herhangi bir veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");

            }
            finally
            {
                _cnn.Close();
            }


        }

        public void Alafortanfoni(object sender, EventArgs e)
        {
            lstUrunler.Items.Clear();

            ListControl cmb = sender as ComboBox;//(Combobox)sender // bu durumda bu kodu sadece combobox'ta degil listbox'ta da kullanabilirim.
            //ComboBox cmb = sender as ComboBox;
            int categoryID = (int)cmb.SelectedValue;//selected value Base'i ListControl'den geliyor.

            SqlCommand cmd = new SqlCommand("select*from products where categoryID=@categoryID", _cnn);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //todo : burayı unutmaa// View->TaskList
                        Product urun = new Product();
                        urun.Id = (int)rd["productID"];
                        urun.Ad = rd["ProductName"].ToString();
                        urun.BirimFiyat = (decimal)rd["UnitPrice"];
                        urun.Stok = (short)rd["UnitsinStock"];
                        urun.SatisiDevamEdiyorMu = (bool)rd["Discontinued"];
                        lstUrunler.Items.Add(urun);

                    }
                    rd.Close();
                    // MessageBox.Show("Veri basariyla yuklendi.");
                }
                else
                {
                    MessageBox.Show("Herhangi bir veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");

            }
            finally
            {
                _cnn.Close();
            }



        }

        public void SecilenYukle(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            Product urun = (Product)lst.SelectedItem;
            txtSecilen.Text = urun.Ad + " " + urun.BirimFiyat;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int secilenID = cmbKategoriUpdate.SelectedIndex;
            if(_cnn.State!=ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {

                SqlCommand cmd = new SqlCommand("update Categories set CategoryName=@CategoryName,Description=@Description where categoryID=@categoryID", _cnn);
                cmd.Parameters.AddWithValue("@categoryID", secilenID+1);
                cmd.Parameters.AddWithValue("@CategoryName", txtUpdateKategoriAdi.Text);
                cmd.Parameters.AddWithValue("@Description", txtUpdateTanim.Text);

                cmd.ExecuteNonQuery();

                cmbKategoriUpdate.DataSource = null;

                if (_cnn.State != ConnectionState.Open)
                {
                    _cnn.Open();
                }
                SqlCommand cmd2 = new SqlCommand("select*from Categories" , _cnn);
                
                List<Category> kategoriler = new List<Category>();
                SqlDataReader rd = cmd2.ExecuteReader();

                while (rd.Read())
                {
                    Category kategori = new Category();
                    kategori.Id = (int)rd["CategoryID"];
                    kategori.Ad = rd["CategoryName"].ToString();
                    kategori.Aciklama = rd["Description"].ToString();
                    kategoriler.Add(kategori);
                }

                cmbKategoriUpdate.ValueMember = "Id";
                cmbKategoriUpdate.DisplayMember = "Ad";
                cmbKategoriUpdate.DataSource = kategoriler;
                cmbKategoriUpdate.SelectedIndex = secilenID;


            }
            catch (Exception ex)
            {
                MessageBox.Show("hata");
              
            }
            finally
            {
                _cnn.Close();

            }

        }

        public void UpdateTextboxDoldur(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            int kategoriID =cmb.SelectedIndex;
            if(_cnn.State!=ConnectionState.Open)
            {
                _cnn.Open();

            }
            try
            {
                SqlCommand cmd = new SqlCommand("select*from Categories where CategoryID=@categoryID",_cnn);
                cmd.Parameters.AddWithValue("@categoryID", kategoriID+1);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    txtUpdateKategoriAdi.Text=sdr["CategoryName"].ToString();
                    txtUpdateTanim.Text = sdr["Description"].ToString();
                }
             
    
            }
            catch (Exception ex)
            {
          
            }
            _cnn.Close();
         
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(_cnn.State!=ConnectionState.Open)
            {

                _cnn.Open();
            }
            try
            {
                string secilenUrunAdi = lstSilUrun.SelectedItem.ToString();
                int secilenIndex = lstSilUrun.SelectedIndex;
                SqlCommand cmd = new SqlCommand("delete  p from Products p left join [Order Details] od on od.ProductID=p.ProductID where ProductName=@ProductName", _cnn);
                cmd.Parameters.AddWithValue("@ProductName", secilenUrunAdi);
                cmd.ExecuteNonQuery();


                lstSilUrun.Items.RemoveAt(secilenIndex);
            }
            catch (Exception ex )
            {
                MessageBox.Show("haat");
            }
            finally
            {
                _cnn.Close();
            }
    
        }

        private void GrpDelete_Enter(object sender, EventArgs e)
        {

        }
    }
}
