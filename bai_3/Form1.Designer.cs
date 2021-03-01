namespace bai_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAB = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbLopA = new System.Windows.Forms.ListBox();
            this.lbLopB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnKetThuc);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnBA);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnAB);
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(37, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 336);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(189, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(264, 22);
            this.txtInput.TabIndex = 1;
            // 
            // btnAB
            // 
            this.btnAB.Location = new System.Drawing.Point(287, 104);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(86, 39);
            this.btnAB.TabIndex = 2;
            this.btnAB.Text = ">";
            this.btnAB.UseVisualStyleBackColor = true;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(462, 33);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 31);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBA
            // 
            this.btnBA.Location = new System.Drawing.Point(287, 192);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(86, 39);
            this.btnBA.TabIndex = 2;
            this.btnBA.Text = "<";
            this.btnBA.UseVisualStyleBackColor = true;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(287, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 39);
            this.button5.TabIndex = 2;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(96, 294);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(87, 36);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(470, 288);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(87, 36);
            this.btnKetThuc.TabIndex = 2;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLopA);
            this.groupBox3.Location = new System.Drawing.Point(42, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 201);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp A";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbLopB);
            this.groupBox4.Location = new System.Drawing.Point(405, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lớp B";
            // 
            // lbLopA
            // 
            this.lbLopA.FormattingEnabled = true;
            this.lbLopA.ItemHeight = 16;
            this.lbLopA.Location = new System.Drawing.Point(6, 15);
            this.lbLopA.Name = "lbLopA";
            this.lbLopA.Size = new System.Drawing.Size(209, 180);
            this.lbLopA.TabIndex = 0;
            // 
            // lbLopB
            // 
            this.lbLopB.FormattingEnabled = true;
            this.lbLopB.ItemHeight = 16;
            this.lbLopB.Location = new System.Drawing.Point(6, 15);
            this.lbLopB.Name = "lbLopB";
            this.lbLopB.Size = new System.Drawing.Size(209, 180);
            this.lbLopB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbLopB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLopA;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
    }
}

