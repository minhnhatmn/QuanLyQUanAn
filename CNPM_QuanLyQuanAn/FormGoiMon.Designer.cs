namespace CNPM_QuanLyQuanAn
{
    partial class FormGoiMon
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_monan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ban = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_maban = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_magoimon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_goimon = new System.Windows.Forms.DataGridView();
            this.MAMGOIMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiangoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_stt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numb_SoLuongMon = new System.Windows.Forms.NumericUpDown();
            this.dgv_chitietgoimon = new System.Windows.Forms.DataGridView();
            this.btn_suact = new System.Windows.Forms.Button();
            this.btn_xoact = new System.Windows.Forms.Button();
            this.btn_themct = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ctgoimon_magoimon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goimon)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_SoLuongMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietgoimon)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_monan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 276);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Món ăn";
            // 
            // dgv_monan
            // 
            this.dgv_monan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monan.Location = new System.Drawing.Point(7, 22);
            this.dgv_monan.Name = "dgv_monan";
            this.dgv_monan.RowTemplate.Height = 24;
            this.dgv_monan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monan.Size = new System.Drawing.Size(315, 248);
            this.dgv_monan.TabIndex = 0;
            this.dgv_monan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monan_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ban);
            this.groupBox2.Location = new System.Drawing.Point(13, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 298);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bàn";
            // 
            // dgv_ban
            // 
            this.dgv_ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ban.Location = new System.Drawing.Point(6, 25);
            this.dgv_ban.Name = "dgv_ban";
            this.dgv_ban.RowTemplate.Height = 24;
            this.dgv_ban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ban.Size = new System.Drawing.Size(315, 267);
            this.dgv_ban.TabIndex = 1;
            this.dgv_ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ban_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_maban);
            this.groupBox3.Controls.Add(this.txt_manv);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_magoimon);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgv_goimon);
            this.groupBox3.Location = new System.Drawing.Point(346, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 581);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gọi món";
            // 
            // txt_maban
            // 
            this.txt_maban.Location = new System.Drawing.Point(128, 383);
            this.txt_maban.Name = "txt_maban";
            this.txt_maban.Size = new System.Drawing.Size(261, 22);
            this.txt_maban.TabIndex = 56;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(128, 413);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.ReadOnly = true;
            this.txt_manv.Size = new System.Drawing.Size(261, 22);
            this.txt_manv.TabIndex = 55;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(263, 520);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(78, 37);
            this.btn_sua.TabIndex = 53;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(179, 520);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(78, 37);
            this.btn_xoa.TabIndex = 52;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(95, 520);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(78, 37);
            this.btn_them.TabIndex = 51;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã bàn";
            // 
            // txt_magoimon
            // 
            this.txt_magoimon.Location = new System.Drawing.Point(128, 357);
            this.txt_magoimon.Name = "txt_magoimon";
            this.txt_magoimon.Size = new System.Drawing.Size(261, 22);
            this.txt_magoimon.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã gọi món";
            // 
            // dgv_goimon
            // 
            this.dgv_goimon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_goimon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_goimon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMGOIMON,
            this.manv,
            this.maban,
            this.thoigiangoi});
            this.dgv_goimon.Location = new System.Drawing.Point(12, 22);
            this.dgv_goimon.Name = "dgv_goimon";
            this.dgv_goimon.RowTemplate.Height = 24;
            this.dgv_goimon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_goimon.Size = new System.Drawing.Size(507, 319);
            this.dgv_goimon.TabIndex = 39;
            this.dgv_goimon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_goimon_CellClick);
            // 
            // MAMGOIMON
            // 
            this.MAMGOIMON.DataPropertyName = "MAGOIMON";
            this.MAMGOIMON.HeaderText = "Mã gọi món";
            this.MAMGOIMON.Name = "MAMGOIMON";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MANV";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // maban
            // 
            this.maban.DataPropertyName = "MABAN";
            this.maban.HeaderText = "Mã bàn";
            this.maban.Name = "maban";
            // 
            // thoigiangoi
            // 
            this.thoigiangoi.DataPropertyName = "THOIGIANGOI";
            this.thoigiangoi.HeaderText = "Thời gian gọi";
            this.thoigiangoi.Name = "thoigiangoi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Số lượng";
            // 
            // txt_mamon
            // 
            this.txt_mamon.Location = new System.Drawing.Point(207, 445);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(230, 22);
            this.txt_mamon.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã món";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_stt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numb_SoLuongMon);
            this.groupBox4.Controls.Add(this.dgv_chitietgoimon);
            this.groupBox4.Controls.Add(this.btn_suact);
            this.groupBox4.Controls.Add(this.btn_xoact);
            this.groupBox4.Controls.Add(this.btn_themct);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txt_mamon);
            this.groupBox4.Controls.Add(this.txt_ctgoimon_magoimon);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(877, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 581);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết gọi món";
            // 
            // txt_stt
            // 
            this.txt_stt.Location = new System.Drawing.Point(313, 478);
            this.txt_stt.Name = "txt_stt";
            this.txt_stt.Size = new System.Drawing.Size(124, 22);
            this.txt_stt.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "STT";
            // 
            // numb_SoLuongMon
            // 
            this.numb_SoLuongMon.Location = new System.Drawing.Point(207, 476);
            this.numb_SoLuongMon.Name = "numb_SoLuongMon";
            this.numb_SoLuongMon.Size = new System.Drawing.Size(57, 22);
            this.numb_SoLuongMon.TabIndex = 60;
            // 
            // dgv_chitietgoimon
            // 
            this.dgv_chitietgoimon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitietgoimon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietgoimon.Location = new System.Drawing.Point(6, 22);
            this.dgv_chitietgoimon.Name = "dgv_chitietgoimon";
            this.dgv_chitietgoimon.RowTemplate.Height = 24;
            this.dgv_chitietgoimon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietgoimon.Size = new System.Drawing.Size(431, 383);
            this.dgv_chitietgoimon.TabIndex = 59;
            this.dgv_chitietgoimon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietgoimon_CellClick);
            // 
            // btn_suact
            // 
            this.btn_suact.Location = new System.Drawing.Point(338, 520);
            this.btn_suact.Name = "btn_suact";
            this.btn_suact.Size = new System.Drawing.Size(78, 37);
            this.btn_suact.TabIndex = 58;
            this.btn_suact.Text = "Sửa";
            this.btn_suact.UseVisualStyleBackColor = true;
            this.btn_suact.Click += new System.EventHandler(this.btn_suact_Click);
            // 
            // btn_xoact
            // 
            this.btn_xoact.Location = new System.Drawing.Point(254, 520);
            this.btn_xoact.Name = "btn_xoact";
            this.btn_xoact.Size = new System.Drawing.Size(78, 37);
            this.btn_xoact.TabIndex = 57;
            this.btn_xoact.Text = "Xoá";
            this.btn_xoact.UseVisualStyleBackColor = true;
            this.btn_xoact.Click += new System.EventHandler(this.btn_xoact_Click);
            // 
            // btn_themct
            // 
            this.btn_themct.Location = new System.Drawing.Point(170, 520);
            this.btn_themct.Name = "btn_themct";
            this.btn_themct.Size = new System.Drawing.Size(78, 37);
            this.btn_themct.TabIndex = 56;
            this.btn_themct.Text = "Thêm";
            this.btn_themct.UseVisualStyleBackColor = true;
            this.btn_themct.Click += new System.EventHandler(this.btn_themct_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(832, -41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 581);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết gọi món";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mã gọi món";
            // 
            // txt_ctgoimon_magoimon
            // 
            this.txt_ctgoimon_magoimon.Location = new System.Drawing.Point(207, 416);
            this.txt_ctgoimon_magoimon.Name = "txt_ctgoimon_magoimon";
            this.txt_ctgoimon_magoimon.Size = new System.Drawing.Size(230, 22);
            this.txt_ctgoimon_magoimon.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mã gọi món";
            // 
            // FormGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 605);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FormGoiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGoiMon";
            this.Load += new System.EventHandler(this.FormGoiMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goimon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numb_SoLuongMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietgoimon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_monan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ban;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_goimon;
        private System.Windows.Forms.TextBox txt_magoimon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_chitietgoimon;
        private System.Windows.Forms.Button btn_suact;
        private System.Windows.Forms.Button btn_xoact;
        private System.Windows.Forms.Button btn_themct;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ctgoimon_magoimon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numb_SoLuongMon;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_maban;
        private System.Windows.Forms.TextBox txt_stt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMGOIMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maban;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiangoi;
    }
}