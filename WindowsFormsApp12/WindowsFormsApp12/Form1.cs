﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [table]";
        public string ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\vanya\\OneDrive\\Рабочий стол\\rofl1.mdb.accdb";
        public Form1()
        { 
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[table]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }
    }
}
