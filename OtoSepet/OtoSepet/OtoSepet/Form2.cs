using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoSepet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SCD6FMP;Initial Catalog=OtoDatabase;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        //SqlDataReader reader = new SqlDataReader();
        DataSet ds = new DataSet();


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoDatabaseDataSet5.Siniflar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siniflarTableAdapter.Fill(this.otoDatabaseDataSet5.Siniflar);
            // TODO: Bu kod satırı 'otoDatabaseDataSet4.Vitesler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.viteslerTableAdapter.Fill(this.otoDatabaseDataSet4.Vitesler);
            // TODO: Bu kod satırı 'otoDatabaseDataSet3.Yakitlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yakitlarTableAdapter.Fill(this.otoDatabaseDataSet3.Yakitlar);
            // TODO: Bu kod satırı 'otoDatabaseDataSet1.Markalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.markalarTableAdapter.Fill(this.otoDatabaseDataSet1.Markalar);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //EKLE - INSERT

            try
            {
                SqlCommand eklekomut = new SqlCommand();
                baglanti.Open();
                eklekomut.Connection = baglanti;
                eklekomut.CommandType = CommandType.StoredProcedure;
                eklekomut.CommandText = "sp_AracEkle";
                eklekomut.Parameters.Add("@plaka", SqlDbType.VarChar, 10);
                eklekomut.Parameters.Add("@marka", SqlDbType.VarChar, 30);
                eklekomut.Parameters.Add("@model", SqlDbType.VarChar, 100);
                eklekomut.Parameters.Add("@yil", SqlDbType.SmallInt);
                eklekomut.Parameters.Add("@yakitturu", SqlDbType.Char, 1);
                eklekomut.Parameters.Add("@vites", SqlDbType.Char, 1);
                eklekomut.Parameters.Add("@motorhacmi", SqlDbType.SmallInt);
                eklekomut.Parameters.Add("@fiyat", SqlDbType.Decimal, 10);
                eklekomut.Parameters.Add("@sinif", SqlDbType.Char, 1);
                //textboxdan veri alalım
                eklekomut.Parameters["@plaka"].Value = textBox1.Text;
                eklekomut.Parameters["@marka"].Value = comboBox1.Text;
                eklekomut.Parameters["@model"].Value = textBox2.Text;
                eklekomut.Parameters["@yil"].Value = Convert.ToInt32(textBox5.Text);
                eklekomut.Parameters["@yakitturu"].Value = comboBox2.Text;
                eklekomut.Parameters["@vites"].Value = comboBox3.Text;
                eklekomut.Parameters["@motorhacmi"].Value = Convert.ToInt32(textBox3.Text);
                eklekomut.Parameters["@fiyat"].Value = Convert.ToDecimal(textBox4.Text);
                eklekomut.Parameters["@sinif"].Value = comboBox5.Text;
                //komutu çaılıştır
                eklekomut.ExecuteNonQuery();
                MessageBox.Show("Kayıt eklendi");
                //bağlantıyı kapat
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata" + ex);
            }


        }


        //Sadece Rakam Girişi

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
