namespace staj_takip_sistemi
{
    partial class toplukatyıteklemefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toplukatyıteklemefrm));
            dataGridView1 = new DataGridView();
            btnTopluKayıt = new Button();
            btngeri11 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, 209);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 288);
            dataGridView1.TabIndex = 0;
            // 
            // btnTopluKayıt
            // 
            btnTopluKayıt.BackColor = Color.FromArgb(240, 168, 159);
            btnTopluKayıt.Font = new Font("Times New Roman", 11.8956518F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTopluKayıt.Location = new Point(717, 117);
            btnTopluKayıt.Margin = new Padding(3, 4, 3, 4);
            btnTopluKayıt.Name = "btnTopluKayıt";
            btnTopluKayıt.Size = new Size(155, 63);
            btnTopluKayıt.TabIndex = 1;
            btnTopluKayıt.Text = "Toplu Kayıt Ekle";
            btnTopluKayıt.UseVisualStyleBackColor = false;
            btnTopluKayıt.Click += button1_Click;
            // 
            // btngeri11
            // 
            btngeri11.BackColor = Color.FromArgb(227, 99, 84);
            btngeri11.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btngeri11.Location = new Point(778, 11);
            btngeri11.Name = "btngeri11";
            btngeri11.Size = new Size(94, 39);
            btngeri11.TabIndex = 5;
            btngeri11.Text = "Geri Dön";
            btngeri11.UseVisualStyleBackColor = false;
            btngeri11.Click += btngeri11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(260, 29);
            label1.Name = "label1";
            label1.Size = new Size(281, 21);
            label1.TabIndex = 6;
            label1.Text = "Toplu Kayıt Eklemek İçin Tıklayınız";
            // 
            // toplukatyıteklemefrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 494);
            Controls.Add(label1);
            Controls.Add(btngeri11);
            Controls.Add(btnTopluKayıt);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "toplukatyıteklemefrm";
            Text = "Form11";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTopluKayıt;
        private Button btngeri11;
        private Label label1;
    }
}