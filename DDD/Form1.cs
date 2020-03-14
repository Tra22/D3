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

namespace DDD
{
    public partial class Form1 : Form
    {
        Store s = new Store();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UCTreeList list = new UCTreeList();
            //list.Dock = DockStyle.Fill;
            //panelSourceTree.Controls.Add(list);
            //UCTreeList lists = new UCTreeList();
            //lists.Dock = DockStyle.Fill;
            //panelDirectoryTree.Controls.Add(lists);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Do you want to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exitResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSource_Enter(object sender, EventArgs e)
        {
            textBoxHint(txtSource,"Source path","Source path",1);
           
        }

        private void txtSource_Leave(object sender, EventArgs e)
        {
            textBoxHint(txtSource,"Source path","",2);
            if (txtSource.Text != "" && Directory.Exists(txtSource.Text))
            {
                string path = "";
                if (s.Firstpath == "")
                {
                    s.Firstpath = txtSource.Text;
                    path = s.Firstpath;
                }
                else
                {
                    s.Secondpath = txtSource.Text;
                    path = s.Secondpath;
                }
                panelSourceTree.Controls.Clear();
                UCTreeList list = new UCTreeList(path);
                list.Dock = DockStyle.Fill;
                panelSourceTree.Controls.Add(list);
            }
            else
            {
                panelSourceTree.Controls.Clear();
            }
        }

       
        private void txtDirectory_Enter(object sender, EventArgs e)
        {
            textBoxHint(txtDirectory,"Directory path","Directory path",1);
        }

        private void txtDirectory_Leave(object sender, EventArgs e)
        {
            textBoxHint(txtDirectory, "Directory path", "", 2);
        }

        private void textBoxHint(TextBox txtbox, string OriginalHint, string hintText, int typeEvents)
        {
            if (typeEvents == 1)
            {
                if (txtbox.Text == hintText)
                {
                    txtbox.Text = "";
                    txtbox.ForeColor = System.Drawing.Color.Black;
                }
            }
            else if (typeEvents == 2)
            {
                if (txtbox.Text == "")
                {
                    txtbox.Text = OriginalHint;
                    txtbox.ForeColor = System.Drawing.Color.Silver;
                }

            }
        }

  
        //private void EnterPath(string hintText,)
        //{ 
            
        //}
     }
}
