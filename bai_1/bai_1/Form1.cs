using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool KiemTraGiaTriNhapVao()
        {
            if (txtID.Text == "") return false;
            if (txtName.Text == "") return false;
            if (txtLocation.Text == "") return false;
            if (rb_Nu.Checked == false || rb_Nam.Checked == false) return false;
            if (cbb_NganhHoc.Text == "") return false;

            return true;
        }

        string LayGioiTinh ()
        {
            if (rb_Nu.Checked == true)
                return rb_Nu.Text;
            else 
                return rb_Nam.Text;
        }

        void LayGioiTinh2(string gioiTinh)
        {
            if (gioiTinh == "Nu")
                rb_Nu.Checked = true;
            else
                rb_Nam.Checked = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraGiaTriNhapVao() == true)
            {
                string[] row = new string[] { txtID.Text, txtName.Text, dtp_Date.Value.Date.ToShortDateString(), LayGioiTinh(), txtLocation.Text, cbb_NganhHoc.Text };
                dgv_Data.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("vui lòng nhập lại dữ liệu");
            }


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            dgv_Data.Rows[0].Cells["mahv"].Value = txtID.Text;
        }

        private void btn_Lưu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtLocation.Text = "";
            cbb_NganhHoc.Text = "";
            rb_Nam.Checked = true;
            //dtp_Date.Value.ToString() = null; 
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_Data.Rows[e.RowIndex];
                string gioiTinh = row.Cells["gioitinh"].Value.ToString();

                //Đưa dữ liệu vào textbox
                txtID.Text = row.Cells["mahv"].Value.ToString();
                txtName.Text = row.Cells["tenhv"].Value.ToString();
                txtLocation.Text = row.Cells["diachi"].Value.ToString();
                cbb_NganhHoc.Text = row.Cells["manganh"].Value.ToString();
                LayGioiTinh2(gioiTinh);
                dtp_Date.Value = DateTime.Parse( row.Cells["ngaysinh"].Value.ToString());
            }
        }
    
    }
}
