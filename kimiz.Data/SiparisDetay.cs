using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimiz.Data
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; }

        public decimal BirimFiyat { get; set; }

        public int Adet { get; set; }

       public string TutarTL => string.Format("{0:0.00}₺", Tutar()); // 9.00₺ //prop geti bu

        public decimal Tutar() => Adet * BirimFiyat; // metodun returnu bu 
    }
}
