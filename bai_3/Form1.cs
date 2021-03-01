using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                lbLopA.Items.Add(txtInput.Text);
                txtInput.Clear();
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            try
            {
                lbLopB.Items.Add(lbLopA.SelectedItems[0]);
                // không biết là dữ liệu sau khi chuyển từ A sang có xóa hay không ... 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào phần tử muốn xóa");
            }
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            try
            {
                lbLopA.Items.Add(lbLopB.SelectedItems[0]);
                // không biết là dữ liệu sau khi chuyển từ A sang có xóa hay không ... 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn vào phần tử muốn xóa");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // xóa ở đây là xóa 1 hay xóa tất cả???, xóa của A hay của B
        }
    }
}
