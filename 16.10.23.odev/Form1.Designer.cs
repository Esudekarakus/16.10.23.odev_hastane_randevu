namespace _16._10._23.odev
{
    partial class Form1
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
            H = new TabControl();
            tabRandevuOlustur = new TabPage();
            tabRandevular = new TabPage();
            H.SuspendLayout();
            SuspendLayout();
            // 
            // H
            // 
            H.Controls.Add(tabRandevuOlustur);
            H.Controls.Add(tabRandevular);
            H.Location = new Point(0, 0);
            H.Name = "H";
            H.SelectedIndex = 0;
            H.Size = new Size(454, 438);
            H.TabIndex = 0;
            H.Tag = "";
            H.SelectedIndexChanged += H_SelectedIndexChanged;
            // 
            // tabRandevuOlustur
            // 
            tabRandevuOlustur.Location = new Point(4, 24);
            tabRandevuOlustur.Name = "tabRandevuOlustur";
            tabRandevuOlustur.Padding = new Padding(3);
            tabRandevuOlustur.Size = new Size(446, 410);
            tabRandevuOlustur.TabIndex = 0;
            tabRandevuOlustur.Text = "Randevu Oluştur";
            tabRandevuOlustur.UseVisualStyleBackColor = true;
            // 
            // tabRandevular
            // 
            tabRandevular.Location = new Point(4, 24);
            tabRandevular.Name = "tabRandevular";
            tabRandevular.Padding = new Padding(3);
            tabRandevular.Size = new Size(446, 410);
            tabRandevular.TabIndex = 1;
            tabRandevular.Text = "Randevular";
            tabRandevular.UseVisualStyleBackColor = true;
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 439);
            Controls.Add(H);
            Name = "Form1";
            Text = "Form1";
            H.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl H;
        private TabPage tabRandevuOlustur;
        private TabPage tabRandevular;
    }
}