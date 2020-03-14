using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DDD
{
    public partial class UCTreeList : UserControl
    {
        string space = " ";
        string dir;
        ContextMenuStrip MyMenu = new System.Windows.Forms.ContextMenuStrip();
        public UCTreeList(string directory)
        {
            InitializeComponent();
            dir = directory;
            MyMenu.Items.Add("Copy");
            MyMenu.Items.Add("Refresh");

            
        }

        private void TreeViewFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    //add files of rootdirectory

                    
                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);

                            foreach (var file in di.GetFiles())
                            {
                                FileInfo f = new FileInfo(dir + "\\" + file.Name);
                                TreeNode n = new TreeNode(file.Name + Spacing(f.Name.Length) + f.Length + " Bytes", 13, 13);
                                node.Nodes.Add(n);
                            }

                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                    DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());
                    foreach (var file in rootDir.GetFiles())
                    {

                        TreeNode n = new TreeNode(file.Name + Spacing(50) + file.Length + " Btye", 13, 13);
                        e.Node.Nodes.Add(n);
                    }
                }
            }
        }
        private string Spacing(int countSpace) {
            space = " ";
            for (int i = 0; i < countSpace + 1; i++)
            {
                space = space + " ";
            }
                return space;
        }
        private void UCTreeList_Load(object sender, EventArgs e)
        {

            //get a list of the drives
            //string dir = @"\\fileserver1\IN6\KBNL-Books2018\Book11_Batch18\MMKB35_000000004_1_01";

            TreeNode node = new TreeNode(dir, 6, 6);
            node.Tag = dir;

            node.Nodes.Add("...");
            TreeViewFolder.Nodes.Add(node);
          
        }

        private void TreeViewFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                Point point = new Point(e.X,e.Y);
                TreeViewFolder.SelectedNode=(TreeViewFolder.GetNodeAt(point));
                MyMenu.Show(e.X,e.Y+50);
            }
        }
    }
}
