using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimiz.Data
{
    public class Siparis
    {
        public Siparis()
        {
            siparisDetaylar = new List<SiparisDetay>();
            AcilisZamani = DateTime.Now;
        }

        //bu constructoru cagırırsa this ile önce parametresizi cagır dedik.Bu sayede                      parametresiz const. içindekileri copy-paste amele yöntemi yapmamıs                                 olduk
        public Siparis(int masaNo) : this()
        {
            MasaNo = masaNo;
        }

        public int MasaNo { get; set; }

        public DateTime? AcilisZamani { get; set; } // soru işareti nullable yapıyor

        public DateTime? KapanisZamani { get; set; }

        public SiparisDurum Durum { get; set; }

        public decimal OdenenTutar { get; set; }

        public List<SiparisDetay> siparisDetaylar { get; set; }

        public string ToplamTutarTL
        {
            get
            {
                return string.Format("{0:0.00}₺", ToplamTutar());
            }
        }
      
        public decimal ToplamTutar()
        {
            return siparisDetaylar.Sum(x => x.Tutar());
        }

    }
}
