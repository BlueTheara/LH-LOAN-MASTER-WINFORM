﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micro_Finance
{
    public partial class frmBG : Form
    {
        public frmBG()
        {
            InitializeComponent();
        }

        private void frmBG_Load(object sender, EventArgs e)
        {
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
            label2.Parent = this;
            label2.BackColor = Color.Transparent;
        }
    }
}
