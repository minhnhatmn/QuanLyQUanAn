namespace CNPM_QuanLyQuanAn
{
    partial class FormBan
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
            this.btn_ban_sua = new System.Windows.Forms.Button();
            this.btn_ban_xoa = new System.Windows.Forms.Button();
            this.btn_ban_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ban_maban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ban = new System.Windows.Forms.DataGridView();
            this.cbo_loaiban = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ban_sua
            // 
            this.btn_ban_sua.Location = new System.Drawing.Point(402, 419);
            this.btn_ban_sua.Name = "btn_ban_sua";
            this.btn_ban_sua.Size = new System.Drawing.Size(78, 37);
            this.btn_ban_sua.TabIndex = 48;
            this.btn_ban_sua.Text = "Sửa";
            this.btn_ban_sua.UseVisualStyleBackColor = true;
            this.btn_ban_sua.Click += new System.EventHandler(this.btn_ban_sua_Click);
            // 
            // btn_ban_xoa
            // 
            this.btn_ban_xoa.Location = new System.Drawing.Point(318, 419);
            this.btn_ban_xoa.Name = "btn_ban_xoa";
            this.btn_ban_xoa.Size = new System.Drawing.Size(78, 37);
            this.btn_ban_xoa.TabIndex = 47;
            this.btn_ban_xoa.Text = "Xoá";
            this.btn_ban_xoa.UseVisualStyleBackColor = true;
            this.btn_ban_xoa.Click += new System.EventHandler(this.btn_ban_xoa_Click);
            // 
            // btn_ban_them
            // 
            this.btn_ban_them.Location = new System.Drawing.Point(234, 419);
            this.btn_ban_them.Name = "btn_ban_them";
            this.btn_ban_them.Size = new System.Drawing.Size(78, 37);
            this.btn_ban_them.TabIndex = 46;
            this.btn_ban_them.Text = "Thêm";
            this.btn_ban_them.UseVisualStyleBackColor = true;
            this.btn_ban_them.Click += new System.EventHandler(this.btn_ban_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Loại bàn";
            // 
            // txt_ban_maban
            // 
            this.txt_ban_maban.Location = new System.Drawing.Point(292, 345);
            this.txt_ban_maban.Name = "txt_ban_maban";
            this.txt_ban_maban.Size = new System.Drawing.Size(198, 22);
            this.txt_ban_maban.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã bàn";
            // 
            // dgv_ban
            // 
            this.dgv_ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ban.Location = new System.Drawing.Point(12, 12);
            this.dgv_ban.Name = "dgv_ban";
            this.dgv_ban.RowTemplate.Height = 24;
            this.dgv_ban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ban.Size = new System.Drawing.Size(776, 248);
            this.dgv_ban.TabIndex = 41;
            this.dgv_ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ban_CellClick);
            // 
            // cbo_loaiban
            // 
            this.cbo_loaiban.FormattingEnabled = true;
            this.cbo_loaiban.Location = new System.Drawing.Point(292, 373);
            this.cbo_loaiban.Name = "cbo_loaiban";
            this.cbo_loaiban.Size = new System.Drawing.Size(198, 24);
            this.cbo_loaiban.TabIndex = 49;
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.cbo_loaiban);
            this.Controls.Add(this.btn_ban_sua);
            this.Controls.Add(this.btn_ban_xoa);
            this.Controls.Add(this.btn_ban_them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ban_maban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ban);
            this.Name = "FormBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBan";
            this.Load += new System.EventHandler(this.FormBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ban_sua;
        private System.Windows.Forms.Button btn_ban_xoa;
        private System.Windows.Forms.Button btn_ban_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ban_maban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ban;
        private System.Windows.Forms.ComboBox cbo_loaiban;
    }
}