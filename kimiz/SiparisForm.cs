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
using System.Diagnostics;

namespace kimiz
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
            blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.siparisDetaylar);

            blSiparisDetaylar.ListChanged += BlSiparisDetaylar_ListChanged;


            InitializeComponent();

            Text = "Masa " + siparis.MasaNo;
            lblMasaNo.Text = string.Format("{0:00}", siparis.MasaNo);

            cboUrunler.DataSource = db.Urunler;
            dgvSiparisDetaylar.DataSource = blSiparisDetaylar;
            lblOdemeTutari.Text = siparis.ToplamTutarTL;

            MasaNolariYukle();

        }

        private void MasaNolariYukle()
        {
            cboMasaNolar.Items.Clear();

            for (int i = 1;  i <= 50; i++)
            {
                if (!db.MasaDoluMu(i) || i == siparis.MasaNo)
                {
                    cboMasaNolar.Items.Add(i);
                }
            }
            cboMasaNolar.SelectedItem = siparis.MasaNo;
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
                Adet = (int)nudUrunAdet.Value
            };

            blSiparisDetaylar.Add(sd);
           
            
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
        //Bu pencereyi kapat
            Close();
            
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bu siparişi iptal etmek istediğinize emin misiniz?",
                "Sipariş İptal Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

            if (dr == DialogResult.Yes)
            {
            db.MasayiKapat(siparis.MasaNo, SiparisDurum.Iptal);
            Close();
            }
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               siparis.ToplamTutarTL + " tahsil edildiyse sipariş kapatılacaktır. Onaylıyor musunuz?",
               "Ödeme Alındı Onayı",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2
               );

            if (dr == DialogResult.Yes)
            {
                db.MasayiKapat(siparis.MasaNo, SiparisDurum.Odendi);

                Close();
            }
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            int hedefMasaNo = (int)cboMasaNolar.SelectedItem;
            int kaynakMasaNo = siparis.MasaNo;

            if (hedefMasaNo == siparis.MasaNo)
                return;

            //Taşımaya başla
            siparis.MasaNo = hedefMasaNo;         
            Text = "Masa " + siparis.MasaNo;
            lblMasaNo.Text = string.Format("{0:00}", siparis.MasaNo);

            ((Form1)Owner).MasaTasi(kaynakMasaNo, hedefMasaNo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (System.IO.StreamWriter  file =
         new System.IO.StreamWriter(@"yazdir.txt",false))
            {
               
             

                file.WriteLine(" ---şirket ismi----");
                file.WriteLine("Masa No: "+siparis.MasaNo); //masano
                 //file.WriteLine(siparis.siparisDetaylar.Count);//toplM Kalem
                file.WriteLine("--- Masa Detay : ---");
                file.WriteLine(" |  Ürün | Fiyat| Adet");
                string lines = "";
               
                for (int row = 0; row < siparis.siparisDetaylar.Count; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {

                        lines = lines + " | " + dgvSiparisDetaylar.Rows[row].Cells[col].Value.ToString();
                        if (col == 2) {

                            file.WriteLine(lines);
                            lines = "";
                        }
                    }
                   
                   
                }
                file.WriteLine(" ------------------------");
 
                 file.WriteLine(" Toplam :" +siparis.ToplamTutarTL);

            }

            var pi = new ProcessStartInfo("yazdir.txt");
            pi.UseShellExecute = true;
            pi.Verb = "print";
            var process = System.Diagnostics.Process.Start(pi);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSiparisDetaylar.SelectedRows)
            {
                dgvSiparisDetaylar.Rows.RemoveAt(row.Index);
            }
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
