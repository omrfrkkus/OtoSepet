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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SCD6FMP;Initial Catalog=OtoDatabase;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        //SqlDataReader reader = new SqlDataReader();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoDatabaseDataSet.sp_AracListele' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.sp_AracListeleTableAdapter.Fill(this.otoDatabaseDataSet.sp_AracListele);
            //GETİR - SELECT
            //listele butonu
            SqlCommand listelekomut = new SqlCommand();
            baglanti.Open();
            listelekomut.Connection = baglanti;
            listelekomut.CommandType = CommandType.StoredProcedure;
            listelekomut.CommandText = "sp_AracListele";
            SqlDataAdapter da = new SqlDataAdapter(listelekomut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GETİR - SELECT
            //listele butonu
            SqlCommand listelekomut = new SqlCommand();
            baglanti.Open();
            listelekomut.Connection = baglanti;
            listelekomut.CommandType = CommandType.StoredProcedure;
            listelekomut.CommandText = "sp_AracListele";
            SqlDataAdapter da = new SqlDataAdapter(listelekomut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Silme Butonu
            
            DialogResult sonuc;
            sonuc = MessageBox.Show("Aracı kaldırmak istediğinize Emin Misiniz?", "Kaldırma işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == sonuc)
            {
                SqlCommand silkomut = new SqlCommand();
                baglanti.Open();
                silkomut.Connection = baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "sp_AracSil";

                silkomut.Parameters.Add("@plaka", SqlDbType.VarChar, 10);
                silkomut.Parameters["@plaka"].Value = textBox1.Text;

                //komutu çaılıştır
                silkomut.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi");
                //bağlantıyı kapat
                baglanti.Close();

                button2.PerformClick();
            }
            else
                MessageBox.Show("KALDIRMA İŞLEMİ İPTAL EDİLDİ");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen Satırı 
            
            int satirno;
            satirno = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[satirno].Cells[0].Value.ToString();
        }
    }
}
