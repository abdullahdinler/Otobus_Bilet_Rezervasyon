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

namespace Otobus_Bilet_Rezervasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private SqlConnection con =
            new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True");

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtSeferKodu.Text == "" || TxtKalis.Text == "" || TxtSeferKodu.Text == String.Empty ||
                TxtKalis.Text == String.Empty)
            {
                TxtSeferKodu.ForeColor = Color.Red;
                TxtKalis.ForeColor = Color.Red;
                var result = MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    TxtSeferKodu.ForeColor = Color.Black;
                    TxtKalis.ForeColor = Color.Black;
                }
            }
            else
            {
                con.Open();
                SqlCommand com =
                    new SqlCommand(
                        "insert into Seferler (seferkodu,kalkis,varis,tarih,fiyat) values(@p1,@p2,@p3,@p4,@p5)",
                        con);
                com.Parameters.AddWithValue("@p1", TxtSeferKodu.Text);
                com.Parameters.AddWithValue("@p2", TxtKalis.Text);
                com.Parameters.AddWithValue("@p3", TxtVaris.Text);
                com.Parameters.AddWithValue("@p4", DtpTarih.Text);
                com.Parameters.AddWithValue("@p5", TxtFiyat.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(TxtSeferKodu.Text + " Kodlu sefer başarılı bir şekilde eklendi.", "Bigi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com =
                new SqlCommand(
                    "Update Seferler SET seferkodu = @p1, kalkis = @p2, varis = @p3, tarih = @p4, fiyat = @p5 where seferkodu = @p1",
                    con);
            com.Parameters.AddWithValue("@p1", TxtSeferKoduDuzenle.Text);
            com.Parameters.AddWithValue("@p2", TxtKalkisDuzenle.Text);
            com.Parameters.AddWithValue("@p3", TxtVarisDuzenle.Text);
            com.Parameters.AddWithValue("@p4", DtpTarihDuzenle.Text);
            com.Parameters.AddWithValue("@p5", TxtFiyatDuzenle.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(TxtSeferKoduDuzenle.Text + " Kodlu sefer başarılı bir şekilde güncelendi.", "Bigi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DatGridList("seferler", dataGridView1);
            DatGridList("Yolcular", dataGridView2);
        }

        private void DatGridList(string tabloadi, DataGridView dataismi)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tabloadi +"", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataismi.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
             
            TxtSeferKoduDuzenle.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKalkisDuzenle.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtVarisDuzenle.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            DtpTarihDuzenle.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtFiyatDuzenle.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
