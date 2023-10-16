using System.Collections.Generic;
using System.Windows.Forms;

namespace _16._10._23.odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabRandevuOlustur.Controls.Add(new UserControl1());




        }
        Hasta hasta=new Hasta();
        Hastane hastane=new Hastane();
        List<Hasta> hastaIsimleri = new List<Hasta>();

        List<Hasta> hastaBilgileri = new List<Hasta>();
        List<Hastane> hastaneBilgileri = new List<Hastane>();

        private void H_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (H.SelectedTab == tabRandevuOlustur)
            {
                UserControl1 userControl1 = new UserControl1();
                
                tabRandevuOlustur.Controls.Add(userControl1);
            }
            else if (H.SelectedTab == tabRandevular)
            {
                UserControl2 userControl2 = new UserControl2();

                
                
                tabRandevular.Controls.Add(userControl2);

                
               

            }
        }

    }
}