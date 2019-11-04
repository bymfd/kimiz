using kimiz.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimiz
{
    public partial class UrunlerForm : Form
    {
        BindingList<Urun> blUrunler;
        KafeVeri db;
        public UrunlerForm(KafeVeri kafeVeri)
        {
            db = kafeVeri;
            blUrunler = new BindingList<Urun>(db.Urunler);
            InitializeComponent();
            dgvUrunler.DataSource = blUrunler;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string urunAd = txtUrunAd.Text.Trim();
            if (urunAd == "")
            {
                MessageBox.Show("Lütfen bir ürün adı ekleyiniz");
                return;
            }
            Urun urun = new Urun
            {
                UrunAd = urunAd,
                BirimFiyat = nudBirimFiyat.Value
            };
            blUrunler.Add(urun);
            
        }
    }
}
