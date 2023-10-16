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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Hastane hastane = new Hastane();
        Hasta hasta= new Hasta();
        Hasta hastaisim=new Hasta();
        List<Hasta> hastaIsimleri= new List<Hasta>();
        

        List<Hasta> hastaBilgileri= new List<Hasta>();
        List<Hastane>hastaneBilgileri=new List<Hastane>();
        

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                hastaisim.AdSoyad = txtAdSoyad.Text;
                hasta.Tc = txtTc.Text;
                hasta.Telefon = txtTelefon.Text;
                hasta.Cinsiyet = rKadin.Checked ? rKadin.Text : rErkek.Text;

                hastane.Poliklinik = comboPoliklinik.Text;
                hastane.Tarih = dateRandevu.Value;

                if (r12.Checked)
                {
                    hastane.Saat = r12.Text;
                }
                else if (r13.Checked)
                {
                    hastane.Saat = r13.Text;

                }
                else if (r14.Checked)
                {
                    hastane.Saat = r14.Text;
                }
                else
                {
                    hastane.Saat = r15.Text;
                }
                hastaIsimleri.Add( hastaisim);
                hastaBilgileri.Add(hasta);
                hastaneBilgileri.Add(hastane);

                
                UserControl2 userControl2 = new UserControl2();
                userControl2.ListleriAl(hastaBilgileri, hastaneBilgileri, hastaIsimleri);



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex .Message);
            }
            
        }
    }
}
