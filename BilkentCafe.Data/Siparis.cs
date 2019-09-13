using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilkentCafe.Data
{
    public class Siparis
    {
        public Siparis()
        {
            SiparisDetaylar = new List<SiparisDetay>();
            AcilisZamani = DateTime.Now;
        }
        public Siparis(int masaNo) : this()
        {
            MasaNo = masaNo;
        }
        public int MasaNo { get; set; }

        public DateTime? AcilisZamani { get; set; }
        public DateTime? KapanisZamani { get; set; }
        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }
        public string ToplamTutarTL
        {
            get
            {
                return string.Format("{0:0.00}₺", ToplamTutar());
            }
        }
        public decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(x => x.Tutar());
        }
        public List<SiparisDetay> SiparisDetaylar { get; set; }


    }
}
