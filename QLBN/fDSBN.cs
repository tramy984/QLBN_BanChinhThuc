using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QLBN.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLBN
{
    public partial class fDSBN : Form
    {
        private ListBenhNhan ListBenhNhan;
        private int makhoa;
        public fDSBN()
        {
            InitializeComponent();
            LoadBenhNhan();
            LoadGB();
            this.ListBenhNhan = new ListBenhNhan();
        }
        public fDSBN(int Makhoa)
        {
            InitializeComponent();
            this.makhoa = Makhoa;
            LoadBenhNhan();
            LoadGB();
            this.ListBenhNhan = new ListBenhNhan();
        }
        void LoadGB()
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cbGB.Items.Clear();
            string query = "SELECT MaGiuong FROM dbo.Giuongbenh WHERE Status=0";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbGB.Items.Add(reader["MaGiuong"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Dataobject
        {
            public string Name { get; set; }
        }
        private void dtgvkhoacapcuu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThi();
        }
        public virtual void HienThi()
        {
            DataGridViewRow selectedRow = dtgvds.CurrentRow;
            string LBN = selectedRow.Cells["LBN"].Value.ToString();
            if (LBN == "0")
            {
                
                NgayNhapVien.Visible = true;
                NgayRaVien.Visible = true;
                ListBenhNhan.LoadDataFromSelectedRow(dtgvds, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
            }
            else
            {
                ListBenhNhan.LoadDataFromSelectedRow(dtgvds, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
                NgayNhapVien.Visible = false;
                NgayRaVien.Visible = false;
            }
            
        }
        public virtual void LoadBenhNhan()
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"SELECT * FROM dbo.Benhnhan Where MaKhoa={makhoa}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgvds.DataSource = dataTable;
        }


        private void txbBHYT_TextChanged(object sender, EventArgs e)
        {

        }



        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            LoadBenhNhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            ListBenhNhan.ThemBenhNhan(txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
            LoadBenhNhan();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListBenhNhan.XoaBenhNhan(txbid, cbGB);
            LoadBenhNhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListBenhNhan.SuaBenhNhan(txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
            LoadBenhNhan();
        }

        public void btnTK_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
        public virtual void TimKiem()
        {
            string MK = makhoa.ToString();
            ListBenhNhan.TimKiemBN(dtgvds, txbTK, MK);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HoaDon();
        }
        public virtual void HoaDon()
        {
            string GB = cbGB.Text;
            fBill f = new fBill(txbid.Text, GB);
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadBenhNhan();
        }
        private void cbLBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            NgayNhapVien.Visible = true;
            NgayRaVien.Visible = true;
            cbGB.Visible = true;
        }
    }
}
