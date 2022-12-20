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
using System.Windows.Forms.VisualStyles;

namespace Otobus_Bilet_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private SqlConnection con =
            new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True");
        private void BtnBiletBul_Click(object sender, EventArgs e)
        {
            if (CmbKalkis.Text == "" || CmbVaris.Text == "" || CmbKalkis.Text == String.Empty || CmbVaris.Text == String.Empty)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                var result = MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
            }
            else
            {
                try
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter(
                            "Select SeferKodu as [Sefer Kodu] , kalkis as Kalkış, varis as Varış,Tarih,Fiyat from Seferler where kalkis = '" + CmbKalkis.Text + "'  and varis = '" + CmbVaris.Text + "' and tarih = '" + DtpTarih.Text + "'  ",
                            con);
                    //da.SelectCommand.Parameters.AddWithValue("@p1", CmbKalkis.Text);
                    //da.SelectCommand.Parameters.AddWithValue("@p2", CmbVaris.Text);
                    //da.SelectCommand.Parameters.AddWithValue("@p3", DtpTarih.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    panel2.Visible = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Her hangi bir veri bulunmadı.",
                        "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }
            
            this.Size = new Size(1104, 363);
        }
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form2 frm2 = new Form2();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            frm2.SeferKodu = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm2.kalkis = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm2.varis = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm2.tarih = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm2.Show();
            this.Hide();



        }

        private string v;
        private void PbReplce_Click(object sender, EventArgs e)
        {
            v = CmbKalkis.Text;
            CmbKalkis.Text = CmbVaris.Text;
            CmbVaris.Text = v;
        }
    }
}
