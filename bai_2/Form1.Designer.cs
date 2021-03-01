namespace bai_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.lb_Data = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_Data);
            this.groupBox2.Controls.Add(this.btn_Nhap);
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 329);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listbox";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 90);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_4);
            this.groupBox4.Controls.Add(this.btn_6);
            this.groupBox4.Controls.Add(this.btn_2);
            this.groupBox4.Controls.Add(this.btn_7);
            this.groupBox4.Controls.Add(this.btn_3);
            this.groupBox4.Controls.Add(this.btn_5);
            this.groupBox4.Controls.Add(this.btn_1);
            this.groupBox4.Location = new System.Drawing.Point(305, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 329);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xử lý Listbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(169, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(25, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(242, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(25, 61);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(242, 47);
            this.btn_Nhap.TabIndex = 1;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // lb_Data
            // 
            this.lb_Data.FormattingEnabled = true;
            this.lb_Data.ItemHeight = 16;
            this.lb_Data.Location = new System.Drawing.Point(25, 114);
            this.lb_Data.Name = "lb_Data";
            this.lb_Data.Size = new System.Drawing.Size(242, 196);
            this.lb_Data.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(577, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kết thúc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(6, 32);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(315, 35);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Tổng các phần tử trong List";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(6, 73);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(315, 35);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Xóa các phần tử đâu và cuối";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(6, 114);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(315, 35);
            this.btn_3.TabIndex = 1;
            this.btn_3.Text = "Xóa phần tử đang chọn";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(6, 155);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(315, 35);
            this.btn_4.TabIndex = 1;
            this.btn_4.Text = "Tăng mỗi phần tử lên 2";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(6, 196);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(315, 35);
            this.btn_5.TabIndex = 1;
            this.btn_5.Text = "Thay bằng bình phương";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(6, 278);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(315, 35);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "Chọn sỗ lẻ";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(6, 237);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(315, 35);
            this.btn_6.TabIndex = 1;
            this.btn_6.Text = "Chọn sỗ chẵn";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(649, 571);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FormListbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_Data;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_1;
    }
}

