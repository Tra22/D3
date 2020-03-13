using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCTreeList list = new UCTreeList();
            list.Dock = DockStyle.Fill;
            panelSource.Controls.Add(list);
            UCTreeList lists = new UCTreeList();
            lists.Dock = DockStyle.Fill;
            panelDirectory.Controls.Add(lists);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Do you want to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exitResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
