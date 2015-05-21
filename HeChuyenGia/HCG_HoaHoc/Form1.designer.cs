namespace HCG_HoaHoc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_YNghia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumYNghia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_luat = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumGiaThiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLuat = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tab_luat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabLuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(498, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đường dẫn";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(688, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "    Công Thức    ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Colum_YNghia});
            this.dataGridView3.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.Location = new System.Drawing.Point(9, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.Size = new System.Drawing.Size(673, 374);
            this.dataGridView3.TabIndex = 14;
            // 
            // Column_ID
            // 
            this.Column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ID.DataPropertyName = "ID";
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // Colum_YNghia
            // 
            this.Colum_YNghia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colum_YNghia.DataPropertyName = "YNghia";
            this.Colum_YNghia.HeaderText = "Y Nghia";
            this.Colum_YNghia.Name = "Colum_YNghia";
            this.Colum_YNghia.ReadOnly = true;
            // 
            // tabChat
            // 
            this.tabChat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabChat.Controls.Add(this.dataGridView2);
            this.tabChat.Location = new System.Drawing.Point(4, 44);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChat.Size = new System.Drawing.Size(688, 393);
            this.tabChat.TabIndex = 1;
            this.tabChat.Text = "         Chất         ";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumChat,
            this.ColumYNghia});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(9, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(673, 372);
            this.dataGridView2.TabIndex = 12;
            // 
            // ColumChat
            // 
            this.ColumChat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumChat.DataPropertyName = "KyHieu";
            this.ColumChat.HeaderText = "Ky Hieu";
            this.ColumChat.Name = "ColumChat";
            this.ColumChat.ReadOnly = true;
            // 
            // ColumYNghia
            // 
            this.ColumYNghia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumYNghia.DataPropertyName = "YNghia";
            this.ColumYNghia.HeaderText = "Y Nghia";
            this.ColumYNghia.Name = "ColumYNghia";
            this.ColumYNghia.ReadOnly = true;
            // 
            // tab_luat
            // 
            this.tab_luat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tab_luat.Controls.Add(this.dataGridView1);
            this.tab_luat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_luat.Location = new System.Drawing.Point(4, 44);
            this.tab_luat.Name = "tab_luat";
            this.tab_luat.Padding = new System.Windows.Forms.Padding(3);
            this.tab_luat.Size = new System.Drawing.Size(688, 393);
            this.tab_luat.TabIndex = 0;
            this.tab_luat.Text = "         Luật         ";
            this.tab_luat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columID,
            this.ColumGiaThiet,
            this.ColumKetLuan});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(9, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(673, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // columID
            // 
            this.columID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columID.DataPropertyName = "ID";
            this.columID.HeaderText = "ID";
            this.columID.Name = "columID";
            this.columID.ReadOnly = true;
            // 
            // ColumGiaThiet
            // 
            this.ColumGiaThiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumGiaThiet.DataPropertyName = "GiaThiet";
            this.ColumGiaThiet.HeaderText = "Giả thiết";
            this.ColumGiaThiet.Name = "ColumGiaThiet";
            this.ColumGiaThiet.ReadOnly = true;
            // 
            // ColumKetLuan
            // 
            this.ColumKetLuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumKetLuan.DataPropertyName = "KetLuan";
            this.ColumKetLuan.HeaderText = "Kết luận";
            this.ColumKetLuan.Name = "ColumKetLuan";
            this.ColumKetLuan.ReadOnly = true;
            // 
            // tabLuat
            // 
            this.tabLuat.Controls.Add(this.tab_luat);
            this.tabLuat.Controls.Add(this.tabChat);
            this.tabLuat.Controls.Add(this.tabPage3);
            this.tabLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLuat.ItemSize = new System.Drawing.Size(120, 40);
            this.tabLuat.Location = new System.Drawing.Point(28, 80);
            this.tabLuat.Name = "tabLuat";
            this.tabLuat.SelectedIndex = 0;
            this.tabLuat.Size = new System.Drawing.Size(696, 441);
            this.tabLuat.TabIndex = 4;
            this.tabLuat.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabLuat_Selected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(736, 533);
            this.Controls.Add(this.tabLuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Quản lý luật";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tab_luat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabLuat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_YNghia;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumYNghia;
        private System.Windows.Forms.TabPage tab_luat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumGiaThiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumKetLuan;
        private System.Windows.Forms.TabControl tabLuat;
    }
}

