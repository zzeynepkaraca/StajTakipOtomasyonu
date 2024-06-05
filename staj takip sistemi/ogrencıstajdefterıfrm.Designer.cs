namespace staj_takip_sistemi
{
    partial class ogrencıstajdefterıfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrencıstajdefterıfrm));
            label1 = new Label();
            txtStajdefterıNo = new TextBox();
            label2 = new Label();
            txtStajdefterıDanısman = new TextBox();
            btnBelgeYukle = new Button();
            label3 = new Label();
            label4 = new Label();
            btnKaydet = new Button();
            btngeri5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(196, 100);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Numarası :";
            // 
            // txtStajdefterıNo
            // 
            txtStajdefterıNo.Location = new Point(364, 97);
            txtStajdefterıNo.Margin = new Padding(3, 2, 3, 2);
            txtStajdefterıNo.Name = "txtStajdefterıNo";
            txtStajdefterıNo.Size = new Size(162, 23);
            txtStajdefterıNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(218, 178);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 2;
            label2.Text = "Staj Danışmanı :";
            // 
            // txtStajdefterıDanısman
            // 
            txtStajdefterıDanısman.Location = new Point(364, 174);
            txtStajdefterıDanısman.Margin = new Padding(3, 2, 3, 2);
            txtStajdefterıDanısman.Name = "txtStajdefterıDanısman";
            txtStajdefterıDanısman.Size = new Size(162, 23);
            txtStajdefterıDanısman.TabIndex = 3;
            // 
            // btnBelgeYukle
            // 
            btnBelgeYukle.BackColor = SystemColors.ActiveBorder;
            btnBelgeYukle.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBelgeYukle.Image = (Image)resources.GetObject("btnBelgeYukle.Image");
            btnBelgeYukle.Location = new Point(209, 234);
            btnBelgeYukle.Margin = new Padding(3, 2, 3, 2);
            btnBelgeYukle.Name = "btnBelgeYukle";
            btnBelgeYukle.Size = new Size(198, 97);
            btnBelgeYukle.TabIndex = 4;
            btnBelgeYukle.Text = "                     \r\n \r\n\r\n\r\nBelge Yükle veya Gönder";
            btnBelgeYukle.UseVisualStyleBackColor = false;
            btnBelgeYukle.Click += btnBelgeYukle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(175, 54);
            label3.Name = "label3";
            label3.Size = new Size(395, 19);
            label3.TabIndex = 5;
            label3.Text = "Staj defterini yükleyin ve boş bırakılan alanları doldurun.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 216);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "Dosya Yolu Seçiniz:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveBorder;
            btnKaydet.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKaydet.Location = new Point(445, 256);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(126, 54);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += button1_Click;
            // 
            // btngeri5
            // 
            btngeri5.BackColor = Color.FromArgb(227, 99, 84);
            btngeri5.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btngeri5.Location = new Point(659, 9);
            btngeri5.Margin = new Padding(3, 2, 3, 2);
            btngeri5.Name = "btngeri5";
            btngeri5.Size = new Size(82, 31);
            btngeri5.TabIndex = 8;
            btngeri5.Text = "Geri Dön";
            btngeri5.UseVisualStyleBackColor = false;
            btngeri5.Click += btngeri5_Click;
            // 
            // ogrencıstajdefterıfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(752, 371);
            Controls.Add(btngeri5);
            Controls.Add(btnKaydet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBelgeYukle);
            Controls.Add(txtStajdefterıDanısman);
            Controls.Add(label2);
            Controls.Add(txtStajdefterıNo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ogrencıstajdefterıfrm";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStajdefterıNo;
        private Label label2;
        private TextBox txtStajdefterıDanısman;
        private Button btnBelgeYukle;
        private Label label3;
        private Label label4;
        private Button btnKaydet;
        private Button btngeri5;
    }
}