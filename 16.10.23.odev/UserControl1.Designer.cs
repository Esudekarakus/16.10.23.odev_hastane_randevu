namespace _16._10._23.odev
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRandevuOlustur = new Button();
            label7 = new Label();
            label6 = new Label();
            r13 = new RadioButton();
            r15 = new RadioButton();
            r14 = new RadioButton();
            r12 = new RadioButton();
            dateRandevu = new DateTimePicker();
            comboPoliklinik = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rErkek = new RadioButton();
            rKadin = new RadioButton();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRandevuOlustur);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(r13);
            panel1.Controls.Add(r15);
            panel1.Controls.Add(r14);
            panel1.Controls.Add(r12);
            panel1.Controls.Add(dateRandevu);
            panel1.Controls.Add(comboPoliklinik);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(txtAdSoyad);
            panel1.Controls.Add(txtTc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 375);
            panel1.TabIndex = 0;
           
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(302, 149);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(141, 36);
            btnRandevuOlustur.TabIndex = 12;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 240);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Poliklinik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 272);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 11;
            label6.Text = "Tarih";
            // 
            // r13
            // 
            r13.AutoSize = true;
            r13.Location = new Point(193, 307);
            r13.Name = "r13";
            r13.Size = new Size(52, 19);
            r13.TabIndex = 10;
            r13.TabStop = true;
            r13.Text = "13:00";
            r13.UseVisualStyleBackColor = true;
            // 
            // r15
            // 
            r15.AutoSize = true;
            r15.Location = new Point(193, 344);
            r15.Name = "r15";
            r15.Size = new Size(52, 19);
            r15.TabIndex = 10;
            r15.TabStop = true;
            r15.Text = "15:00";
            r15.UseVisualStyleBackColor = true;
            // 
            // r14
            // 
            r14.AutoSize = true;
            r14.Location = new Point(82, 344);
            r14.Name = "r14";
            r14.Size = new Size(52, 19);
            r14.TabIndex = 10;
            r14.TabStop = true;
            r14.Text = "14:00";
            r14.UseVisualStyleBackColor = true;
            // 
            // r12
            // 
            r12.AutoSize = true;
            r12.Location = new Point(82, 307);
            r12.Name = "r12";
            r12.Size = new Size(52, 19);
            r12.TabIndex = 10;
            r12.TabStop = true;
            r12.Text = "12:00";
            r12.UseVisualStyleBackColor = true;
            // 
            // dateRandevu
            // 
            dateRandevu.Location = new Point(82, 266);
            dateRandevu.Name = "dateRandevu";
            dateRandevu.Size = new Size(205, 23);
            dateRandevu.TabIndex = 8;
            // 
            // comboPoliklinik
            // 
            comboPoliklinik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPoliklinik.FormattingEnabled = true;
            comboPoliklinik.Items.AddRange(new object[] { "Dermatoloji", "Endokrinoloji", "Jinokoloji", "Kardioloji", "Nöroloji", "Onkoloji", "Pediatri", "Üroloji" });
            comboPoliklinik.Location = new Point(82, 237);
            comboPoliklinik.Name = "comboPoliklinik";
            comboPoliklinik.Size = new Size(205, 23);
            comboPoliklinik.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 197);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 6;
            label5.Text = "Randevu Bilgileri";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rErkek);
            groupBox1.Controls.Add(rKadin);
            groupBox1.Location = new Point(82, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 58);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rErkek
            // 
            rErkek.AutoSize = true;
            rErkek.Location = new Point(105, 22);
            rErkek.Name = "rErkek";
            rErkek.Size = new Size(53, 19);
            rErkek.TabIndex = 1;
            rErkek.TabStop = true;
            rErkek.Text = "Erkek";
            rErkek.UseVisualStyleBackColor = true;
            // 
            // rKadin
            // 
            rKadin.AutoSize = true;
            rKadin.Location = new Point(6, 22);
            rKadin.Name = "rKadin";
            rKadin.Size = new Size(55, 19);
            rKadin.TabIndex = 0;
            rKadin.TabStop = true;
            rKadin.Text = "Kadın";
            rKadin.UseVisualStyleBackColor = true;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(82, 107);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(205, 23);
            txtTelefon.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(82, 78);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(205, 23);
            txtAdSoyad.TabIndex = 3;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(82, 52);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(205, 23);
            txtTc.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 110);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 1;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 81);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Ad-Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 52);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "TC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Hasta Bilgileri";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(497, 375);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rErkek;
        private RadioButton rKadin;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private RadioButton r13;
        private RadioButton r15;
        private RadioButton r14;
        private RadioButton r12;
        private DateTimePicker dateRandevu;
        private ComboBox comboPoliklinik;
        private Label label5;
        private Button btnRandevuOlustur;
    }
}
