using System;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace LSharpDB.com
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        const string apiServer = "http://lsharpdb.com/api/assemblies";

        static AutoCompleteStringCollection autoCompleteCollection;

        void MainWindow_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.favicon;
            Font = new System.Drawing.Font("Tahoma", 9f);

            waitPanel.Location = new System.Drawing.Point(0, 0);
            waitPanel.Size = ClientSize;

            CheckForIllegalCrossThreadCalls = false;

            new Thread(new ThreadStart(JustLoad)).Start();
        }

        void JustLoad()
        {
            waitPanel.Visible = true;

            Text = "[huanle94]Đang cập nhật Assembly- Đợi trong 69s...";

            assemListview.Items.Clear();

            string database = getHttpSource(apiServer);

            autoCompleteCollection = new AutoCompleteStringCollection();

            int i = 0;
            string champ = string.Empty;

            assemListview.BeginUpdate();

            foreach (var big in database.Split(new string[] { ":[", "]," }, StringSplitOptions.RemoveEmptyEntries))
            {
                i++;

                if (i % 2 != 0)
                {
                    champ = big.Replace("{", string.Empty).Replace("\"", string.Empty);
                    autoCompleteCollection.Add(champ);
                }
                else
                {
                    foreach (var small in big.Split(new string[] { "{", "}" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (small == "," || small == "]")
                            continue;

                        string name = small.Split(new string[] { "\"name\":\"", "\"," }, StringSplitOptions.RemoveEmptyEntries)[0];
                        string github = small.Split(new string[] { "Folder\":\"", "\",\"vote" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("\\", string.Empty).Replace("https://github.com/", string.Empty);
                        string vote = small.Split(new string[] { "\",\"votes\":", "}" }, StringSplitOptions.RemoveEmptyEntries)[1];

                        autoCompleteCollection.Add(name);
                        autoCompleteCollection.Add(github.Replace("/tree/master", string.Empty));

                        //var splittemp = github.Split('/');
                        //var commitdata = getHttpSource("https://api.github.com/repos/" + splittemp[0] + "/" + splittemp[1] + "/commits?path=" + splittemp[splittemp.Length - 1]);
                        //too slow and frigging limit . _.

                        addItems(champ, name, github, vote);
                    }
                }
            }

            assemListview.EndUpdate();

            Text = "[huanle94] Update xong ! Hiện tại có - " + assemListview.Items.Count + " Assemblies";

            searchBox.Invoke(new dele(setAutoCompleteCustomSource));

            waitPanel.Visible = false;
        }

        delegate void dele();
        void setAutoCompleteCustomSource()
        {
            searchBox.AutoCompleteCustomSource = autoCompleteCollection;
        }

        void addItems(string champion, string assemblyName, string gitHub, string Vote)
        {
            ListViewItem itemTemp = new ListViewItem(champion);
            itemTemp.SubItems.Add(assemblyName);
            itemTemp.SubItems.Add(gitHub == "0" ? "unknown" : gitHub.Replace("\\", string.Empty).Replace("https://github.com/", string.Empty));
            itemTemp.SubItems.Add(Vote);

            assemListview.Items.Add(itemTemp);
        }

        void searchBox_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem = assemListview.FindItemWithText(searchBox.Text, true, 0, true);

            if (foundItem != null)
                assemListview.TopItem = foundItem;
        }

        void lSharpDBLink_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "http://lsharpdb.com");
        }

        void installRightClickMenu_Click(object sender, EventArgs e)
        {
            if(assemListview.SelectedItems[0] != null)
                new WebBrowser().Navigate("ls://project/" + assemListview.SelectedItems[0].SubItems[2].Text.Replace("/tree/master", string.Empty));
        }

        void githubRightClickMenu_Click(object sender, EventArgs e)
        {
            if (assemListview.SelectedItems[0] != null)
                Process.Start("explorer", "https://github.com/" + assemListview.SelectedItems[0].SubItems[2].Text);
        }

        void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(JustLoad)).Start();
        }

        void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Process.GetCurrentProcess().Kill();
        }

        string getHttpSource(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "i'm huanle94";

            return new System.IO.StreamReader((req.GetResponse()).GetResponseStream(), System.Text.Encoding.Default).ReadToEnd();
        }
    }
}
