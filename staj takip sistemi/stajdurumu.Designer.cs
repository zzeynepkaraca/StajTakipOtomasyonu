namespace staj_takip_sistemi
{
    partial class stajdurumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stajdurumu));
            label1 = new Label();
            txtÖgrencinumarası = new TextBox();
            dataGridView1 = new DataGridView();
            btnOgrencıAra = new Button();
            btngeri6 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(165, 160);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Numarası :";
            // 
            // txtÖgrencinumarası
            // 
            txtÖgrencinumarası.Location = new Point(362, 158);
            txtÖgrencinumarası.Name = "txtÖgrencinumarası";
            txtÖgrencinumarası.Size = new Size(223, 26);
            txtÖgrencinumarası.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(890, 239);
            dataGridView1.TabIndex = 3;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // btnOgrencıAra
            // 
            btnOgrencıAra.BackColor = Color.FromArgb(255, 192, 192);
            btnOgrencıAra.Font = new Font("Times New Roman", 11.8956518F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOgrencıAra.Location = new Point(608, 155);
            btnOgrencıAra.Name = "btnOgrencıAra";
            btnOgrencıAra.Size = new Size(101, 28);
            btnOgrencıAra.TabIndex = 4;
            btnOgrencıAra.Text = "Ara";
            btnOgrencıAra.UseVisualStyleBackColor = false;
            btnOgrencıAra.Click += btnOgrencıAra_Click;
            // 
            // btngeri6
            // 
            btngeri6.BackColor = Color.FromArgb(227, 99, 84);
            btngeri6.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btngeri6.Location = new Point(781, 12);
            btngeri6.Name = "btngeri6";
            btngeri6.Size = new Size(94, 39);
            btngeri6.TabIndex = 5;
            btngeri6.Text = "Geri Dön";
            btngeri6.UseVisualStyleBackColor = false;
            btngeri6.Click += btngeri6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(134, 68);
            label2.Name = "label2";
            label2.Size = new Size(646, 21);
            label2.TabIndex = 6;
            label2.Text = "Stajınızın Onaylanıp Onaylanmadığını Görmek İçin Numaranız İle Arama Yapınmız";
            // 
            // stajdurumu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(887, 438);
            Controls.Add(label2);
            Controls.Add(btngeri6);
            Controls.Add(btnOgrencıAra);
            Controls.Add(dataGridView1);
            Controls.Add(txtÖgrencinumarası);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "stajdurumu";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtÖgrencinumarası;
        private DataGridView dataGridView1;
        private Button btnOgrencıAra;
        private Button btngeri6;
        private Label label2;
    }
}