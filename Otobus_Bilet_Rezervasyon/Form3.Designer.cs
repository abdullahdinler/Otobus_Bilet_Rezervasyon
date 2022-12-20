
namespace Otobus_Bilet_Rezervasyon
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSeferKodu = new System.Windows.Forms.TextBox();
            this.TxtVaris = new System.Windows.Forms.TextBox();
            this.TxtKalis = new System.Windows.Forms.TextBox();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtpTarihDuzenle = new System.Windows.Forms.DateTimePicker();
            this.BtnDuzenle = new System.Windows.Forms.Button();
            this.TxtFiyatDuzenle = new System.Windows.Forms.TextBox();
            this.TxtKalkisDuzenle = new System.Windows.Forms.TextBox();
            this.TxtVarisDuzenle = new System.Windows.Forms.TextBox();
            this.TxtSeferKoduDuzenle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpTarih);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.TxtKalis);
            this.groupBox1.Controls.Add(this.TxtVaris);
            this.groupBox1.Controls.Add(this.TxtSeferKodu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Sefer";
            // 
            // TxtSeferKodu
            // 
            this.TxtSeferKodu.Location = new System.Drawing.Point(7, 29);
            this.TxtSeferKodu.MaxLength = 12;
            this.TxtSeferKodu.Name = "TxtSeferKodu";
            this.TxtSeferKodu.Size = new System.Drawing.Size(170, 29);
            this.TxtSeferKodu.TabIndex = 0;
            this.TxtSeferKodu.Text = "Sefer Kodu...";
            // 
            // TxtVaris
            // 
            this.TxtVaris.Location = new System.Drawing.Point(7, 99);
            this.TxtVaris.Name = "TxtVaris";
            this.TxtVaris.Size = new System.Drawing.Size(170, 29);
            this.TxtVaris.TabIndex = 2;
            this.TxtVaris.Text = "Varış...";
            // 
            // TxtKalis
            // 
            this.TxtKalis.Location = new System.Drawing.Point(7, 64);
            this.TxtKalis.Name = "TxtKalis";
            this.TxtKalis.Size = new System.Drawing.Size(170, 29);
            this.TxtKalis.TabIndex = 3;
            this.TxtKalis.Text = "Kalkış";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(6, 168);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(170, 29);
            this.TxtFiyat.TabIndex = 4;
            this.TxtFiyat.Text = "Fiyat...";
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEkle.Location = new System.Drawing.Point(7, 203);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(169, 36);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            this.BtnEkle.Enter += new System.EventHandler(this.BtnEkle_Click);
            // 
            // DtpTarih
            // 
            this.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTarih.Location = new System.Drawing.Point(7, 133);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(170, 29);
            this.DtpTarih.TabIndex = 5;
            this.DtpTarih.Value = new System.DateTime(2022, 12, 15, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtpTarihDuzenle);
            this.groupBox2.Controls.Add(this.BtnDuzenle);
            this.groupBox2.Controls.Add(this.TxtFiyatDuzenle);
            this.groupBox2.Controls.Add(this.TxtKalkisDuzenle);
            this.groupBox2.Controls.Add(this.TxtVarisDuzenle);
            this.groupBox2.Controls.Add(this.TxtSeferKoduDuzenle);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seferi Düzenle";
            // 
            // DtpTarihDuzenle
            // 
            this.DtpTarihDuzenle.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTarihDuzenle.Location = new System.Drawing.Point(7, 133);
            this.DtpTarihDuzenle.Name = "DtpTarihDuzenle";
            this.DtpTarihDuzenle.Size = new System.Drawing.Size(170, 29);
            this.DtpTarihDuzenle.TabIndex = 5;
            this.DtpTarihDuzenle.Value = new System.DateTime(2022, 12, 15, 0, 0, 0, 0);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDuzenle.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDuzenle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDuzenle.Location = new System.Drawing.Point(7, 203);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(169, 36);
            this.BtnDuzenle.TabIndex = 9;
            this.BtnDuzenle.Text = "Düzenle";
            this.BtnDuzenle.UseVisualStyleBackColor = false;
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            this.BtnDuzenle.Enter += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // TxtFiyatDuzenle
            // 
            this.TxtFiyatDuzenle.Location = new System.Drawing.Point(6, 168);
            this.TxtFiyatDuzenle.Name = "TxtFiyatDuzenle";
            this.TxtFiyatDuzenle.Size = new System.Drawing.Size(170, 29);
            this.TxtFiyatDuzenle.TabIndex = 4;
            this.TxtFiyatDuzenle.Text = "Fiyat...";
            // 
            // TxtKalkisDuzenle
            // 
            this.TxtKalkisDuzenle.Location = new System.Drawing.Point(7, 64);
            this.TxtKalkisDuzenle.Name = "TxtKalkisDuzenle";
            this.TxtKalkisDuzenle.Size = new System.Drawing.Size(170, 29);
            this.TxtKalkisDuzenle.TabIndex = 3;
            this.TxtKalkisDuzenle.Text = "Kalkış";
            // 
            // TxtVarisDuzenle
            // 
            this.TxtVarisDuzenle.Location = new System.Drawing.Point(7, 99);
            this.TxtVarisDuzenle.Name = "TxtVarisDuzenle";
            this.TxtVarisDuzenle.Size = new System.Drawing.Size(170, 29);
            this.TxtVarisDuzenle.TabIndex = 2;
            this.TxtVarisDuzenle.Text = "Varış...";
            // 
            // TxtSeferKoduDuzenle
            // 
            this.TxtSeferKoduDuzenle.Enabled = false;
            this.TxtSeferKoduDuzenle.Location = new System.Drawing.Point(7, 29);
            this.TxtSeferKoduDuzenle.MaxLength = 12;
            this.TxtSeferKoduDuzenle.Name = "TxtSeferKoduDuzenle";
            this.TxtSeferKoduDuzenle.Size = new System.Drawing.Size(170, 29);
            this.TxtSeferKoduDuzenle.TabIndex = 0;
            this.TxtSeferKoduDuzenle.Text = "Sefer Kodu...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(212, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seferler";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(212, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 251);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yolcular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(580, 223);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 529);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtKalis;
        private System.Windows.Forms.TextBox TxtVaris;
        private System.Windows.Forms.TextBox TxtSeferKodu;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtpTarihDuzenle;
        private System.Windows.Forms.Button BtnDuzenle;
        private System.Windows.Forms.TextBox TxtFiyatDuzenle;
        private System.Windows.Forms.TextBox TxtKalkisDuzenle;
        private System.Windows.Forms.TextBox TxtVarisDuzenle;
        private System.Windows.Forms.TextBox TxtSeferKoduDuzenle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}