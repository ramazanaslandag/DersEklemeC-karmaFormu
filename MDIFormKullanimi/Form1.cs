using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //char[] d = { '-' };
            //this.Text=this.Text.Trim(d);


        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniDersFormu frm = new YeniDersFormu();
            //yeni açılacak formun ana forma ait bir child form olduğunu belirtmemiz gerekir.
            frm.MdiParent = this;//oluşturulan form Ana form içerisine aktarılsın
            //frm.ShowDialog(); bağımsız formlarda kullanılabilir ancak MDIParent ya da MDIChild durumlarında kullanılamaz.
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sınıfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniSinifFormu frm = new YeniSinifFormu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniEgitmenFormu frm = new YeniEgitmenFormu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DersDuzenlemeFormu frm = new DersDuzenlemeFormu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eğitmenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sınıfToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SinifDuzenlemeFormu frm = new SinifDuzenlemeFormu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hocaDersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HocaDersFormu frm = new HocaDersFormu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
