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
    public partial class frmCusSub : Form
    {
        public string vAction = "ADD";
        public frmCus fCus;
        public DataSet tempDs;
        public string vDb = "";
        public frmCusSub()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_name.Text == "" || t_tel.Text == "" || t_addr.Text == "" || t_prop.Text == "" || t_contact.Text == "" || cmbCOID.Text == "" || cmbCOName.Text == "")
                {
                    MessageBox.Show("Please Input All the Informations !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_CUS", vAction + "[.,;TNC,;.]" + ClsGlouble.f_integer(t_id.Text.Trim()) + "[.,;TNC,;.]" + t_name.Text.Trim() + "[.,;TNC,;.]" + t_tel.Text.Trim() + "[.,;TNC,;.]" + t_addr.Text.Trim() + "[.,;TNC,;.]" + t_prop.Text.Trim() + "[.,;TNC,;.]" + t_contact.Text.Trim() + "[.,;TNC,;.]" + t_cardid.Text.Trim() + "[.,;TNC,;.]" + cmbSex.Text.Trim() + "[.,;TNC,;.]" + t_dob.Value.ToString("yyyy-MM-dd") + "[.,;TNC,;.]" + ClsGlouble.f_integer(cmbCOID.Text.Trim()) }, vDb);
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
                        fCus.LoadData("LAST");
                        t_id.Text = "";
                        t_name.Text = "";
                        t_tel.Text = "";
                        t_addr.Text = "";
                        t_contact.Text = "";
                        t_prop.Text = "";
                        t_id.Text = "";
                        t_name.Focus();
                    }
                    else
                    {
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

        private void frmCusSub_Load(object sender, EventArgs e)
        {
            tempDs = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_CUS_LOAD", ClsGlouble.f_integer(t_id.Text.Trim()) + ""}, vDb);
            cmbCOID.DataSource = tempDs.Tables[1];
            cmbCOID.DisplayMember = "int_id";
            cmbCOID.ValueMember = "int_id";

            cmbCOName.DataSource = tempDs.Tables[1];
            cmbCOName.DisplayMember = "var_name";
            cmbCOName.ValueMember = "int_id";

            if (vAction.Equals("EDIT")) {
                DataRow r = tempDs.Tables[0].Rows[0];
                t_id.Text = ClsGlouble.f_string(r["int_id"]);
                t_name.Text = ClsGlouble.f_string(r["var_name"]);
                t_tel.Text = ClsGlouble.f_string(r["var_tel"]);
                t_addr.Text = ClsGlouble.f_string(r["var_addr"]);
                t_contact.Text = ClsGlouble.f_string(r["var_contact"]);
                t_prop.Text = ClsGlouble.f_string(r["var_prop"]);
                cmbSex.Text = ClsGlouble.f_string(r["var_sex"]);
                t_dob.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_dob"]), "yyyy-MM-dd", null);
                cmbCOID.SelectedValue = ClsGlouble.f_integer(r["int_co"]);
            }
        }
    }
}
    

