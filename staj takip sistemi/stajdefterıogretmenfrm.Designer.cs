namespace staj_takip_sistemi
{
    partial class stajdefterıogretmenfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stajdefterıogretmenfrm));
            dataGridView1 = new DataGridView();
            btnOnayla = new Button();
            btnDefterıgoruntule = new Button();
            btngeri8 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-7, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1221, 239);
            dataGridView1.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(255, 192, 192);
            btnOnayla.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOnayla.Location = new Point(778, 122);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(128, 66);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += button1_Click;
            // 
            // btnDefterıgoruntule
            // 
            btnDefterıgoruntule.BackColor = Color.FromArgb(255, 192, 192);
            btnDefterıgoruntule.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDefterıgoruntule.Location = new Point(291, 122);
            btnDefterıgoruntule.Name = "btnDefterıgoruntule";
            btnDefterıgoruntule.Size = new Size(128, 66);
            btnDefterıgoruntule.TabIndex = 2;
            btnDefterıgoruntule.Text = "Defteri Görüntüle";
            btnDefterıgoruntule.UseVisualStyleBackColor = false;
            btnDefterıgoruntule.Click += button2_Click;
            // 
            // btngeri8
            // 
            btngeri8.BackColor = Color.FromArgb(227, 99, 84);
            btngeri8.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btngeri8.Location = new Point(1111, 12);
            btngeri8.Name = "btngeri8";
            btngeri8.Size = new Size(94, 39);
            btngeri8.TabIndex = 5;
            btngeri8.Text = "Geri Dön";
            btngeri8.UseVisualStyleBackColor = false;
            btngeri8.Click += btngeri8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(378, 30);
            label1.Name = "label1";
            label1.Size = new Size(452, 21);
            label1.TabIndex = 6;
            label1.Text = "Staj Defterini Görüntülemek ve Onaylamak İçin Tıklayınız";
            // 
            // stajdefterıogretmenfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1216, 466);
            Controls.Add(label1);
            Controls.Add(btngeri8);
            Controls.Add(btnDefterıgoruntule);
            Controls.Add(btnOnayla);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "stajdefterıogretmenfrm";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOnayla;
        private Button btnDefterıgoruntule;
        private Button btngeri8;
        private Label label1;
    }
}