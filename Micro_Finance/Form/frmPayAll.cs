using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Micro_Finance
{
    public partial class frmPayAll : Form
    {
        public frmPayAll()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void chInterest_CheckedChanged(object sender, EventArgs e)
        {
            t_total_pay.Text = k_wave.Checked ? t_prin_bal.Text : t_total_bal.Text;
        }
    }
}
