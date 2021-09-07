namespace CNPM_QuanLyQuanAn
{
    partial class FormQLKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_sdtkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.radio_Nu = new System.Windows.Forms.RadioButton();
            this.radio_Nam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(130, 44);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(449, 22);
            this.txt_makh.TabIndex = 2;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(130, 73);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(449, 22);
            this.txt_tenkh.TabIndex = 3;
            // 
            // txt_sdtkh
            // 
            this.txt_sdtkh.Location = new System.Drawing.Point(130, 101);
            this.txt_sdtkh.Name = "txt_sdtkh";
            this.txt_sdtkh.Size = new System.Drawing.Size(449, 22);
            this.txt_sdtkh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "SDT";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(130, 126);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(449, 22);
            this.txt_ngaysinh.TabIndex = 12;
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Location = new System.Drawing.Point(12, 259);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khachhang.Size = new System.Drawing.Size(740, 215);
            this.dgv_khachhang.TabIndex = 35;
            this.dgv_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachhang_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(414, 216);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(78, 37);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(330, 216);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(78, 37);
            this.btn_xoa.TabIndex = 37;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(246, 216);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(78, 37);
            this.btn_them.TabIndex = 36;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // radio_Nu
            // 
            this.radio_Nu.AutoSize = true;
            this.radio_Nu.Location = new System.Drawing.Point(245, 166);
            this.radio_Nu.Name = "radio_Nu";
            this.radio_Nu.Size = new System.Drawing.Size(47, 21);
            this.radio_Nu.TabIndex = 42;
            this.radio_Nu.TabStop = true;
            this.radio_Nu.Text = "Nữ";
            this.radio_Nu.UseVisualStyleBackColor = true;
            // 
            // radio_Nam
            // 
            this.radio_Nam.AutoSize = true;
            this.radio_Nam.Location = new System.Drawing.Point(135, 166);
            this.radio_Nam.Name = "radio_Nam";
            this.radio_Nam.Size = new System.Drawing.Size(58, 21);
            this.radio_Nam.TabIndex = 41;
            this.radio_Nam.TabStop = true;
            this.radio_Nam.Text = "Nam";
            this.radio_Nam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Giới tính";
            // 
            // FormQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 486);
            this.Controls.Add(this.radio_Nu);
            this.Controls.Add(this.radio_Nam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_khachhang);
            this.Controls.Add(this.txt_ngaysinh);
            this.Controls.Add(this.txt_sdtkh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormQLKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangKyThanhVien";
            this.Load += new System.EventHandler(this.FormQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_sdtkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_ngaysinh;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RadioButton radio_Nu;
        private System.Windows.Forms.RadioButton radio_Nam;
        private System.Windows.Forms.Label label9;
    }
}