namespace staj_takip_sistemi
{
    partial class ogrencıfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrencıfrm));
            panel1 = new Panel();
            btnKurumlar = new Button();
            btnStajdefteriOgrenci = new Button();
            btnStajdurum = new Button();
            btnStajbasvuru = new Button();
            panel2 = new Panel();
            btncıkıs2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKurumlar);
            panel1.Controls.Add(btnStajdefteriOgrenci);
            panel1.Controls.Add(btnStajdurum);
            panel1.Controls.Add(btnStajbasvuru);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 359);
            panel1.TabIndex = 0;
            // 
            // btnKurumlar
            // 
            btnKurumlar.BackColor = Color.FromArgb(255, 192, 192);
            btnKurumlar.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKurumlar.Image = (Image)resources.GetObject("btnKurumlar.Image");
            btnKurumlar.Location = new Point(0, 270);
            btnKurumlar.Margin = new Padding(3, 2, 3, 2);
            btnKurumlar.Name = "btnKurumlar";
            btnKurumlar.Size = new Size(192, 85);
            btnKurumlar.TabIndex = 7;
            btnKurumlar.Text = "\r\n                                                   \r\n                                                    Staj Yapılacak Kurumlar";
            btnKurumlar.UseVisualStyleBackColor = false;
            btnKurumlar.Click += btnKurumlar_Click;
            // 
            // btnStajdefteriOgrenci
            // 
            btnStajdefteriOgrenci.BackColor = Color.FromArgb(255, 192, 192);
            btnStajdefteriOgrenci.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnStajdefteriOgrenci.Image = (Image)resources.GetObject("btnStajdefteriOgrenci.Image");
            btnStajdefteriOgrenci.Location = new Point(0, 180);
            btnStajdefteriOgrenci.Margin = new Padding(3, 2, 3, 2);
            btnStajdefteriOgrenci.Name = "btnStajdefteriOgrenci";
            btnStajdefteriOgrenci.Size = new Size(192, 85);
            btnStajdefteriOgrenci.TabIndex = 6;
            btnStajdefteriOgrenci.Text = "\r\n                                                    \r\n                                                Staj Defteri İşlemleri";
            btnStajdefteriOgrenci.UseVisualStyleBackColor = false;
            btnStajdefteriOgrenci.Click += btnStajdefteriOgrenci_Click;
            // 
            // btnStajdurum
            // 
            btnStajdurum.BackColor = Color.FromArgb(255, 192, 192);
            btnStajdurum.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnStajdurum.Image = (Image)resources.GetObject("btnStajdurum.Image");
            btnStajdurum.Location = new Point(0, 90);
            btnStajdurum.Margin = new Padding(3, 2, 3, 2);
            btnStajdurum.Name = "btnStajdurum";
            btnStajdurum.Size = new Size(192, 85);
            btnStajdurum.TabIndex = 5;
            btnStajdurum.Text = "\r\n                                               \r\n                                                   Staj Durumu";
            btnStajdurum.UseVisualStyleBackColor = false;
            btnStajdurum.Click += btnStajdurum_Click;
            // 
            // btnStajbasvuru
            // 
            btnStajbasvuru.BackColor = Color.FromArgb(255, 192, 192);
            btnStajbasvuru.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnStajbasvuru.Image = (Image)resources.GetObject("btnStajbasvuru.Image");
            btnStajbasvuru.Location = new Point(0, 0);
            btnStajbasvuru.Margin = new Padding(3, 2, 3, 2);
            btnStajbasvuru.Name = "btnStajbasvuru";
            btnStajbasvuru.Size = new Size(192, 85);
            btnStajbasvuru.TabIndex = 4;
            btnStajbasvuru.Text = "                                                                                                                  \r\n                                               Staj Başvurusu";
            btnStajbasvuru.UseVisualStyleBackColor = false;
            btnStajbasvuru.Click += btnStajbasvuru_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btncıkıs2);
            panel2.Location = new Point(192, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 69);
            panel2.TabIndex = 1;
            // 
            // btncıkıs2
            // 
            btncıkıs2.BackColor = Color.FromArgb(227, 99, 84);
            btncıkıs2.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btncıkıs2.Location = new Point(437, 9);
            btncıkıs2.Margin = new Padding(3, 2, 3, 2);
            btncıkıs2.Name = "btncıkıs2";
            btncıkıs2.Size = new Size(62, 26);
            btncıkıs2.TabIndex = 5;
            btncıkıs2.Text = "Çıkış";
            btncıkıs2.UseVisualStyleBackColor = false;
            btncıkıs2.Click += btncıkıs2_Click;
            // 
            // ogrencıfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 359);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ogrencıfrm";
            Text = "islemPaneliÖğrenci";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnKurumlar;
        private Button btnStajdefteriOgrenci;
        private Button btnStajdurum;
        private Button btnStajbasvuru;
        private Button btncıkıs2;
    }
}