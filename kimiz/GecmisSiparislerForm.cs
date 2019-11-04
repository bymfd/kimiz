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
    public partial class GecmisSiparislerForm : Form
    {
        KafeVeri db;

        public GecmisSiparislerForm(KafeVeri kafeVeri)
        {
            db = kafeVeri;
            InitializeComponent();
            dgvSiparisler.DataSource = db.GecmisSiparisler
                .OrderByDescending(x => x.KapanisZamani).ToList();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
                return;
            DataGridViewRow satir = dgvSiparisler.SelectedRows[0];
            Siparis siparis = (Siparis)satir.DataBoundItem;
            dgvSiparisDetaylari.DataSource = siparis.siparisDetaylar;
        }
    }
}
