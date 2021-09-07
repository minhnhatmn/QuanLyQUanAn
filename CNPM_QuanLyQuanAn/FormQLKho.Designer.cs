namespace CNPM_QuanLyQuanAn
{
    partial class FormQLKho
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_nguyenlieu_timkiem = new System.Windows.Forms.Button();
            this.dgv_nguyenlieu = new System.Windows.Forms.DataGridView();
            this.txt_nguyenlieu_manl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_qlxuat_datlai = new System.Windows.Forms.TabPage();
            this.numb_qlxuat_soluong = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_lichsuxuat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_lichsuxuat_nguyenlieu = new System.Windows.Forms.DataGridView();
            this.btn_qlxuat_them = new System.Windows.Forms.Button();
            this.txt_qlxuat_manl = new System.Windows.Forms.TextBox();
            this.txt_qlxuat_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_qlnhap_soluong = new System.Windows.Forms.NumericUpDown();
            this.txt_qlnhap_ngayhethan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nhacungcap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_lichsunhap = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_lichsunhap_nguyenlieu = new System.Windows.Forms.DataGridView();
            this.btn_qlnhap_them = new System.Windows.Forms.Button();
            this.txt_qlnhap_manl = new System.Windows.Forms.TextBox();
            this.txt_qlnhap_manv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguyenlieu)).BeginInit();
            this.btn_qlxuat_datlai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_qlxuat_soluong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsuxuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsuxuat_nguyenlieu)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qlnhap_soluong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsunhap)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsunhap_nguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.btn_qlxuat_datlai);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_nguyenlieu_timkiem);
            this.tabPage1.Controls.Add(this.dgv_nguyenlieu);
            this.tabPage1.Controls.Add(this.txt_nguyenlieu_manl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nguyên liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_nguyenlieu_timkiem
            // 
            this.btn_nguyenlieu_timkiem.Location = new System.Drawing.Point(238, 98);
            this.btn_nguyenlieu_timkiem.Name = "btn_nguyenlieu_timkiem";
            this.btn_nguyenlieu_timkiem.Size = new System.Drawing.Size(115, 23);
            this.btn_nguyenlieu_timkiem.TabIndex = 5;
            this.btn_nguyenlieu_timkiem.Text = "Tìm kiếm";
            this.btn_nguyenlieu_timkiem.UseVisualStyleBackColor = true;
            this.btn_nguyenlieu_timkiem.Click += new System.EventHandler(this.btn_nguyenlieu_timkiem_Click);
            // 
            // dgv_nguyenlieu
            // 
            this.dgv_nguyenlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguyenlieu.Location = new System.Drawing.Point(6, 146);
            this.dgv_nguyenlieu.Name = "dgv_nguyenlieu";
            this.dgv_nguyenlieu.RowTemplate.Height = 24;
            this.dgv_nguyenlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nguyenlieu.Size = new System.Drawing.Size(1106, 245);
            this.dgv_nguyenlieu.TabIndex = 4;
            this.dgv_nguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nguyenlieu_CellClick);
            // 
            // txt_nguyenlieu_manl
            // 
            this.txt_nguyenlieu_manl.Location = new System.Drawing.Point(192, 40);
            this.txt_nguyenlieu_manl.Name = "txt_nguyenlieu_manl";
            this.txt_nguyenlieu_manl.Size = new System.Drawing.Size(256, 22);
            this.txt_nguyenlieu_manl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã nguyên liệu";
            // 
            // btn_qlxuat_datlai
            // 
            this.btn_qlxuat_datlai.Controls.Add(this.numb_qlxuat_soluong);
            this.btn_qlxuat_datlai.Controls.Add(this.groupBox2);
            this.btn_qlxuat_datlai.Controls.Add(this.groupBox1);
            this.btn_qlxuat_datlai.Controls.Add(this.btn_qlxuat_them);
            this.btn_qlxuat_datlai.Controls.Add(this.txt_qlxuat_manl);
            this.btn_qlxuat_datlai.Controls.Add(this.txt_qlxuat_manv);
            this.btn_qlxuat_datlai.Controls.Add(this.label5);
            this.btn_qlxuat_datlai.Controls.Add(this.label4);
            this.btn_qlxuat_datlai.Controls.Add(this.label3);
            this.btn_qlxuat_datlai.Location = new System.Drawing.Point(4, 25);
            this.btn_qlxuat_datlai.Name = "btn_qlxuat_datlai";
            this.btn_qlxuat_datlai.Padding = new System.Windows.Forms.Padding(3);
            this.btn_qlxuat_datlai.Size = new System.Drawing.Size(1118, 395);
            this.btn_qlxuat_datlai.TabIndex = 1;
            this.btn_qlxuat_datlai.Text = "Quản lý xuất";
            this.btn_qlxuat_datlai.UseVisualStyleBackColor = true;
            // 
            // numb_qlxuat_soluong
            // 
            this.numb_qlxuat_soluong.Location = new System.Drawing.Point(116, 45);
            this.numb_qlxuat_soluong.Name = "numb_qlxuat_soluong";
            this.numb_qlxuat_soluong.Size = new System.Drawing.Size(64, 22);
            this.numb_qlxuat_soluong.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_lichsuxuat);
            this.groupBox2.Location = new System.Drawing.Point(520, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 235);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử xuất";
            // 
            // dgv_lichsuxuat
            // 
            this.dgv_lichsuxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichsuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichsuxuat.Location = new System.Drawing.Point(7, 21);
            this.dgv_lichsuxuat.Name = "dgv_lichsuxuat";
            this.dgv_lichsuxuat.RowTemplate.Height = 24;
            this.dgv_lichsuxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lichsuxuat.Size = new System.Drawing.Size(582, 208);
            this.dgv_lichsuxuat.TabIndex = 0;
            this.dgv_lichsuxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lichsuxuat_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_lichsuxuat_nguyenlieu);
            this.groupBox1.Location = new System.Drawing.Point(6, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 235);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nguyên liệu";
            // 
            // dgv_lichsuxuat_nguyenlieu
            // 
            this.dgv_lichsuxuat_nguyenlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichsuxuat_nguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichsuxuat_nguyenlieu.Location = new System.Drawing.Point(6, 21);
            this.dgv_lichsuxuat_nguyenlieu.Name = "dgv_lichsuxuat_nguyenlieu";
            this.dgv_lichsuxuat_nguyenlieu.RowTemplate.Height = 24;
            this.dgv_lichsuxuat_nguyenlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lichsuxuat_nguyenlieu.Size = new System.Drawing.Size(496, 208);
            this.dgv_lichsuxuat_nguyenlieu.TabIndex = 11;
            this.dgv_lichsuxuat_nguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lichsuxuat_nguyenlieu_CellClick);
            // 
            // btn_qlxuat_them
            // 
            this.btn_qlxuat_them.Location = new System.Drawing.Point(302, 116);
            this.btn_qlxuat_them.Name = "btn_qlxuat_them";
            this.btn_qlxuat_them.Size = new System.Drawing.Size(402, 23);
            this.btn_qlxuat_them.TabIndex = 8;
            this.btn_qlxuat_them.Text = "Xuất";
            this.btn_qlxuat_them.UseVisualStyleBackColor = true;
            this.btn_qlxuat_them.Click += new System.EventHandler(this.btn_qlxuat_them_Click);
            // 
            // txt_qlxuat_manl
            // 
            this.txt_qlxuat_manl.Location = new System.Drawing.Point(489, 12);
            this.txt_qlxuat_manl.Name = "txt_qlxuat_manl";
            this.txt_qlxuat_manl.Size = new System.Drawing.Size(196, 22);
            this.txt_qlxuat_manl.TabIndex = 4;
            // 
            // txt_qlxuat_manv
            // 
            this.txt_qlxuat_manv.Enabled = false;
            this.txt_qlxuat_manv.Location = new System.Drawing.Point(116, 12);
            this.txt_qlxuat_manv.Name = "txt_qlxuat_manv";
            this.txt_qlxuat_manv.ReadOnly = true;
            this.txt_qlxuat_manv.Size = new System.Drawing.Size(196, 22);
            this.txt_qlxuat_manv.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã nguyên liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_qlnhap_soluong);
            this.tabPage3.Controls.Add(this.txt_qlnhap_ngayhethan);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txt_nhacungcap);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.btn_qlnhap_them);
            this.tabPage3.Controls.Add(this.txt_qlnhap_manl);
            this.tabPage3.Controls.Add(this.txt_qlnhap_manv);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1118, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý nhập";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_qlnhap_soluong
            // 
            this.txt_qlnhap_soluong.Location = new System.Drawing.Point(115, 44);
            this.txt_qlnhap_soluong.Name = "txt_qlnhap_soluong";
            this.txt_qlnhap_soluong.Size = new System.Drawing.Size(120, 22);
            this.txt_qlnhap_soluong.TabIndex = 29;
            // 
            // txt_qlnhap_ngayhethan
            // 
            this.txt_qlnhap_ngayhethan.Location = new System.Drawing.Point(826, 9);
            this.txt_qlnhap_ngayhethan.Name = "txt_qlnhap_ngayhethan";
            this.txt_qlnhap_ngayhethan.Size = new System.Drawing.Size(196, 22);
            this.txt_qlnhap_ngayhethan.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số ngày hết hạn";
            // 
            // txt_nhacungcap
            // 
            this.txt_nhacungcap.Location = new System.Drawing.Point(488, 41);
            this.txt_nhacungcap.Name = "txt_nhacungcap";
            this.txt_nhacungcap.Size = new System.Drawing.Size(196, 22);
            this.txt_nhacungcap.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nhà cung cấp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_lichsunhap);
            this.groupBox3.Location = new System.Drawing.Point(527, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 235);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lịch sử nhập";
            // 
            // dgv_lichsunhap
            // 
            this.dgv_lichsunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichsunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichsunhap.Location = new System.Drawing.Point(7, 21);
            this.dgv_lichsunhap.Name = "dgv_lichsunhap";
            this.dgv_lichsunhap.RowTemplate.Height = 24;
            this.dgv_lichsunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lichsunhap.Size = new System.Drawing.Size(572, 208);
            this.dgv_lichsunhap.TabIndex = 0;
            this.dgv_lichsunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lichsunhap_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_lichsunhap_nguyenlieu);
            this.groupBox4.Location = new System.Drawing.Point(5, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 235);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nguyên liệu";
            // 
            // dgv_lichsunhap_nguyenlieu
            // 
            this.dgv_lichsunhap_nguyenlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichsunhap_nguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichsunhap_nguyenlieu.Location = new System.Drawing.Point(6, 21);
            this.dgv_lichsunhap_nguyenlieu.Name = "dgv_lichsunhap_nguyenlieu";
            this.dgv_lichsunhap_nguyenlieu.RowTemplate.Height = 24;
            this.dgv_lichsunhap_nguyenlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lichsunhap_nguyenlieu.Size = new System.Drawing.Size(504, 208);
            this.dgv_lichsunhap_nguyenlieu.TabIndex = 11;
            this.dgv_lichsunhap_nguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lichsunhap_nguyenlieu_CellClick);
            this.dgv_lichsunhap_nguyenlieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lichsunhap_nguyenlieu_CellContentClick);
            // 
            // btn_qlnhap_them
            // 
            this.btn_qlnhap_them.Location = new System.Drawing.Point(305, 110);
            this.btn_qlnhap_them.Name = "btn_qlnhap_them";
            this.btn_qlnhap_them.Size = new System.Drawing.Size(453, 23);
            this.btn_qlnhap_them.TabIndex = 20;
            this.btn_qlnhap_them.Text = "Nhập";
            this.btn_qlnhap_them.UseVisualStyleBackColor = true;
            this.btn_qlnhap_them.Click += new System.EventHandler(this.btn_qlnhap_them_Click);
            // 
            // txt_qlnhap_manl
            // 
            this.txt_qlnhap_manl.Location = new System.Drawing.Point(488, 9);
            this.txt_qlnhap_manl.Name = "txt_qlnhap_manl";
            this.txt_qlnhap_manl.Size = new System.Drawing.Size(196, 22);
            this.txt_qlnhap_manl.TabIndex = 18;
            // 
            // txt_qlnhap_manv
            // 
            this.txt_qlnhap_manv.Enabled = false;
            this.txt_qlnhap_manv.Location = new System.Drawing.Point(115, 9);
            this.txt_qlnhap_manv.Name = "txt_qlnhap_manv";
            this.txt_qlnhap_manv.ReadOnly = true;
            this.txt_qlnhap_manv.Size = new System.Drawing.Size(196, 22);
            this.txt_qlnhap_manv.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã nguyên liệu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã nhân viên";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Đặt lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormQLKho";
            this.Text = "FormQLKho";
            this.Load += new System.EventHandler(this.FormQLKho_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguyenlieu)).EndInit();
            this.btn_qlxuat_datlai.ResumeLayout(false);
            this.btn_qlxuat_datlai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_qlxuat_soluong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsuxuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsuxuat_nguyenlieu)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qlnhap_soluong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsunhap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsunhap_nguyenlieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_nguyenlieu_timkiem;
        private System.Windows.Forms.DataGridView dgv_nguyenlieu;
        private System.Windows.Forms.TextBox txt_nguyenlieu_manl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage btn_qlxuat_datlai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_lichsuxuat;
        private System.Windows.Forms.Button btn_qlxuat_them;
        private System.Windows.Forms.TextBox txt_qlxuat_manl;
        private System.Windows.Forms.TextBox txt_qlxuat_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_lichsunhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_lichsunhap_nguyenlieu;
        private System.Windows.Forms.Button btn_qlnhap_them;
        private System.Windows.Forms.TextBox txt_qlnhap_manl;
        private System.Windows.Forms.TextBox txt_qlnhap_manv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nhacungcap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_lichsuxuat_nguyenlieu;
        private System.Windows.Forms.TextBox txt_qlnhap_ngayhethan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numb_qlxuat_soluong;
        private System.Windows.Forms.NumericUpDown txt_qlnhap_soluong;
        private System.Windows.Forms.Button button2;
    }
}