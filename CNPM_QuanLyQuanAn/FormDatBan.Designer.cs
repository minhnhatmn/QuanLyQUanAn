namespace CNPM_QuanLyQuanAn
{
    partial class FormDatBan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_thoigiandat = new System.Windows.Forms.DateTimePicker();
            this.btnSuaDatban = new System.Windows.Forms.Button();
            this.btnXoaDatban = new System.Windows.Forms.Button();
            this.btnThemDatban = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_datban_maban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_madat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_datban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ban = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_monan = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numb_soluong = new System.Windows.Forms.NumericUpDown();
            this.dgv_chitietdatban = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ctdatban_madat = new System.Windows.Forms.TextBox();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btn_timdatban = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_thoigian = new System.Windows.Forms.TextBox();
            this.btn_datlai = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_stt = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datban)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdatban)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_khachhang);
            this.groupBox3.Location = new System.Drawing.Point(1105, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 317);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khách hàng";
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Location = new System.Drawing.Point(7, 22);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khachhang.Size = new System.Drawing.Size(625, 289);
            this.dgv_khachhang.TabIndex = 0;
            this.dgv_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachhang_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_datlai);
            this.groupBox2.Controls.Add(this.txt_thoigian);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_timdatban);
            this.groupBox2.Controls.Add(this.dtp_thoigiandat);
            this.groupBox2.Controls.Add(this.btnSuaDatban);
            this.groupBox2.Controls.Add(this.btnXoaDatban);
            this.groupBox2.Controls.Add(this.btnThemDatban);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_makh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_manv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_datban_maban);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_madat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgv_datban);
            this.groupBox2.Location = new System.Drawing.Point(373, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 444);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đặt bàn";
            // 
            // dtp_thoigiandat
            // 
            this.dtp_thoigiandat.Location = new System.Drawing.Point(168, 353);
            this.dtp_thoigiandat.Name = "dtp_thoigiandat";
            this.dtp_thoigiandat.Size = new System.Drawing.Size(320, 22);
            this.dtp_thoigiandat.TabIndex = 44;
            // 
            // btnSuaDatban
            // 
            this.btnSuaDatban.Location = new System.Drawing.Point(385, 401);
            this.btnSuaDatban.Name = "btnSuaDatban";
            this.btnSuaDatban.Size = new System.Drawing.Size(78, 37);
            this.btnSuaDatban.TabIndex = 43;
            this.btnSuaDatban.Text = "Sửa";
            this.btnSuaDatban.UseVisualStyleBackColor = true;
            this.btnSuaDatban.Click += new System.EventHandler(this.btnSuaDatban_Click);
            // 
            // btnXoaDatban
            // 
            this.btnXoaDatban.Location = new System.Drawing.Point(301, 401);
            this.btnXoaDatban.Name = "btnXoaDatban";
            this.btnXoaDatban.Size = new System.Drawing.Size(78, 37);
            this.btnXoaDatban.TabIndex = 42;
            this.btnXoaDatban.Text = "Xoá";
            this.btnXoaDatban.UseVisualStyleBackColor = true;
            this.btnXoaDatban.Click += new System.EventHandler(this.btnXoaDatban_Click);
            // 
            // btnThemDatban
            // 
            this.btnThemDatban.Location = new System.Drawing.Point(217, 401);
            this.btnThemDatban.Name = "btnThemDatban";
            this.btnThemDatban.Size = new System.Drawing.Size(78, 37);
            this.btnThemDatban.TabIndex = 41;
            this.btnThemDatban.Text = "Thêm";
            this.btnThemDatban.UseVisualStyleBackColor = true;
            this.btnThemDatban.Click += new System.EventHandler(this.btnThemDatban_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày đặt";
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(168, 321);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(320, 22);
            this.txt_makh.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã khách hàng";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(168, 293);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.ReadOnly = true;
            this.txt_manv.Size = new System.Drawing.Size(320, 22);
            this.txt_manv.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã nhân viên";
            // 
            // txt_datban_maban
            // 
            this.txt_datban_maban.Location = new System.Drawing.Point(168, 267);
            this.txt_datban_maban.Name = "txt_datban_maban";
            this.txt_datban_maban.Size = new System.Drawing.Size(320, 22);
            this.txt_datban_maban.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã bàn";
            // 
            // txt_madat
            // 
            this.txt_madat.Location = new System.Drawing.Point(168, 239);
            this.txt_madat.Name = "txt_madat";
            this.txt_madat.Size = new System.Drawing.Size(320, 22);
            this.txt_madat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã đặt bàn";
            // 
            // dgv_datban
            // 
            this.dgv_datban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_datban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_datban.Location = new System.Drawing.Point(7, 22);
            this.dgv_datban.Name = "dgv_datban";
            this.dgv_datban.RowTemplate.Height = 24;
            this.dgv_datban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datban.Size = new System.Drawing.Size(713, 202);
            this.dgv_datban.TabIndex = 0;
            this.dgv_datban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datban_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADATBAN";
            this.Column1.HeaderText = "Mã đặt bàn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANV";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 112;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MAKH";
            this.Column3.HeaderText = "Mã khách hàng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 123;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "THOIGIANLAPDAT";
            this.Column4.HeaderText = "Ngày lập";
            this.Column4.Name = "Column4";
            this.Column4.Width = 86;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "THOIGIANDAT";
            this.Column5.HeaderText = "Ngày đặt";
            this.Column5.Name = "Column5";
            this.Column5.Width = 87;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MABAN";
            this.Column6.HeaderText = "Mã bàn";
            this.Column6.Name = "Column6";
            this.Column6.Width = 78;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "BAN";
            this.Column7.HeaderText = "BAN";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "KHACHHANG";
            this.Column8.HeaderText = "KHACHHANG";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NHANVIEN";
            this.Column9.HeaderText = "NHANVIEN";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Số lượng";
            // 
            // txt_mamon
            // 
            this.txt_mamon.Location = new System.Drawing.Point(117, 92);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(154, 22);
            this.txt_mamon.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Mã món";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ban);
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 445);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bàn";
            // 
            // dgv_ban
            // 
            this.dgv_ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ban.Location = new System.Drawing.Point(6, 21);
            this.dgv_ban.Name = "dgv_ban";
            this.dgv_ban.RowTemplate.Height = 24;
            this.dgv_ban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ban.Size = new System.Drawing.Size(334, 411);
            this.dgv_ban.TabIndex = 42;
            this.dgv_ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ban_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_monan);
            this.groupBox4.Location = new System.Drawing.Point(1105, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 421);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Món ăn";
            // 
            // dgv_monan
            // 
            this.dgv_monan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monan.Location = new System.Drawing.Point(7, 21);
            this.dgv_monan.Name = "dgv_monan";
            this.dgv_monan.RowTemplate.Height = 24;
            this.dgv_monan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monan.Size = new System.Drawing.Size(625, 393);
            this.dgv_monan.TabIndex = 0;
            this.dgv_monan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monan_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txt_stt);
            this.groupBox5.Controls.Add(this.numb_soluong);
            this.groupBox5.Controls.Add(this.dgv_chitietdatban);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_ctdatban_madat);
            this.groupBox5.Controls.Add(this.btnSuaCT);
            this.groupBox5.Controls.Add(this.btnXoaCT);
            this.groupBox5.Controls.Add(this.btnThemCT);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_mamon);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(21, 464);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1078, 292);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết đặt bàn";
            // 
            // numb_soluong
            // 
            this.numb_soluong.Location = new System.Drawing.Point(117, 127);
            this.numb_soluong.Name = "numb_soluong";
            this.numb_soluong.Size = new System.Drawing.Size(58, 22);
            this.numb_soluong.TabIndex = 55;
            // 
            // dgv_chitietdatban
            // 
            this.dgv_chitietdatban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitietdatban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietdatban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgv_chitietdatban.Location = new System.Drawing.Point(289, 21);
            this.dgv_chitietdatban.Name = "dgv_chitietdatban";
            this.dgv_chitietdatban.RowTemplate.Height = 24;
            this.dgv_chitietdatban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietdatban.Size = new System.Drawing.Size(783, 264);
            this.dgv_chitietdatban.TabIndex = 54;
            this.dgv_chitietdatban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietdatban_CellClick);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "STT";
            this.Column10.HeaderText = "Số thứ tự";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MADATBAN";
            this.Column11.HeaderText = "Mã đặt bàn";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MAMON";
            this.Column12.HeaderText = "Mã món";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "SOLUONG";
            this.Column13.HeaderText = "Số lượng";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "DATBAN";
            this.Column14.HeaderText = "DATBAN";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "MONAN";
            this.Column15.HeaderText = "MONAN";
            this.Column15.Name = "Column15";
            this.Column15.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã đặt";
            // 
            // txt_ctdatban_madat
            // 
            this.txt_ctdatban_madat.Location = new System.Drawing.Point(117, 62);
            this.txt_ctdatban_madat.Name = "txt_ctdatban_madat";
            this.txt_ctdatban_madat.Size = new System.Drawing.Size(154, 22);
            this.txt_ctdatban_madat.TabIndex = 53;
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(181, 175);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(78, 37);
            this.btnSuaCT.TabIndex = 51;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(97, 175);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(78, 37);
            this.btnXoaCT.TabIndex = 50;
            this.btnXoaCT.Text = "Xoá";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(13, 175);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(78, 37);
            this.btnThemCT.TabIndex = 49;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btn_timdatban
            // 
            this.btn_timdatban.Location = new System.Drawing.Point(60, 401);
            this.btn_timdatban.Name = "btn_timdatban";
            this.btn_timdatban.Size = new System.Drawing.Size(122, 37);
            this.btn_timdatban.TabIndex = 45;
            this.btn_timdatban.Text = "Tìm đặt bàn";
            this.btn_timdatban.UseVisualStyleBackColor = true;
            this.btn_timdatban.Click += new System.EventHandler(this.TimDatBan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Thời gian";
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Location = new System.Drawing.Point(580, 238);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(140, 22);
            this.txt_thoigian.TabIndex = 47;
            // 
            // btn_datlai
            // 
            this.btn_datlai.Location = new System.Drawing.Point(509, 401);
            this.btn_datlai.Name = "btn_datlai";
            this.btn_datlai.Size = new System.Drawing.Size(122, 37);
            this.btn_datlai.TabIndex = 48;
            this.btn_datlai.Text = "Đặt lại";
            this.btn_datlai.UseVisualStyleBackColor = true;
            this.btn_datlai.Click += new System.EventHandler(this.btn_datlai_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "STT";
            // 
            // txt_stt
            // 
            this.txt_stt.Location = new System.Drawing.Point(117, 34);
            this.txt_stt.Name = "txt_stt";
            this.txt_stt.Size = new System.Drawing.Size(154, 22);
            this.txt_stt.TabIndex = 57;
            // 
            // FormDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 779);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FormDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatBan";
            this.Load += new System.EventHandler(this.FormDatBan_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdatban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_thoigiandat;
        private System.Windows.Forms.Button btnSuaDatban;
        private System.Windows.Forms.Button btnXoaDatban;
        private System.Windows.Forms.Button btnThemDatban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_datban_maban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_madat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_datban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_monan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_chitietdatban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ctdatban_madat;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.DataGridView dgv_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.NumericUpDown numb_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timdatban;
        private System.Windows.Forms.TextBox txt_thoigian;
        private System.Windows.Forms.Button btn_datlai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_stt;
    }
}