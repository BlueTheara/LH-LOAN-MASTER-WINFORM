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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOGIN_CHECK", txtUserName.Text.Trim() + "[.,;TNC,;.]" + txtPwd.Text.Trim() + "[.,;TNC,;.]" + ClsGlouble.GetHardiskSerial() });
            int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
            if (result == 0)
            {
                MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                ClsGlouble.DB_NAME = ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_db"]);
                this.Hide();
                MainForm mf = new MainForm();
                mf.Text = ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_branch"]);
                mf.Show();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ClsGlouble.DB_NAME = "loansystem";
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}

