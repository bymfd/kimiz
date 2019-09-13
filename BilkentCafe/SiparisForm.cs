using BilkentCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilkentCafe
{
    public partial class SiparisForm : Form
    {
        KafeVeri db;
        Siparis siparis;
        BindingList<SiparisDetay> blSiparisDetaylar;
        public SiparisForm(KafeVeri kafeVeri, Siparis siparis)
        {
            db = kafeVeri;
            this.siparis = siparis;
            blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);

            blSiparisDetaylar.ListChanged += BlSiparisDetaylar_ListChanged;



            InitializeComponent();

            Text = "Masa " + siparis.MasaNo;
            lblMasaNo.Text = string.Format("{0:00}", siparis.MasaNo);

            cboUrunler.DataSource = db.Urunler;
            dgvSiparisDetaylar.DataSource = blSiparisDetaylar;
            lblOdemeTutari.Text = siparis.ToplamTutarTL;

        }

        private void BlSiparisDetaylar_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void btnSiparisDetayEkle_Click(object sender, EventArgs e)
        {
            Urun secili = (Urun)cboUrunler.SelectedItem;
            SiparisDetay sd = new SiparisDetay
            {
                UrunAd = secili.UrunAd,
                BirimFiyat = secili.BirimFiyat,
                Adet= (int)nudUrunAdet.Value
            };
            blSiparisDetaylar.Add(sd);


        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
