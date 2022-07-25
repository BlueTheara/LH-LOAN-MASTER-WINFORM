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
    public partial class frmBorrowDelete : Form
    {
        public frmBorrowDelete()
        {
            InitializeComponent();
        }
        public int vId = 0;
        public string vDb = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_reason.Text.Trim() == "")
                {
                    MessageBox.Show("សូមបញ្ចូលមូលហេតុលុប !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "DELETE_LOAN", vId + "[.,;TNC,;.]" + t_reason.Text.Trim() }, vDb);
                    int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                    if (result == 0)
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
    }
}
