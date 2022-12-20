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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string kalkis;
        public string varis;
        public string tarih;
        public string SeferKodu;
        public string cinsiyet;

        private SqlConnection con =
            new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True");
        private void Cinsiyet(Button id)
        {

            DialogResult result = MessageBox.Show("Cinsiyetiniz Erkek ise 'Yes' Kadın ise 'No' seçin",
                "Cinsiyet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                id.BackColor = Color.LightBlue;
                cinsiyet = "Erkek";
            }

            if (result == DialogResult.No)
            {
                id.BackColor = Color.PaleVioletRed;
                cinsiyet = "Kadın";
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblKalkıs.Text = kalkis;
            LblVaris.Text = varis;
            LblTarih.Text = tarih;
            LblSeferKodu.Text = SeferKodu;

            DoluBos(Btn1, "1");
            DoluBos(Btn2, "2");
            DoluBos(Btn3, "3");
            DoluBos(Btn4, "4");
            DoluBos(Btn5, "5");
            DoluBos(Btn6, "6");
            DoluBos(Btn7, "7");
            DoluBos(Btn8, "8");
            DoluBos(Btn9, "9");
            DoluBos(Btn10, "10");
            DoluBos(Btn11, "11");
            DoluBos(Btn12, "12");
            DoluBos(Btn13, "13");
            DoluBos(Btn14, "14");
            DoluBos(Btn15, "15");
            DoluBos(Btn16, "16");
            DoluBos(Btn17, "17");
            DoluBos(Btn18, "18");
            DoluBos(Btn19, "19");
            DoluBos(Btn20, "20");
            DoluBos(Btn21, "21");
            DoluBos(Btn22, "22");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn1.Text;
            Cinsiyet(Btn1);
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn2.Text;
            Cinsiyet(Btn2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn3.Text;
            Cinsiyet(Btn3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn4.Text;
            Cinsiyet(Btn4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn5.Text;
            Cinsiyet(Btn5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn6.Text;
            Cinsiyet(Btn6);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn7.Text;
            Cinsiyet(Btn7);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn8.Text;
            Cinsiyet(Btn8);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn9.Text;
            Cinsiyet(Btn9);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn10.Text;
            Cinsiyet(Btn10);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn11.Text;
            Cinsiyet(Btn11);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn12.Text;
            Cinsiyet(Btn12);
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn13.Text;
            Cinsiyet(Btn13);
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn14.Text;
            Cinsiyet(Btn14);
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn15.Text;
            Cinsiyet(Btn15);
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn16.Text;
            Cinsiyet(Btn16);
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn17.Text;
            Cinsiyet(Btn17);
        }

        private void Btn18_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn18.Text;
            Cinsiyet(Btn18);
        }

        private void Btn19_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn19.Text;
            Cinsiyet(Btn19);
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn20.Text;
            Cinsiyet(Btn20);
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn21.Text;
            Cinsiyet(Btn21);
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            LblKoltuk.Text = Btn22.Text;
            Cinsiyet(Btn22);
        }

        
        private void DoluBos(Button id,string koltuk)
        {
            con.Open();
            SqlCommand com = new SqlCommand(
                "Select Y.Cinsiyet,y.KoltukNo from Seferler as S inner join Yolcular as Y on Y.SeferKodu = S.SeferKodu WHERE S.SeferKodu = @p1 and Y.KoltukNo = @p2",
                con);
            com.Parameters.AddWithValue("@p1", LblSeferKodu.Text);
            com.Parameters.AddWithValue("@p2", koltuk);
            com.ExecuteNonQuery();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == "Erkek")
                {
                    id.BackColor = Color.Aqua;
                    id.Enabled = false;

                }
                if (dr[0].ToString() == "Kadin")
                {
                    id.BackColor = Color.Pink;
                    id.Enabled = false;
                }
            }
            dr.Close();
            con.Close();
        }


        private void BtnRezerveEt_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "" || TxtTc.Text == "" || TxtCep.Text == "" || TxtTc.Text == String.Empty || TxtAdSoyad.Text == String.Empty)
            {
                label24.ForeColor = Color.Red;
                label17.ForeColor = Color.Red;
                label19.ForeColor = Color.Red;
                var result = MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    label24.ForeColor = Color.Black;
                    label17.ForeColor = Color.Black;
                    label19.ForeColor = Color.Black;
                }
            }
            else
            {
                con.Open();
                SqlCommand com =
                    new SqlCommand(
                        "insert into Yolcular (seferkodu,AdSoyad,tc,cinsiyet,emil,telefon,koltukno) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",
                        con);
                com.Parameters.AddWithValue("@p1", SeferKodu);
                com.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
                com.Parameters.AddWithValue("@p3", TxtTc.Text);
                com.Parameters.AddWithValue("@p4", cinsiyet);
                com.Parameters.AddWithValue("@p5", TxtMail.Text);
                com.Parameters.AddWithValue("@p6", TxtCep.Text);
                com.Parameters.AddWithValue("@p7", LblKoltuk.Text);
                com.ExecuteNonQuery();
                con.Close();
                var result = MessageBox.Show("Rezervasyon başarılı bir şekilde alındı. Lütfen kalkış saatinden önce " + kalkis + " otagarında  hazır olun.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
