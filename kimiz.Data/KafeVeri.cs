using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimiz.Data
{
    public class KafeVeri
    {
        public KafeVeri() // propertyler ilk başta null geldiği için
                                //cons içinde oluşturarak null olmasından kurtardık
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
            foreach (var item in AktifSiparisler)
            {
                if (item.MasaNo == masaNo)
                {
                    return true;
                }
             }
            return false;
        }
        #region MASADOLUMU 2.YÖNTEM LİNQ METOTLARI
        //public bool MasaDoluMu(int masaNo)
        //{
        //    return AktifSiparisler.Any(x => x.MasaNo == masaNo); // hiç uyan var mı yoksa false varsa true
        //}
        #endregion

        public Siparis SiparisBul(int masaNo)
        {            
            foreach (var item in AktifSiparisler)
            {
                if (item.MasaNo == masaNo)
                    return item;               
            }
            return null;
        }
        #region SİPARİSBUL 2.YÖNTEM LİNQ METOTLARI
        //public Siparis SiparisBul(int masaNo)
        //{
        //    return AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
        //}
        #endregion

        public void MasayiKapat(int masaNo, SiparisDurum durum)
        {
            Siparis siparis = SiparisBul(masaNo);
            siparis.Durum = durum;
            siparis.KapanisZamani = DateTime.Now;
            AktifSiparisler.Remove(siparis);
            GecmisSiparisler.Add(siparis);

            if (durum == SiparisDurum.Odendi)
            {
                siparis.OdenenTutar = siparis.ToplamTutar();
            }
        }

    }
}
