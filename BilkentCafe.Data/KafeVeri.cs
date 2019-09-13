using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilkentCafe.Data
{
    public class KafeVeri
    {
        public KafeVeri()
        {
            Urunler = new List<Urun>();
            AktifSiparisler = new List<Siparis>();
            GecmisSiparisler = new List<Siparis>();

        }
        public List<Urun> Urunler { get; set; }
        public List<Siparis> AktifSiparisler { get; set; }
        public List<Siparis> GecmisSiparisler { get; set; }

        public bool MasaDoluMu(int masaNo)
        {
            return AktifSiparisler.Any(x => x.MasaNo == masaNo);
        }

        public Siparis SiparisBul(int masaNo)
        {
            return AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            /* Siparis sonuc = null;               yukarıdaki satır yerine yorum yazılabilir.

            foreach (var item in AktifSiparisler)
            {
                if(item.MasaNo == masaNo)
                {
                    return item;
                }
            }
            return null; */
        }

        public void MasayiKapat(int masaNo, SiparisDurum durum)
        {
            Siparis siparis = SiparisBul(masaNo);
            siparis.Durum = durum;
            siparis.KapanisZamani = DateTime.Now;
            AktifSiparisler.Remove(siparis);
            GecmisSiparisler.Add(siparis);

            if(durum == SiparisDurum.Odendi)
            {
                siparis.OdenenTutar = siparis.ToplamTutar();
            }
        }
    }
}
