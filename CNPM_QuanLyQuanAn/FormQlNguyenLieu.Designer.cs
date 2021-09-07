namespace CNPM_QuanLyQuanAn
{
    partial class FormQlNguyenLieu
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
            this.btn_nguyenlieu_xoa = new System.Windows.Forms.Button();
            this.btn_nguyenlieu_them = new System.Windows.Forms.Button();
            this.dgv_nguyenlieu = new System.Windows.Forms.DataGridView();
            this.txt_nguyenlieu_tennl = new System.Windows.Forms.TextBox();
            this.txt_nguyenlieu_manl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nguyenlieu_timkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nguyenlieu_dvt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nguyenlieu_xoa
            // 
            this.btn_nguyenlieu_xoa.Location = new System.Drawing.Point(261, 174);
            this.btn_nguyenlieu_xoa.Name = "btn_nguyenlieu_xoa";
            this.btn_nguyenlieu_xoa.Size = new System.Drawing.Size(115, 23);
            this.btn_nguyenlieu_xoa.TabIndex = 14;
            this.btn_nguyenlieu_xoa.Text = "Xóa";
            this.btn_nguyenlieu_xoa.UseVisualStyleBackColor = true;
            this.btn_nguyenlieu_xoa.Click += new System.EventHandler(this.btn_nguyenlieu_xoa_Click);
            // 
            // btn_nguyenlieu_them
            // 
            this.btn_nguyenlieu_them.Location = new System.Drawing.Point(89, 174);
            this.btn_nguyenlieu_them.Name = "btn_nguyenlieu_them";
            this.btn_nguyenlieu_them.Size = new System.Drawing.Size(115, 23);
            this.btn_nguyenlieu_them.TabIndex = 13;
            this.btn_nguyenlieu_them.Text = "Thêm";
            this.btn_nguyenlieu_them.UseVisualStyleBackColor = true;
            this.btn_nguyenlieu_them.Click += new System.EventHandler(this.btn_nguyenlieu_them_Click);
            // 
            // dgv_nguyenlieu
            // 
            this.dgv_nguyenlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguyenlieu.Location = new System.Drawing.Point(12, 216);
            this.dgv_nguyenlieu.Name = "dgv_nguyenlieu";
            this.dgv_nguyenlieu.RowTemplate.Height = 24;
            this.dgv_nguyenlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nguyenlieu.Size = new System.Drawing.Size(756, 245);
            this.dgv_nguyenlieu.TabIndex = 12;
            this.dgv_nguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nguyenlieu_CellClick);
            // 
            // txt_nguyenlieu_tennl
            // 
            this.txt_nguyenlieu_tennl.Location = new System.Drawing.Point(170, 76);
            this.txt_nguyenlieu_tennl.Name = "txt_nguyenlieu_tennl";
            this.txt_nguyenlieu_tennl.Size = new System.Drawing.Size(256, 22);
            this.txt_nguyenlieu_tennl.TabIndex = 11;
            // 
            // txt_nguyenlieu_manl
            // 
            this.txt_nguyenlieu_manl.Location = new System.Drawing.Point(170, 39);
            this.txt_nguyenlieu_manl.Name = "txt_nguyenlieu_manl";
            this.txt_nguyenlieu_manl.Size = new System.Drawing.Size(256, 22);
            this.txt_nguyenlieu_manl.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // btn_nguyenlieu_timkiem
            // 
            this.btn_nguyenlieu_timkiem.Location = new System.Drawing.Point(536, 174);
            this.btn_nguyenlieu_timkiem.Name = "btn_nguyenlieu_timkiem";
            this.btn_nguyenlieu_timkiem.Size = new System.Drawing.Size(115, 23);
            this.btn_nguyenlieu_timkiem.TabIndex = 16;
            this.btn_nguyenlieu_timkiem.Text = "Tìm kiếm";
            this.btn_nguyenlieu_timkiem.UseVisualStyleBackColor = true;
            this.btn_nguyenlieu_timkiem.Click += new System.EventHandler(this.btn_nguyenlieu_timkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đơn vị tính";
            // 
            // txt_nguyenlieu_dvt
            // 
            this.txt_nguyenlieu_dvt.Location = new System.Drawing.Point(170, 115);
            this.txt_nguyenlieu_dvt.Name = "txt_nguyenlieu_dvt";
            this.txt_nguyenlieu_dvt.Size = new System.Drawing.Size(256, 22);
            this.txt_nguyenlieu_dvt.TabIndex = 18;
            // 
            // FormQlNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.txt_nguyenlieu_dvt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_nguyenlieu_timkiem);
            this.Controls.Add(this.btn_nguyenlieu_xoa);
            this.Controls.Add(this.btn_nguyenlieu_them);
            this.Controls.Add(this.dgv_nguyenlieu);
            this.Controls.Add(this.txt_nguyenlieu_tennl);
            this.Controls.Add(this.txt_nguyenlieu_manl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQlNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQlNguyenLieu";
            this.Load += new System.EventHandler(this.FormQlNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguyenlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nguyenlieu_xoa;
        private System.Windows.Forms.Button btn_nguyenlieu_them;
        private System.Windows.Forms.DataGridView dgv_nguyenlieu;
        private System.Windows.Forms.TextBox txt_nguyenlieu_tennl;
        private System.Windows.Forms.TextBox txt_nguyenlieu_manl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nguyenlieu_timkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nguyenlieu_dvt;
    }
}