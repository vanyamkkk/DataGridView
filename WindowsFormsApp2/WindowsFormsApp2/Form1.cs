using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string pcpath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            open_page();
        }
        private void open_page()
        {
            treeView2.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox2.Text);
            string[] allfolders = Directory.GetDirectories(metroTextBox2.Text);
            foreach (string filename in allfiles)
            {
                treeView2.Nodes.Add(filename);
            }
            foreach (string foldername in allfolders)
            {
                treeView2.Nodes.Add(foldername);
            }
        }
    }
}
    
    

