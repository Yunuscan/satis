using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using satisotomasyon.Frames;

namespace satisotomasyon
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKategoriTanimlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKategoriTanim frm = new frmKategoriTanim();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}