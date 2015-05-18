namespace LSharpDB.com
{
    partial class MainWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.assemListview = new System.Windows.Forms.ListView();
            this.cType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGithub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cVote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.installRightClickMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.githubRightClickMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.waitPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lSharpDBLink = new System.Windows.Forms.Label();
            this.RightClickMenu.SuspendLayout();
            this.waitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // assemListview
            // 
            this.assemListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assemListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cType,
            this.cName,
            this.cGithub,
            this.cVote});
            this.assemListview.ContextMenuStrip = this.RightClickMenu;
            this.assemListview.FullRowSelect = true;
            this.assemListview.GridLines = true;
            this.assemListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.assemListview.LabelWrap = false;
            this.assemListview.Location = new System.Drawing.Point(12, 42);
            this.assemListview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assemListview.MultiSelect = false;
            this.assemListview.Name = "assemListview";
            this.assemListview.Size = new System.Drawing.Size(616, 337);
            this.assemListview.TabIndex = 0;
            this.assemListview.UseCompatibleStateImageBehavior = false;
            this.assemListview.View = System.Windows.Forms.View.Details;
            // 
            // cType
            // 
            this.cType.Text = "Type";
            this.cType.Width = 84;
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 150;
            // 
            // cGithub
            // 
            this.cGithub.Text = "Github";
            this.cGithub.Width = 320;
            // 
            // cVote
            // 
            this.cVote.Text = "Vote";
            this.cVote.Width = 40;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installRightClickMenu,
            this.githubRightClickMenu,
            this.refreshToolStripMenuItem});
            this.RightClickMenu.Name = "contextMenuStrip1";
            this.RightClickMenu.Size = new System.Drawing.Size(114, 70);
            // 
            // installRightClickMenu
            // 
            this.installRightClickMenu.Name = "installRightClickMenu";
            this.installRightClickMenu.Size = new System.Drawing.Size(113, 22);
            this.installRightClickMenu.Text = "Install";
            this.installRightClickMenu.Click += new System.EventHandler(this.installRightClickMenu_Click);
            // 
            // githubRightClickMenu
            // 
            this.githubRightClickMenu.Name = "githubRightClickMenu";
            this.githubRightClickMenu.Size = new System.Drawing.Size(113, 22);
            this.githubRightClickMenu.Text = "Github";
            this.githubRightClickMenu.Click += new System.EventHandler(this.githubRightClickMenu_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(206, 210);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            // 
            // waitPanel
            // 
            this.waitPanel.Controls.Add(this.progressBar1);
            this.waitPanel.Controls.Add(this.label1);
            this.waitPanel.Location = new System.Drawing.Point(0, 0);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(640, 391);
            this.waitPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please wait...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(253, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(375, 23);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(203, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // lSharpDBLink
            // 
            this.lSharpDBLink.AutoSize = true;
            this.lSharpDBLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSharpDBLink.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lSharpDBLink.ForeColor = System.Drawing.Color.Navy;
            this.lSharpDBLink.Location = new System.Drawing.Point(12, 14);
            this.lSharpDBLink.Name = "lSharpDBLink";
            this.lSharpDBLink.Size = new System.Drawing.Size(180, 17);
            this.lSharpDBLink.TabIndex = 6;
            this.lSharpDBLink.Text = "DB Provider: LSharpDB.com";
            this.lSharpDBLink.Click += new System.EventHandler(this.lSharpDBLink_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 392);
            this.Controls.Add(this.waitPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lSharpDBLink);
            this.Controls.Add(this.assemListview);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit by lehuan94cntt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.RightClickMenu.ResumeLayout(false);
            this.waitPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView assemListview;
        private System.Windows.Forms.ColumnHeader cType;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cGithub;
        private System.Windows.Forms.ColumnHeader cVote;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem installRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem githubRightClickMenu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel waitPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lSharpDBLink;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

