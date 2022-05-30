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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SCD6FMP;Initial Catalog=OtoDatabase;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        //SqlDataReader reader = new SqlDataReader();
        DataSet ds = new DataSet();

        private void Form3_Load(object sender, EventArgs e)
        {
            //FORM AÇILDIĞINDA COMBOBOXLARIN DOLDURULMASI VE SEÇİNİZ İBARESİ GELMESİ
            
            // TODO: Bu kod satırı 'otoDatabaseDataSet9.Markalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.markalarTableAdapter.Fill(this.otoDatabaseDataSet9.Markalar);
            // TODO: Bu kod satırı 'otoDatabaseDataSet8.Yakitlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yakitlarTableAdapter.Fill(this.otoDatabaseDataSet8.Yakitlar);
            // TODO: Bu kod satırı 'otoDatabaseDataSet7.Vitesler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.viteslerTableAdapter.Fill(this.otoDatabaseDataSet7.Vitesler);
            // TODO: Bu kod satırı 'otoDatabaseDataSet6.Siniflar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siniflarTableAdapter.Fill(this.otoDatabaseDataSet6.Siniflar);
            comboBox1.Text = "-Seçiniz-";
            comboBox2.Text = "-Seçiniz-";
            comboBox3.Text = "-Seçiniz-";
            comboBox4.Text = "-Seçiniz-";
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ARAÇ BUL
            try
            {
                SqlCommand arakomut = new SqlCommand();
                baglanti.Open();
                arakomut.Connection = baglanti;
                arakomut.CommandType = CommandType.StoredProcedure;
                arakomut.CommandText = "sp_AracBul";

                arakomut.Parameters.Add("@marka", SqlDbType.VarChar, 30);
                arakomut.Parameters.Add("@model", SqlDbType.VarChar, 100);
                arakomut.Parameters.Add("@minyil", SqlDbType.SmallInt);
                arakomut.Parameters.Add("@maxyil", SqlDbType.SmallInt);
                arakomut.Parameters.Add("@yakitturu", SqlDbType.Char, 1);
                arakomut.Parameters.Add("@vites", SqlDbType.Char, 1);
                arakomut.Parameters.Add("@motorhacmimin", SqlDbType.SmallInt);
                arakomut.Parameters.Add("@motorhacmimax", SqlDbType.SmallInt);
                arakomut.Parameters.Add("@minfiyat", SqlDbType.Decimal, 10);
                arakomut.Parameters.Add("@maxfiyat", SqlDbType.Decimal, 10);

                arakomut.Parameters["@marka"].Value = comboBox1.Text;
                arakomut.Parameters["@model"].Value = comboBox4.Text;
                arakomut.Parameters["@minyil"].Value = Convert.ToInt32(textBoxYilMin.Text);
                arakomut.Parameters["@maxyil"].Value = Convert.ToInt32(textBoxYilMax.Text);
                arakomut.Parameters["@yakitturu"].Value = comboBox2.Text;
                arakomut.Parameters["@vites"].Value = comboBox3.Text;
                arakomut.Parameters["@motorhacmimin"].Value = Convert.ToInt32(textBoxMotorMin.Text);
                arakomut.Parameters["@motorhacmimax"].Value = Convert.ToInt32(textBoxMotorMax.Text);
                arakomut.Parameters["@minfiyat"].Value = Convert.ToDecimal(textBoxFiyatMin.Text);
                arakomut.Parameters["@maxfiyat"].Value = Convert.ToDecimal(textBoxFiyatMax.Text);

                SqlDataAdapter da1 = new SqlDataAdapter(arakomut);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MARKA SEÇİMİNE GÖRE MODELLERİN COMBOBOX'A EKLENMESİ

            comboBox4.Text = "-Seçiniz-";
            string SqlText = "select DISTINCT model from Araclar where marka like '%" + comboBox1.Text+"%'";
            SqlCommand cs = new SqlCommand(SqlText, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox4.DataSource = dt;
            comboBox4.ValueMember="model";
            comboBox4.DisplayMember = "model";

        }

        //Sadece Rakam Girişleri

        private void textBoxYilMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxYilMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxMotorMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxMotorMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxFiyatMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxFiyatMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
