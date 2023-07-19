using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_BTBuoi6
{
    public partial class frmQuanLySV : Form
    {
        public frmQuanLySV()
        {
            InitializeComponent();
        }
        String strcnn = "Data Source=LAPTOP-NS5J2PUO\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        BindingSource bs = null;

        private void frmQuanLySV_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(strcnn);
            if(cnn == null )
                cnn = new SqlConnection(strcnn);
            
            SqlDataAdapter adt = new SqlDataAdapter("Select * from Student", cnn);
            SqlCommandBuilder buider = new SqlCommandBuilder(adt);
            DataSet ds = new DataSet();
            adt.Fill(ds, "Student");
            bs = new BindingSource(ds, "Student");
            txtMa.DataBindings.Add("text", bs, "StudentID");
            txtTen.DataBindings.Add("text", bs, "Fullname");
            txtDiem.DataBindings.Add("text", bs, "AverageScore");
            txtMaKhoa.DataBindings.Add("text", bs, "FacultyID");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = txtMa.Text;
            string ten = txtTen.Text;
            float diem = float.Parse(txtDiem.Text);
            string khoa = txtMaKhoa.Text;
            themSV(masv, ten, diem, khoa);
            MessageBox.Show("Thêm thành công!");
        }
        private void btnToi_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
                bs.Position++;
        }
        private void btnLui_Click(object sender, EventArgs e)
        {
            if(bs.Position > 0 )
                bs.Position--;
        }
        private void themSV(string StudentID, string FullName, float AverageScore, string FacultyID)
        {
            SqlConnection connect = new SqlConnection(strcnn);
            string query = "insert into Student(StudentID, FullName, AverageScore, FacultyID) values(@StudentID,@FullName, @AverageScore, @FacultyID)";
            SqlCommand sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.Add("StudentID", StudentID);
            sqlCommand.Parameters.Add("FullName", FullName);
            sqlCommand.Parameters.Add("AverageScore", AverageScore);
            sqlCommand.Parameters.Add("FacultyID", FacultyID);
            connect.Open();
            sqlCommand.ExecuteNonQuery();
            connect.Close();
        }
        private void XoaSV(string ma)
        {
            SqlConnection conn = new SqlConnection(strcnn);
                string query = "Delete from Student where StudentID = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            XoaSV(ma);
            MessageBox.Show("Xóa thành công!");
        }
        private void btnLuidau_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void btnVecuoi_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }
        
        
    }
}
