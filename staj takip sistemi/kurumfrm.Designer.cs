namespace staj_takip_sistemi
{
    partial class kurumfrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kurumfrm));
            btnKurumbul = new Button();
            dataGridView1 = new DataGridView();
            textBoxkurum = new TextBox();
            labelkurumadres = new Label();
            btngeri9 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKurumbul
            // 
            btnKurumbul.BackColor = Color.FromArgb(192, 192, 255);
            btnKurumbul.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKurumbul.Location = new Point(355, 174);
            btnKurumbul.Name = "btnKurumbul";
            btnKurumbul.Size = new Size(127, 41);
            btnKurumbul.TabIndex = 3;
            btnKurumbul.Text = "Kurum Bul";
            btnKurumbul.UseVisualStyleBackColor = false;
            btnKurumbul.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(255, 192, 192);
            dataGridView1.Location = new Point(-6, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(799, 239);
            dataGridView1.TabIndex = 2;
            // 
            // textBoxkurum
            // 
            textBoxkurum.Location = new Point(314, 109);
            textBoxkurum.Margin = new Padding(3, 4, 3, 4);
            textBoxkurum.Name = "textBoxkurum";
            textBoxkurum.Size = new Size(210, 26);
            textBoxkurum.TabIndex = 4;
            // 
            // labelkurumadres
            // 
            labelkurumadres.AutoSize = true;
            labelkurumadres.Font = new Font("Times New Roman", 11.8956518F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelkurumadres.Location = new Point(185, 113);
            labelkurumadres.Name = "labelkurumadres";
            labelkurumadres.Size = new Size(123, 22);
            labelkurumadres.TabIndex = 5;
            labelkurumadres.Text = "Adres Giriniz:";
            // 
            // btngeri9
            // 
            btngeri9.BackColor = Color.FromArgb(227, 99, 84);
            btngeri9.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btngeri9.Location = new Point(683, 11);
            btngeri9.Name = "btngeri9";
            btngeri9.Size = new Size(94, 39);
            btngeri9.TabIndex = 6;
            btngeri9.Text = "Geri Dön";
            btngeri9.UseVisualStyleBackColor = false;
            btngeri9.Click += btngeri9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(235, 30);
            label1.Name = "label1";
            label1.Size = new Size(348, 21);
            label1.TabIndex = 7;
            label1.Text = "Kurumları Görüntülemek İçin Adresi Giriniz";
            // 
            // kurumfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(790, 476);
            Controls.Add(label1);
            Controls.Add(btngeri9);
            Controls.Add(labelkurumadres);
            Controls.Add(textBoxkurum);
            Controls.Add(btnKurumbul);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "kurumfrm";
            Text = "Form9";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKurumbul;
        private DataGridView dataGridView1;
        private TextBox textBoxkurum;
        private Label labelkurumadres;
        private Button btngeri9;
        private Label label1;
    }
}