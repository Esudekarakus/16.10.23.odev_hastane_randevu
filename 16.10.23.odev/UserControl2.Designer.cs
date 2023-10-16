namespace _16._10._23.odev
{
    partial class UserControl2
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
            panel2 = new Panel();
            Hastalar = new ListBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(Hastalar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 368);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Hastalar
            // 
            Hastalar.ItemHeight = 15;
            Hastalar.Location = new Point(55, 37);
            Hastalar.Name = "Hastalar";
            Hastalar.Size = new Size(347, 199);
            Hastalar.TabIndex = 0;
            Hastalar.SelectedIndexChanged += Hastalar_SelectedIndexChanged;
            
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UserControl2";
            Size = new Size(484, 368);
            Load += UserControl2_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ListBox Hastalar;
    }
}
