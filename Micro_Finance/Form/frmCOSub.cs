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
    public partial class frmCOSub : Form
    {
        public frmCOSub()
        {
            InitializeComponent();
        }
        public string vAction = "ADD";
        public frmCO fCo;
        public string vDb = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_name.Text == "" || t_tel.Text == "" || t_addr.Text == "")
                {
                    MessageBox.Show("Please Input All the Informations !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_CO", vAction + "[.,;TNC,;.]" + ClsGlouble.f_integer(t_id.Text.Trim()) + "[.,;TNC,;.]" + t_name.Text.Trim() + "[.,;TNC,;.]" + t_tel.Text.Trim() + "[.,;TNC,;.]" + t_addr.Text.Trim()}, vDb);
                    int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                    if (result == 0)
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (vAction.Equals("ADD"))
                    {
                        fCo.LoadData("LAST");
                        t_id.Text = "";
                        t_name.Text = "";
                        t_tel.Text = "";
                        t_addr.Text = "";
                        t_name.Focus();
                    }
                    else {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCOSub_Load(object sender, EventArgs e)
        {
            if (vAction.Equals("EDIT"))
            {
                DataSet tempDs = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_CO_LOAD", ClsGlouble.f_integer(t_id.Text.Trim()) + "" }, vDb);
                DataRow r = tempDs.Tables[0].Rows[0];
                t_id.Text = ClsGlouble.f_string(r["int_id"]);
                t_name.Text = ClsGlouble.f_string(r["var_name"]);
                t_tel.Text = ClsGlouble.f_string(r["var_tel"]);
                t_addr.Text = ClsGlouble.f_string(r["var_addr"]);
            }
        }
    }
}
