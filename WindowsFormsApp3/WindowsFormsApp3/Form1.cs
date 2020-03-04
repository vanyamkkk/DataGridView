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



namespace WindowsFormsApp3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string pcpath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = "C:/";
            Open_page();
        }
        public void Open_page()
        {
        treeView1.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox1.Text);
        string[] allfolders = Directory.GetDirectories(metroTextBox1.Text);
            foreach (string filename in allfiles)
            {
                treeView1.Nodes.Add(filename);
            }
            foreach (string foldername in allfolders)
            {
                treeView1.Nodes.Add(foldername);
            }
        }
        
           

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pcpath = metroTextBox1.Text;
            metroTextBox1.Text = treeView1.SelectedNode.Text.ToString();
            Open_page();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = pcpath;
            Open_page();
        }
    }
    }
