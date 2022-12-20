
namespace Otobus_Bilet_Rezervasyon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBiletBul = new System.Windows.Forms.Button();
            this.PbReplce = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbVaris = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbKalkis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbReplce)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnBiletBul);
            this.panel1.Controls.Add(this.PbReplce);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DtpTarih);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CmbVaris);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmbKalkis);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 275);
            this.panel1.TabIndex = 0;
            // 
            // BtnBiletBul
            // 
            this.BtnBiletBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBiletBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBiletBul.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBiletBul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnBiletBul.Location = new System.Drawing.Point(14, 201);
            this.BtnBiletBul.Name = "BtnBiletBul";
            this.BtnBiletBul.Size = new System.Drawing.Size(214, 44);
            this.BtnBiletBul.TabIndex = 7;
            this.BtnBiletBul.Text = "Bileti Bul";
            this.BtnBiletBul.UseVisualStyleBackColor = false;
            this.BtnBiletBul.Click += new System.EventHandler(this.BtnBiletBul_Click);
            // 
            // PbReplce
            // 
            this.PbReplce.Image = ((System.Drawing.Image)(resources.GetObject("PbReplce.Image")));
            this.PbReplce.Location = new System.Drawing.Point(202, 74);
            this.PbReplce.Name = "PbReplce";
            this.PbReplce.Size = new System.Drawing.Size(25, 23);
            this.PbReplce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbReplce.TabIndex = 6;
            this.PbReplce.TabStop = false;
            this.PbReplce.Click += new System.EventHandler(this.PbReplce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yolculuk Tarihi";
            // 
            // DtpTarih
            // 
            this.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTarih.Location = new System.Drawing.Point(14, 165);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(214, 29);
            this.DtpTarih.TabIndex = 4;
            this.DtpTarih.Value = new System.DateTime(2022, 12, 15, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varış Noktası";
            // 
            // CmbVaris
            // 
            this.CmbVaris.FormattingEnabled = true;
            this.CmbVaris.Items.AddRange(new object[] {
            "Mardin",
            "İzmir",
            "İstanbul",
            "Van",
            "Dıyarbakır",
            "Ankara",
            "Şanlı Urfa",
            "Gaziantep",
            "Hakkari",
            "Şırnak"});
            this.CmbVaris.Location = new System.Drawing.Point(14, 101);
            this.CmbVaris.Name = "CmbVaris";
            this.CmbVaris.Size = new System.Drawing.Size(214, 30);
            this.CmbVaris.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalkış Noktası";
            // 
            // CmbKalkis
            // 
            this.CmbKalkis.FormattingEnabled = true;
            this.CmbKalkis.Items.AddRange(new object[] {
            "Mardin",
            "İzmir",
            "İstanbul",
            "Van",
            "Dıyarbakır",
            "Ankara",
            "Şanlı Urfa",
            "Gaziantep",
            "Hakkari",
            "Şırnak"});
            this.CmbKalkis.Location = new System.Drawing.Point(14, 38);
            this.CmbKalkis.Name = "CmbKalkis";
            this.CmbKalkis.Size = new System.Drawing.Size(214, 30);
            this.CmbKalkis.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(399, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(620, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = " Türkiye\'nin En Büyük Otobüs Bileti Sitesi ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(329, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 266);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinler Seyhat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbReplce)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbVaris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbKalkis;
        private System.Windows.Forms.Button BtnBiletBul;
        private System.Windows.Forms.PictureBox PbReplce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

