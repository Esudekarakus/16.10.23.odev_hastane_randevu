using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._10._23.odev
{
    public partial class UserControl2 : UserControl
    {

       public void ListleriAl(List<Hasta>hastaBilgileri,List<Hastane>hastaneBilgileri,List<Hasta>hastaIsimleri)
        {


            for (int i = 0; i < hastaBilgileri.Count; i++)
            {
                string hastaAdi = hastaIsimleri[i].AdSoyad;
                string hastaneBilgisi = $"{hastaneBilgileri[i].Poliklinik}, Tarih: {hastaneBilgileri[i].Tarih}, Saat: {hastaneBilgileri[i].Saat}";

                // ListBox'a verileri ekleyin
                Hastalar.Items.Add(hastaAdi + " - " + hastaneBilgisi);
            }

        }


        public UserControl2()
        {
            InitializeComponent();

          
        }
        


        private void Hastalar_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

           




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
