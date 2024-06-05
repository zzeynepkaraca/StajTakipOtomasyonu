namespace staj_takip_sistemi
{
    partial class gırısfrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gırısfrm));
            btnGirisÖgrenci = new Button();
            btnGirisÖgretmen = new Button();
            labelkullanıcıAdıögrenci = new Label();
            labelsifreögrenci = new Label();
            label3 = new Label();
            labeladögretmen = new Label();
            txtKullanıcıAdÖgrenci = new TextBox();
            txtKullanıcıAdögretmen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtÖgrenciSifre = new TextBox();
            txtÖgretmenSifre = new TextBox();
            btncıkıs3 = new Button();
            SuspendLayout();
            // 
            // btnGirisÖgrenci
            // 
            btnGirisÖgrenci.BackColor = Color.FromArgb(255, 192, 255);
            btnGirisÖgrenci.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGirisÖgrenci.Location = new Point(83, 246);
            btnGirisÖgrenci.Name = "btnGirisÖgrenci";
            btnGirisÖgrenci.Size = new Size(163, 76);
            btnGirisÖgrenci.TabIndex = 0;
            btnGirisÖgrenci.Text = "Giriş Yap";
            btnGirisÖgrenci.UseVisualStyleBackColor = false;
            btnGirisÖgrenci.Click += btnGirisÖgrenci_Click;
            // 
            // btnGirisÖgretmen
            // 
            btnGirisÖgretmen.BackColor = Color.FromArgb(255, 192, 255);
            btnGirisÖgretmen.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGirisÖgretmen.Location = new Point(437, 246);
            btnGirisÖgretmen.Name = "btnGirisÖgretmen";
            btnGirisÖgretmen.Size = new Size(163, 76);
            btnGirisÖgretmen.TabIndex = 1;
            btnGirisÖgretmen.Text = "Giriş Yap";
            btnGirisÖgretmen.UseVisualStyleBackColor = false;
            btnGirisÖgretmen.Click += btnGirisÖgretmen_Click;
            // 
            // labelkullanıcıAdıögrenci
            // 
            labelkullanıcıAdıögrenci.AutoSize = true;
            labelkullanıcıAdıögrenci.BackColor = SystemColors.ActiveBorder;
            labelkullanıcıAdıögrenci.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelkullanıcıAdıögrenci.Location = new Point(17, 109);
            labelkullanıcıAdıögrenci.Name = "labelkullanıcıAdıögrenci";
            labelkullanıcıAdıögrenci.Size = new Size(133, 23);
            labelkullanıcıAdıögrenci.TabIndex = 4;
            labelkullanıcıAdıögrenci.Text = "Kullanıcı Adı :";
            // 
            // labelsifreögrenci
            // 
            labelsifreögrenci.AutoSize = true;
            labelsifreögrenci.BackColor = SystemColors.ActiveBorder;
            labelsifreögrenci.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelsifreögrenci.Location = new Point(83, 180);
            labelsifreögrenci.Name = "labelsifreögrenci";
            labelsifreögrenci.Size = new Size(63, 23);
            labelsifreögrenci.TabIndex = 5;
            labelsifreögrenci.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(427, 177);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 7;
            label3.Text = "Şifre :";
            // 
            // labeladögretmen
            // 
            labeladögretmen.AutoSize = true;
            labeladögretmen.BackColor = SystemColors.ActiveBorder;
            labeladögretmen.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labeladögretmen.Location = new Point(357, 109);
            labeladögretmen.Name = "labeladögretmen";
            labeladögretmen.Size = new Size(133, 23);
            labeladögretmen.TabIndex = 6;
            labeladögretmen.Text = "Kullanıcı Adı :";
            // 
            // txtKullanıcıAdÖgrenci
            // 
            txtKullanıcıAdÖgrenci.Location = new Point(155, 106);
            txtKullanıcıAdÖgrenci.Name = "txtKullanıcıAdÖgrenci";
            txtKullanıcıAdÖgrenci.Size = new Size(157, 26);
            txtKullanıcıAdÖgrenci.TabIndex = 8;
            // 
            // txtKullanıcıAdögretmen
            // 
            txtKullanıcıAdögretmen.Location = new Point(496, 109);
            txtKullanıcıAdögretmen.Name = "txtKullanıcıAdögretmen";
            txtKullanıcıAdögretmen.Size = new Size(157, 26);
            txtKullanıcıAdögretmen.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(109, 49);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 11;
            label1.Text = "Öğrenci Girişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(454, 49);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 12;
            label2.Text = "Öğretmen Girişi";
            // 
            // txtÖgrenciSifre
            // 
            txtÖgrenciSifre.Location = new Point(155, 177);
            txtÖgrenciSifre.Name = "txtÖgrenciSifre";
            txtÖgrenciSifre.Size = new Size(157, 26);
            txtÖgrenciSifre.TabIndex = 13;
            txtÖgrenciSifre.UseSystemPasswordChar = true;
            // 
            // txtÖgretmenSifre
            // 
            txtÖgretmenSifre.Location = new Point(496, 175);
            txtÖgretmenSifre.Name = "txtÖgretmenSifre";
            txtÖgretmenSifre.Size = new Size(157, 26);
            txtÖgretmenSifre.TabIndex = 14;
            txtÖgretmenSifre.UseSystemPasswordChar = true;
            // 
            // btncıkıs3
            // 
            btncıkıs3.BackColor = Color.FromArgb(227, 99, 84);
            btncıkıs3.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btncıkıs3.Location = new Point(617, 12);
            btncıkıs3.Name = "btncıkıs3";
            btncıkıs3.Size = new Size(57, 28);
            btncıkıs3.TabIndex = 15;
            btncıkıs3.Text = "Çıkış";
            btncıkıs3.UseVisualStyleBackColor = false;
            btncıkıs3.Click += btncıkıs3_Click;
            // 
            // gırısfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(686, 334);
            Controls.Add(btncıkıs3);
            Controls.Add(txtÖgretmenSifre);
            Controls.Add(txtÖgrenciSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKullanıcıAdögretmen);
            Controls.Add(txtKullanıcıAdÖgrenci);
            Controls.Add(label3);
            Controls.Add(labeladögretmen);
            Controls.Add(labelsifreögrenci);
            Controls.Add(labelkullanıcıAdıögrenci);
            Controls.Add(btnGirisÖgretmen);
            Controls.Add(btnGirisÖgrenci);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gırısfrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisÖgrenci;
        private Button btnGirisÖgretmen;
        private Label labelkullanıcıAdıögrenci;
        private Label labelsifreögrenci;
        private Label label3;
        private Label labeladögretmen;
        private TextBox txtKullanıcıAdÖgrenci;
        private TextBox txtKullanıcıAdögretmen;
        private Label label1;
        private Label label2;
        private TextBox txtÖgrenciSifre;
        private TextBox txtÖgretmenSifre;
        private Button btncıkıs3;
    }
}