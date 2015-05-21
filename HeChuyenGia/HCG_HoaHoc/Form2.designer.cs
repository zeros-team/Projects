namespace HCG_HoaHoc
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btGiai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuristicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLamLai = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolduongdan = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataHienThi = new System.Windows.Forms.DataGridView();
            this.ColumChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumYNghia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtSuyDien = new System.Windows.Forms.RichTextBox();
            this.lbTheo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btGiai
            // 
            this.btGiai.Location = new System.Drawing.Point(150, 104);
            this.btGiai.Margin = new System.Windows.Forms.Padding(4);
            this.btGiai.Name = "btGiai";
            this.btGiai.Size = new System.Drawing.Size(136, 39);
            this.btGiai.TabIndex = 0;
            this.btGiai.Text = "Giải";
            this.btGiai.UseVisualStyleBackColor = true;
            this.btGiai.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giả thiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết luận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suy diễn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1009, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyLuatToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // quanLyLuatToolStripMenuItem
            // 
            this.quanLyLuatToolStripMenuItem.Name = "quanLyLuatToolStripMenuItem";
            this.quanLyLuatToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.quanLyLuatToolStripMenuItem.Text = "Quản lý luật";
            this.quanLyLuatToolStripMenuItem.Click += new System.EventHandler(this.quanLyLuatToolStripMenuItem_Click);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.stackToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.heuristicToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.CheckOnClick = true;
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.CheckOnClick = true;
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // stackToolStripMenuItem
            // 
            this.stackToolStripMenuItem.CheckOnClick = true;
            this.stackToolStripMenuItem.Name = "stackToolStripMenuItem";
            this.stackToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.stackToolStripMenuItem.Text = "Stack";
            this.stackToolStripMenuItem.Click += new System.EventHandler(this.stackToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.CheckOnClick = true;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // heuristicToolStripMenuItem
            // 
            this.heuristicToolStripMenuItem.Name = "heuristicToolStripMenuItem";
            this.heuristicToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.heuristicToolStripMenuItem.Text = "Heuristic";
            this.heuristicToolStripMenuItem.Click += new System.EventHandler(this.heuristicToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 23);
            this.textBox2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLamLai);
            this.groupBox1.Controls.Add(this.btGiai);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(302, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // btLamLai
            // 
            this.btLamLai.Location = new System.Drawing.Point(17, 104);
            this.btLamLai.Margin = new System.Windows.Forms.Padding(4);
            this.btLamLai.Name = "btLamLai";
            this.btLamLai.Size = new System.Drawing.Size(133, 39);
            this.btLamLai.TabIndex = 12;
            this.btLamLai.Text = "Làm lại";
            this.btLamLai.UseVisualStyleBackColor = true;
            this.btLamLai.Click += new System.EventHandler(this.btLamLai_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolduongdan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel1.Text = "Tập tin dữ liệu";
            // 
            // toolduongdan
            // 
            this.toolduongdan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolduongdan.Name = "toolduongdan";
            this.toolduongdan.Size = new System.Drawing.Size(0, 17);
            // 
            // dataHienThi
            // 
            this.dataHienThi.AllowUserToAddRows = false;
            this.dataHienThi.AllowUserToDeleteRows = false;
            this.dataHienThi.AllowUserToResizeRows = false;
            this.dataHienThi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataHienThi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHienThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumChat,
            this.ColumYNghia});
            this.dataHienThi.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataHienThi.EnableHeadersVisualStyles = false;
            this.dataHienThi.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataHienThi.Location = new System.Drawing.Point(32, 209);
            this.dataHienThi.Name = "dataHienThi";
            this.dataHienThi.ReadOnly = true;
            this.dataHienThi.RowHeadersVisible = false;
            this.dataHienThi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataHienThi.Size = new System.Drawing.Size(302, 372);
            this.dataHienThi.TabIndex = 15;
            // 
            // ColumChat
            // 
            this.ColumChat.DataPropertyName = "KyHieu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumChat.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumChat.HeaderText = "Ký hiệu";
            this.ColumChat.Name = "ColumChat";
            this.ColumChat.ReadOnly = true;
            this.ColumChat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumChat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumYNghia
            // 
            this.ColumYNghia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumYNghia.DataPropertyName = "YNghia";
            this.ColumYNghia.HeaderText = "Ý Nghĩa";
            this.ColumYNghia.Name = "ColumYNghia";
            this.ColumYNghia.ReadOnly = true;
            this.ColumYNghia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumYNghia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rtSuyDien
            // 
            this.rtSuyDien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtSuyDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.rtSuyDien.Location = new System.Drawing.Point(360, 94);
            this.rtSuyDien.Name = "rtSuyDien";
            this.rtSuyDien.Size = new System.Drawing.Size(624, 487);
            this.rtSuyDien.TabIndex = 16;
            this.rtSuyDien.Text = "";
            this.rtSuyDien.WordWrap = false;
            // 
            // lbTheo
            // 
            this.lbTheo.AutoSize = true;
            this.lbTheo.BackColor = System.Drawing.Color.Transparent;
            this.lbTheo.ForeColor = System.Drawing.Color.Blue;
            this.lbTheo.Location = new System.Drawing.Point(414, 72);
            this.lbTheo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTheo.Name = "lbTheo";
            this.lbTheo.Size = new System.Drawing.Size(0, 16);
            this.lbTheo.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(722, 595);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 22);
            this.progressBar1.TabIndex = 18;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1009, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbTheo);
            this.Controls.Add(this.rtSuyDien);
            this.Controls.Add(this.dataHienThi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều chế chất hóa học";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGiai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.Button btLamLai;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolduongdan;
        private System.Windows.Forms.DataGridView dataHienThi;
        private System.Windows.Forms.RichTextBox rtSuyDien;
        private System.Windows.Forms.Label lbTheo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumYNghia;
        private System.Windows.Forms.ToolStripMenuItem heuristicToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}