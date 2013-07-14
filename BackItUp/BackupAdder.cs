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
    public partial class BackupAdder : Form
    {
        public BackupAdder()
        {
            InitializeComponent();
        }

        public string Path { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ListDirectory(treeView1, Path);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
