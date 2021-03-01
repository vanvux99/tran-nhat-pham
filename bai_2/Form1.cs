using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if(txtInput.Text != "")
            {
                lb_Data.Items.Add(txtInput.Text);
                txtInput.Clear();
            }  
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lb_Data.Items)
            {
                sum += int.Parse( item.ToString());
            }

            MessageBox.Show(sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string result = "";
            List<string> list = new List<string>();
            foreach (var item in lb_Data.Items)
            {
                list.Add(item.ToString());
            }

            list.RemoveAt(list.Count - 1);
            list.RemoveAt(0);

            foreach (string item in list)
            {
                result += item + ", ";
            }
            MessageBox.Show(result);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            try
            {
                lb_Data.Items.Remove(lb_Data.SelectedItems[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn vào phần tử muốn xóa");
            }
            
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            int ressult = 0;
            string str = "";
            List<string> list = new List<string>();
            foreach (string item in lb_Data.Items)
            {
                ressult = int.Parse(item) * 2;
                list.Add(ressult.ToString());
            }

            foreach (string item in list)
            {
                str += item + ", ";
            }
            MessageBox.Show(str);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            int ressult = 0;
            string str = "";
            List<string> list = new List<string>();
            foreach (string item in lb_Data.Items)
            {
                ressult = int.Parse(item) * int.Parse(item);
                list.Add(ressult.ToString());
            }

            foreach (string item in list)
            {
                str += item + ", ";
            }
            MessageBox.Show(str);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string str = "";
            foreach (string item in lb_Data.Items)
            {
                if (int.Parse(item) % 2 == 0)
                {
                    list.Add(item.ToString());
                } 
            }

            foreach (string item in list)
            {
                str += item + ", ";
            }
            MessageBox.Show(str);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string str = "";
            foreach (string item in lb_Data.Items)
            {
                if (int.Parse(item) % 2 != 0)
                {
                    list.Add(item.ToString());
                }
            }

            foreach (string item in list)
            {
                str += item + ", ";
            }
            MessageBox.Show(str);
        }
    }
}
