namespace staj_takip_sistemi
{
    partial class excelfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(excelfrm));
            dataGridView1 = new DataGridView();
            btnExcel = new Button();
            btnKaydıtamamla = new Button();
            labelKonum = new Label();
            btngeri10 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-9, 244);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(827, 190);
            dataGridView1.TabIndex = 0;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(255, 192, 192);
            btnExcel.Font = new Font("Times New Roman", 11.8956518F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExcel.Location = new Point(15, 71);
            btnExcel.Margin = new Padding(3, 4, 3, 4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(110, 53);
            btnExcel.TabIndex = 1;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += button1_Click;
            // 
            // btnKaydıtamamla
            // 
            btnKaydıtamamla.BackColor = Color.FromArgb(255, 192, 192);
            btnKaydıtamamla.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKaydıtamamla.Location = new Point(15, 157);
            btnKaydıtamamla.Margin = new Padding(3, 4, 3, 4);
            btnKaydıtamamla.Name = "btnKaydıtamamla";
            btnKaydıtamamla.Size = new Size(110, 53);
            btnKaydıtamamla.TabIndex = 2;
            btnKaydıtamamla.Text = "Kaydı Tamamla";
            btnKaydıtamamla.UseVisualStyleBackColor = false;
            btnKaydıtamamla.Click += button2_Click;
            // 
            // labelKonum
            // 
            labelKonum.AutoSize = true;
            labelKonum.Font = new Font("Times New Roman", 11.8956518F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelKonum.Location = new Point(143, 103);
            labelKonum.Name = "labelKonum";
            labelKonum.Size = new Size(76, 22);
            labelKonum.TabIndex = 3;
            labelKonum.Text = "Konum:";
            // 
            // btngeri10
            // 
            btngeri10.BackColor = Color.FromArgb(227, 99, 84);
            btngeri10.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btngeri10.Location = new Point(714, 11);
            btngeri10.Name = "btngeri10";
            btngeri10.Size = new Size(94, 39);
            btngeri10.TabIndex = 4;
            btngeri10.Text = "Geri Dön";
            btngeri10.UseVisualStyleBackColor = false;
            btngeri10.Click += btngeri10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(240, 21);
            label1.Name = "label1";
            label1.Size = new Size(377, 21);
            label1.TabIndex = 5;
            label1.Text = "Excel Tablosuna Ulaşmak İçin İşlemleri Yapınız ";
            // 
            // excelfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(821, 434);
            Controls.Add(label1);
            Controls.Add(btngeri10);
            Controls.Add(labelKonum);
            Controls.Add(btnKaydıtamamla);
            Controls.Add(btnExcel);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "excelfrm";
            Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnExcel;
        private Button btnKaydıtamamla;
        private Label labelKonum;
        private Button btngeri10;
        private Label label1;
    }
}