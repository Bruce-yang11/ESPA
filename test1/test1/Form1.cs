﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("git test");
            MessageBox.Show("git test123");
            Form1 fr1 = new Form1();
            fr1.Text="同步测试"+now();
             MessageBox.Show("git test123213");

        }
    }
}
