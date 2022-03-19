namespace QLDT_Winform_ADO
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
            this.cb_chonhang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.checkb_cngia = new System.Windows.Forms.CheckBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.dataGV_dt = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDongDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoadongdienthoai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_soluongdt = new System.Windows.Forms.Label();
            this.nud_tonkho = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_dt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tonkho)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_chonhang
            // 
            this.cb_chonhang.FormattingEnabled = true;
            this.cb_chonhang.Location = new System.Drawing.Point(79, 23);
            this.cb_chonhang.Name = "cb_chonhang";
            this.cb_chonhang.Size = new System.Drawing.Size(379, 21);
            this.cb_chonhang.TabIndex = 0;
            this.cb_chonhang.SelectedIndexChanged += new System.EventHandler(this.cb_chonhang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Hãng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_tonkho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.checkb_cngia);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Location = new System.Drawing.Point(15, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật giá - tồn kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tồn kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(73, 25);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(183, 20);
            this.txt_gia.TabIndex = 2;
            this.txt_gia.TextChanged += new System.EventHandler(this.txt_gia_TextChanged);
            // 
            // checkb_cngia
            // 
            this.checkb_cngia.AutoSize = true;
            this.checkb_cngia.Location = new System.Drawing.Point(332, 31);
            this.checkb_cngia.Name = "checkb_cngia";
            this.checkb_cngia.Size = new System.Drawing.Size(86, 17);
            this.checkb_cngia.TabIndex = 1;
            this.checkb_cngia.Text = "Cập nhật giá";
            this.checkb_cngia.UseVisualStyleBackColor = true;
            this.checkb_cngia.CheckedChanged += new System.EventHandler(this.checkb_cngia_CheckedChanged);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(332, 54);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(105, 23);
            this.btn_capnhat.TabIndex = 0;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // dataGV_dt
            // 
            this.dataGV_dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.TenDongDT,
            this.DonGia,
            this.TonKho});
            this.dataGV_dt.Location = new System.Drawing.Point(15, 59);
            this.dataGV_dt.Name = "dataGV_dt";
            this.dataGV_dt.Size = new System.Drawing.Size(443, 208);
            this.dataGV_dt.TabIndex = 2;
            this.dataGV_dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_dt_CellClick);
            this.dataGV_dt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_dt_CellContentClick);
            // 
            // MA
            // 
            this.MA.DataPropertyName = "Ma";
            this.MA.HeaderText = "Mã";
            this.MA.MinimumWidth = 2;
            this.MA.Name = "MA";
            // 
            // TenDongDT
            // 
            this.TenDongDT.DataPropertyName = "TenDT";
            this.TenDongDT.HeaderText = "Tên Dòng Điện Thoại";
            this.TenDongDT.Name = "TenDongDT";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // TonKho
            // 
            this.TonKho.DataPropertyName = "TonKho";
            this.TonKho.HeaderText = "Tồn Kho";
            this.TonKho.Name = "TonKho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoadongdienthoai);
            this.groupBox2.Location = new System.Drawing.Point(15, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngừng bán dòng điện thoại";
            // 
            // btn_xoadongdienthoai
            // 
            this.btn_xoadongdienthoai.Location = new System.Drawing.Point(295, 12);
            this.btn_xoadongdienthoai.Name = "btn_xoadongdienthoai";
            this.btn_xoadongdienthoai.Size = new System.Drawing.Size(148, 23);
            this.btn_xoadongdienthoai.TabIndex = 0;
            this.btn_xoadongdienthoai.Text = "Xóa dòng điện thoại";
            this.btn_xoadongdienthoai.UseVisualStyleBackColor = true;
            this.btn_xoadongdienthoai.Click += new System.EventHandler(this.btn_xoadongdienthoai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng điện thoại của hãng: ";
            // 
            // lb_soluongdt
            // 
            this.lb_soluongdt.AutoSize = true;
            this.lb_soluongdt.Location = new System.Drawing.Point(161, 279);
            this.lb_soluongdt.Name = "lb_soluongdt";
            this.lb_soluongdt.Size = new System.Drawing.Size(16, 13);
            this.lb_soluongdt.TabIndex = 6;
            this.lb_soluongdt.Text = "...";
            this.lb_soluongdt.Click += new System.EventHandler(this.lb_soluongdt_Click);
            // 
            // nud_tonkho
            // 
            this.nud_tonkho.Location = new System.Drawing.Point(73, 52);
            this.nud_tonkho.Name = "nud_tonkho";
            this.nud_tonkho.Size = new System.Drawing.Size(183, 20);
            this.nud_tonkho.TabIndex = 6;
            this.nud_tonkho.ValueChanged += new System.EventHandler(this.nud_tonkho_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 489);
            this.Controls.Add(this.lb_soluongdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGV_dt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_chonhang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_dt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_tonkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_chonhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkb_cngia;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.DataGridView dataGV_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoadongdienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDongDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_soluongdt;
        private System.Windows.Forms.NumericUpDown nud_tonkho;
    }
}

