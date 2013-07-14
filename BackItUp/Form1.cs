using MonoTorrent;
using MonoTorrent.BEncoding;
using MonoTorrent.Client;
using MonoTorrent.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackItUp
{
    public partial class Form1 : Form
    {

        private ClientEngine engine;
        private Dictionary<DirectoryInfo, FileSystemWatcher> watchers = new Dictionary<DirectoryInfo, FileSystemWatcher>();
        private Dictionary<DirectoryInfo, Torrent> torrents = new Dictionary<DirectoryInfo, Torrent>();
        private Dictionary<DirectoryInfo, TorrentManager> mgrs = new Dictionary<DirectoryInfo, TorrentManager>();

        public Form1()
        {
            InitializeComponent();
            ListDirectory(treeView1, "C:/");
            EngineSettings es = new EngineSettings();
            es.AllowedEncryption = MonoTorrent.Client.Encryption.EncryptionTypes.All;
            es.PreferEncryption = true;
            engine = new ClientEngine(es);
            engine.StartAll();
            
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            TreeNode directoryNode = new TreeNode(rootDirectoryInfo.Name);
            directoryNode.Tag = rootDirectoryInfo;
            treeView.Nodes.Add(directoryNode);
            CreateDirectoryNode(directoryNode);
        }

        private void ExpandDirectory(TreeNode node)
        {
            var directoryInfo = node.Tag as DirectoryInfo;
            node.Nodes.Clear();
            CreateDirectoryNode(node);
        }

        private static void CreateDirectoryNode(TreeNode directoryNode)
        {
            var directoryInfo = directoryNode.Tag as DirectoryInfo;
            try
            {
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var idn = new TreeNode(directory.Name);
                    idn.Tag = directory;
                    directoryNode.Nodes.Add(idn);
                }
                foreach (var file in directoryInfo.GetFiles())
                {
                    directoryNode.Nodes.Add(new TreeNode(file.Name));
                }
            }
            catch (Exception) { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode t = e.Node;
            ExpandDirectory(t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo di = e.Node.Tag as DirectoryInfo;
            if (di != null)
            {
                if (e.Node.Checked)
                {
                    if (!(watchers.ContainsKey(di)))
                    {
                        watchers.Add(di, new FileSystemWatcher(di.FullName));
                        watchers[di].BeginInit();
                        CreateTorrent(di);

                    }
                }
                else
                {
                    if (watchers.ContainsKey(di))
                    {
                        watchers.Remove(di);
                        var t = torrents[di];
                        torrents.Remove(di);
                    }
                }
            }
        }

        private void CreateTorrent(DirectoryInfo path)
        {
            TorrentCreator c = new TorrentCreator();

            RawTrackerTier tier = new RawTrackerTier();
            tier.Add("http://localhost/announce");
            c.Announces.Add(tier);
            c.Comment = "This is the comment";
            c.CreatedBy = "Doug using " + VersionInfo.ClientVersion;
            c.Publisher = "www.aaronsen.com";

            c.Private = true;

            c.Hashed += delegate(object o, TorrentCreatorEventArgs e)
            {
                Console.WriteLine("Current File is {0}% hashed", e.FileCompletion);
                Console.WriteLine("Overall {0}% hashed", e.OverallCompletion);
                Console.WriteLine("Total data to hash: {0}", e.OverallSize);
            };

            ITorrentFileSource fileSource = new TorrentFileSource(path.FullName);
            torrents.Add(path, Torrent.Load(c.Create(fileSource)));
        }

        private void LoadTorrent(String url) {
            Torrent torrent = Torrent.Load(new Uri(url),"tmp");
            TorrentManager m = new TorrentManager(torrent, "DOWN", new TorrentSettings());
            engine.StartAll();
        }

    }


}
