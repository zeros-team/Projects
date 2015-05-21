namespace HCG_KHMT2_K7
{
    partial class frmLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuat));
            this.btThemVT = new System.Windows.Forms.Button();
            this.btHuyChon = new System.Windows.Forms.Button();
            this.btThemVP = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSukien = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLuat = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThemVT
            // 
            this.btThemVT.Image = ((System.Drawing.Image)(resources.GetObject("btThemVT.Image")));
            this.btThemVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemVT.Location = new System.Drawing.Point(17, 132);
            this.btThemVT.Margin = new System.Windows.Forms.Padding(4);
            this.btThemVT.Name = "btThemVT";
            this.btThemVT.Size = new System.Drawing.Size(107, 34);
            this.btThemVT.TabIndex = 18;
            this.btThemVT.Text = "Thêm vế trái";
            this.btThemVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemVT.UseVisualStyleBackColor = true;
            this.btThemVT.Click += new System.EventHandler(this.btThemVT_Click_1);
            // 
            // btHuyChon
            // 
            this.btHuyChon.Image = ((System.Drawing.Image)(resources.GetObject("btHuyChon.Image")));
            this.btHuyChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuyChon.Location = new System.Drawing.Point(249, 132);
            this.btHuyChon.Margin = new System.Windows.Forms.Padding(4);
            this.btHuyChon.Name = "btHuyChon";
            this.btHuyChon.Size = new System.Drawing.Size(91, 34);
            this.btHuyChon.TabIndex = 17;
            this.btHuyChon.Text = "Hủy chọn";
            this.btHuyChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuyChon.UseVisualStyleBackColor = true;
            this.btHuyChon.Click += new System.EventHandler(this.btHuyChon_Click_1);
            // 
            // btThemVP
            // 
            this.btThemVP.Image = ((System.Drawing.Image)(resources.GetObject("btThemVP.Image")));
            this.btThemVP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemVP.Location = new System.Drawing.Point(132, 132);
            this.btThemVP.Margin = new System.Windows.Forms.Padding(4);
            this.btThemVP.Name = "btThemVP";
            this.btThemVP.Size = new System.Drawing.Size(109, 34);
            this.btThemVP.TabIndex = 16;
            this.btThemVP.Text = "Thêm vế phải";
            this.btThemVP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemVP.UseVisualStyleBackColor = true;
            this.btThemVP.Click += new System.EventHandler(this.btThemVP_Click_1);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngữ nghĩa";
            this.columnHeader4.Width = 335;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sự kiện";
            this.columnHeader3.Width = 107;
            // 
            // listSukien
            // 
            this.listSukien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listSukien.Location = new System.Drawing.Point(8, 21);
            this.listSukien.Margin = new System.Windows.Forms.Padding(4);
            this.listSukien.Name = "listSukien";
            this.listSukien.Size = new System.Drawing.Size(428, 182);
            this.listSukien.TabIndex = 0;
            this.listSukien.UseCompatibleStateImageBehavior = false;
            this.listSukien.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listSukien);
            this.groupBox3.Location = new System.Drawing.Point(396, 218);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(444, 211);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sự kiện";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vế Phải";
            this.columnHeader2.Width = 535;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vế Trái";
            this.columnHeader1.Width = 162;
            // 
            // listLuat
            // 
            this.listLuat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listLuat.Location = new System.Drawing.Point(10, 16);
            this.listLuat.Margin = new System.Windows.Forms.Padding(4);
            this.listLuat.Name = "listLuat";
            this.listLuat.Size = new System.Drawing.Size(426, 174);
            this.listLuat.TabIndex = 1;
            this.listLuat.UseCompatibleStateImageBehavior = false;
            this.listLuat.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listLuat);
            this.groupBox2.Location = new System.Drawing.Point(396, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(444, 202);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các luật";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(107, 87);
            this.txtVP.Margin = new System.Windows.Forms.Padding(4);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(225, 20);
            this.txtVP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vế phải";
            // 
            // txtVT
            // 
            this.txtVT.Location = new System.Drawing.Point(109, 43);
            this.txtVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(225, 20);
            this.txtVT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vế trái";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVT);
            this.groupBox1.Controls.Add(this.btHuyChon);
            this.groupBox1.Controls.Add(this.btThemVT);
            this.groupBox1.Controls.Add(this.btThemVP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(354, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm thông tin tập luật";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btHuy);
            this.groupBox4.Controls.Add(this.btXoa);
            this.groupBox4.Controls.Add(this.btSua);
            this.groupBox4.Controls.Add(this.btThoat);
            this.groupBox4.Controls.Add(this.btThem);
            this.groupBox4.Controls.Add(this.btLuu);
            this.groupBox4.Location = new System.Drawing.Point(15, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 211);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác";
            // 
            // btHuy
            // 
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(14, 148);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(143, 42);
            this.btHuy.TabIndex = 22;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(14, 82);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(143, 42);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(190, 21);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(143, 42);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(191, 148);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(143, 42);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(14, 21);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(143, 42);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(190, 82);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(143, 42);
            this.btLuu.TabIndex = 23;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // frmLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 440);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLuat";
            this.Text = "frmLuat";
            this.Load += new System.EventHandler(this.frmLuat_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThemVT;
        private System.Windows.Forms.Button btHuyChon;
        private System.Windows.Forms.Button btThemVP;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listSukien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listLuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;

    }
}