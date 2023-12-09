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

namespace QLBN
{
    public partial class fBenhnhancu : fDSBN
    {
        private ListBenhNhan ListBenhNhan;
        private string LBN;
        public fBenhnhancu(int Makhoa) : base(Makhoa)
        {
            InitializeComponent();
            LoadBenhNhan();
            this.ListBenhNhan = new ListBenhNhan();
        }
        public fBenhnhancu()
        {
            InitializeComponent();
            LoadBenhNhan();
            this.ListBenhNhan = new ListBenhNhan();
        }
        public override void HienThi()
        {
            DataGridViewRow selectedRow = dtgvds.CurrentRow;
            string LBN = selectedRow.Cells["LBN"].Value.ToString();
            string NK = selectedRow.Cells["NgayNhapVien"].Value.ToString();
            if (LBN == "0")
            {
                NgayNhapVien.Visible = true;
                NgayRaVien.Visible = true;
                NgayNhapVien.Visible = true;
                label7.Visible = true;
                ListBenhNhan.LoadDataFromSelectedRow(dtgvds, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
            }
            else
            {
                label5.Text = "Ngày khám";
                label7.Visible = false;               
                NgayNhapVien = NgayNhapVien;
                ListBenhNhan.LoadDataFromSelectedRow(dtgvds, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
                NgayRaVien.Visible = false;
            }
        }
            
        public override void LoadBenhNhan()
        {           
            btnHD.Text = "Xem lại hoá đơn";
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM dbo.Benhnhancu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgvds.DataSource = dataTable;
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            
        }
        public override void HoaDon()
        {
            fHoadoncu f = new fHoadoncu(txbid.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            LoadBenhNhan();
        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
           
        }
        public override void TimKiem()
        {
            if (string.IsNullOrEmpty(txbTK.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã bệnh nhân để thực hiện tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.Benhnhancu WHERE MaBenhNhan=@id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", txbTK.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();

                    if (dataTable.Rows.Count > 0)
                    {
                        dtgvds.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân với mã này.", "Thông báo");
                    }
                }
            }
        }
    }
}
