namespace Nhom2_BTBuoi6
{
    partial class frmQuanLySV
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
            this.btnLuidau = new System.Windows.Forms.Button();
            this.btnLui = new System.Windows.Forms.Button();
            this.btnToi = new System.Windows.Forms.Button();
            this.btnVecuoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLuidau
            // 
            this.btnLuidau.Location = new System.Drawing.Point(71, 53);
            this.btnLuidau.Name = "btnLuidau";
            this.btnLuidau.Size = new System.Drawing.Size(75, 23);
            this.btnLuidau.TabIndex = 0;
            this.btnLuidau.Text = "|<";
            this.btnLuidau.UseVisualStyleBackColor = true;
            this.btnLuidau.Click += new System.EventHandler(this.btnLuidau_Click);
            // 
            // btnLui
            // 
            this.btnLui.Location = new System.Drawing.Point(196, 53);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(75, 23);
            this.btnLui.TabIndex = 1;
            this.btnLui.Text = "<<";
            this.btnLui.UseVisualStyleBackColor = true;
            this.btnLui.Click += new System.EventHandler(this.btnLui_Click);
            // 
            // btnToi
            // 
            this.btnToi.Location = new System.Drawing.Point(439, 53);
            this.btnToi.Name = "btnToi";
            this.btnToi.Size = new System.Drawing.Size(75, 23);
            this.btnToi.TabIndex = 2;
            this.btnToi.Text = ">>";
            this.btnToi.UseVisualStyleBackColor = true;
            this.btnToi.Click += new System.EventHandler(this.btnToi_Click);
            // 
            // btnVecuoi
            // 
            this.btnVecuoi.Location = new System.Drawing.Point(574, 53);
            this.btnVecuoi.Name = "btnVecuoi";
            this.btnVecuoi.Size = new System.Drawing.Size(75, 23);
            this.btnVecuoi.TabIndex = 3;
            this.btnVecuoi.Text = ">|";
            this.btnVecuoi.UseVisualStyleBackColor = true;
            this.btnVecuoi.Click += new System.EventHandler(this.btnVecuoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã khoa:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(246, 126);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(247, 22);
            this.txtMa.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(246, 169);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(241, 22);
            this.txtTen.TabIndex = 9;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(247, 214);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(239, 22);
            this.txtDiem.TabIndex = 10;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(246, 247);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(241, 22);
            this.txtMaKhoa.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(123, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(325, 318);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(500, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vị trí/tổng số";
            // 
            // frmQuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVecuoi);
            this.Controls.Add(this.btnToi);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.btnLuidau);
            this.Name = "frmQuanLySV";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmQuanLySV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuidau;
        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.Button btnToi;
        private System.Windows.Forms.Button btnVecuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
    }
}

