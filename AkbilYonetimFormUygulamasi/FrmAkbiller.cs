using AkbilYonetimFormUygulamasi.Entities;
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

namespace AkbilYonetimFormUygulamasi
{
    public partial class FrmAkbiller : Form
    {
        string SqlConnectionString =
                    "Server=DESKTOP-OFVK2FD;Database=AkbilYonetimDB;Trusted_Connection=True;";
        // sql e bağlanacak
        SqlConnection baglanti = new SqlConnection();
        //sql komutu select * from Akbiller(Akbiller tablosundaki tüm kolonları getir)
        SqlCommand komut = new SqlCommand();
        
        private void AdonetBaglantisi()
        {
            baglanti.ConnectionString = SqlConnectionString;
            komut.Connection = baglanti;
        }

        public FrmAkbiller()
        {
            InitializeComponent();
        }

        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            //sistemdeki akbiller grid viewe gelsin..
            //dataGridViewAkbilList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //sistemdeki akbiller grid viewe gelsin.
            AkbilleriGrideGetir();
        }

        private void AkbilleriGrideGetir()
        {
            try
            {

                //string SqlConnectionString =
                //    "Server=DESKTOP-OFVK2FD;Database=AkbilYonetimDB;Trusted_Connection=True;";
                //// sql e bağlanacak
                //SqlConnection baglanti = new SqlConnection(SqlConnectionString);
                ////sql komutu select * from Akbiller(Akbiller tablosundaki tüm kolonları getir)
                //SqlCommand komut = new SqlCommand();
                //komut.Connection = baglanti; // bu sorgu hangi db'de çalışacak?
                AdonetBaglantisi();

                komut.CommandText = "select * from Akbiller where AktifMi=1";
                //komut cümlemizi yazdık

                //adaptor komutu işleyecek nesnedir.
                SqlDataAdapter adaptor = new SqlDataAdapter();
                adaptor.SelectCommand = komut; // adaptore işleyeceği komut atandı
                //Adaptor getireceği sonuçları sanal bir tabloda tutalım
                //data table classı bana tablo nesnesi veriyor.
                DataTable akbiller = new DataTable();
                //Sqlden sorgu sonucu getirdiğin bilgileri doldur.
                adaptor.Fill(akbiller);
                //datagridve kaynak atandı.
                dataGridViewAkbilList.DataSource = akbiller;



            }
            catch (Exception hata)
            {

                dataGridViewAkbilList.DataSource=null;
                //hata loglanabilir.
                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }
        }

        private void buttonAkbilEkle_Click(object sender, EventArgs e)
        {
            // akbil isimli classa ihtiyacım var
            try
            {
                Akbil yeniAkbil = new Akbil()
                {
                    AkbilSahibi = textBoxAdSoyad.Text,
                    AktifMi = true,
                    Bakiye = 0m,
                    GuncellenmeTarihi = null,
                    SeriNumarasi = textBoxSeriNumara.Text,
                };

                AdonetBaglantisi();
                string guncellenmeTarihi = yeniAkbil.GuncellenmeTarihi == null ? "null" : $"'{yeniAkbil.GuncellenmeTarihi}'";
                string aktifMi=yeniAkbil.AktifMi ? "1":"0";
                komut.CommandText = $"insert into akbiller(AkbilSahibiAdSoyad,SeriNumarasi,AktifMi,Bakiye,GuncellenmeTarihi,KayitTarihi)" +
                    $"values('{yeniAkbil.AkbilSahibi}','{yeniAkbil.SeriNumarasi}',{aktifMi},{yeniAkbil.Bakiye},{guncellenmeTarihi}," +
                    $"'{yeniAkbil.KayitTarihi.ToString("yyyy-MM-dd HH:mm:ss")}')";

                baglanti.Open();//bağlantıyı aç
                komut.ExecuteNonQuery();//ekleme yapar
                baglanti.Close();

                //Sisteme yeni akbil eklenince akbil listesi güncellenmeli
                //datagrid view içi güncellensin

                AkbilleriGrideGetir();



            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }





        }
    }
}
