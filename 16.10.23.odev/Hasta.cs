using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._23.odev
{
    public class Hasta
    {
        
       private string _id;

       public string Tc 
        {
            get { return _id; }
            set 
            {
                if (value.Trim().Length==11 )
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Tc kimlik numaranız 11 haneden oluşmalıdır.");
                }
            } 
        }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }

        public string Cinsiyet { get; set; }

    }
}
