using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBN
{
    public partial class ftableKhoa : Form
    {
        private string username;
        public ftableKhoa(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkhoacapcuu_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thồnTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftableAccount f = new ftableAccount(username);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnkhoacapcuu_Click_1(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(10);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void kiểmTraGiườngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fgiuongtrong f = new fgiuongtrong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRHM_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(11);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnungbuou_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(12);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btntieuhoa_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(13);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCTCH_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(14);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnthankinh_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(15);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnkhoatimmach_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(16);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTMH_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(17);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnkhoamat_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(18);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnkhoadalieu_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(21);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btntruyennhiem_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(22);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnkhoanhi_Click(object sender, EventArgs e)
        {
            fDSBN f = new fDSBN(20);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchBệnhNhânCũToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bệnhNhânCũToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*fBenhNhanCu f = new fBenhNhanCu();
            this.Hide(); f.ShowDialog();
            this.Show();*/
            fBenhnhancu f= new fBenhnhancu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBenhvaDV f = new fBenhvaDV();
            this.Hide(); f.ShowDialog();
            this.Show();
        }
    }
}
