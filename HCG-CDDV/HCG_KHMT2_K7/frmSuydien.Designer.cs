namespace HCG_KHMT2_K7
{
    partial class frmSuydien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSukien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLoi = new System.Windows.Forms.TextBox();
            this.btnchuandoan = new System.Windows.Forms.Button();
            this.btnhuychon = new System.Windows.Forms.Button();
            this.btnthemchon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSukien);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(402, 484);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Nhận biết về loài vật cần tìm";
            // 
            // listSukien
            // 
            this.listSukien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listSukien.Location = new System.Drawing.Point(7, 23);
            this.listSukien.Name = "listSukien";
            this.listSukien.Size = new System.Drawing.Size(385, 453);
            this.listSukien.TabIndex = 0;
            this.listSukien.UseCompatibleStateImageBehavior = false;
            this.listSukien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sự kiện";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngữ nghĩa";
            this.columnHeader2.Width = 336;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtKetqua);
            this.groupBox2.Location = new System.Drawing.Point(444, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(636, 281);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình ảnh về loài vật được chuẩn đoán :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 211);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(8, 22);
            this.txtKetqua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(245, 251);
            this.txtKetqua.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLoi);
            this.groupBox3.Location = new System.Drawing.Point(528, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(373, 159);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xác nhận các nhận biết";
            // 
            // txtLoi
            // 
            this.txtLoi.Location = new System.Drawing.Point(8, 23);
            this.txtLoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoi.Multiline = true;
            this.txtLoi.Name = "txtLoi";
            this.txtLoi.Size = new System.Drawing.Size(357, 120);
            this.txtLoi.TabIndex = 0;
            // 
            // btnchuandoan
            // 
            this.btnchuandoan.Location = new System.Drawing.Point(650, 182);
            this.btnchuandoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnchuandoan.Name = "btnchuandoan";
            this.btnchuandoan.Size = new System.Drawing.Size(120, 37);
            this.btnchuandoan.TabIndex = 12;
            this.btnchuandoan.Text = "Chuẩn đoán";
            this.btnchuandoan.UseVisualStyleBackColor = true;
            this.btnchuandoan.Click += new System.EventHandler(this.btnchuandoan_Click);
            // 
            // btnhuychon
            // 
            this.btnhuychon.Location = new System.Drawing.Point(423, 123);
            this.btnhuychon.Name = "btnhuychon";
            this.btnhuychon.Size = new System.Drawing.Size(98, 35);
            this.btnhuychon.TabIndex = 18;
            this.btnhuychon.Text = "Hủy chọn";
            this.btnhuychon.UseVisualStyleBackColor = true;
            this.btnhuychon.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // btnthemchon
            // 
            this.btnthemchon.Location = new System.Drawing.Point(423, 71);
            this.btnthemchon.Name = "btnthemchon";
            this.btnthemchon.Size = new System.Drawing.Size(98, 35);
            this.btnthemchon.TabIndex = 17;
            this.btnthemchon.Text = "Thêm chọn";
            this.btnthemchon.UseVisualStyleBackColor = true;
            this.btnthemchon.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(778, 182);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 19;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSuydien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnchuandoan);
            this.Controls.Add(this.btnhuychon);
            this.Controls.Add(this.btnthemchon);
            this.Name = "frmSuydien";
            this.Text = "frmSuydien";
            this.Load += new System.EventHandler(this.frmSuydien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listSukien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLoi;
        private System.Windows.Forms.Button btnchuandoan;
        private System.Windows.Forms.Button btnhuychon;
        private System.Windows.Forms.Button btnthemchon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}