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
    public partial class frmBorrowSub : Form
    {
        public string vAction = "ADD";
        public frmBorrow fCus;
        public DataSet tempDs;
        private bool isRequest = true;
        public string vDb = "";
        public frmBorrowSub()
        {
            InitializeComponent();
            t_create.GotFocus += CtrFocus;
            t_from.GotFocus += CtrFocus;
            c_type.GotFocus += CtrFocus;
            c_type1.GotFocus += CtrFocus;
            t_term.GotFocus += CtrFocus;
            t_rate1.GotFocus += CtrFocus;
            t_amt.GotFocus += CtrFocus;
            t_rate_per.GotFocus += CtrFocus;
            t_rate_amt.GotFocus += CtrFocus;

            t_create.ValueChanged += DateValueChanged;
            t_from.ValueChanged += DateValueChanged;

            t_term.KeyUp += t_term_KeyUp;
            c_type.SelectedIndexChanged += c_type_SelectedIndexChanged;
            c_type1.SelectedIndexChanged += c_type1_SelectedIndexChanged;

            t_rate1.KeyUp += t_rate1_KeyUp;
            t_amt.KeyUp += t_rate1_KeyUp;
            t_rate_per.KeyUp += t_rate1_KeyUp;
        }

        void t_rate1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!isRequest)
            {
                GetInterest();
            }
        }

        void c_type1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isRequest && c_type1.SelectedIndex >= 0)
            {
                GetInterest();
            }
        }

        void c_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isRequest && c_type.SelectedIndex >= 0)
            {
                GetlastDate("CHANGE_CREATE");
                GetInterest();
            }
        }

        void t_term_KeyUp(object sender, KeyEventArgs e)
        {
            if (!isRequest)
            {
                GetlastDate("CHANGE_START");
                GetInterest();
            }
        }
        void DateValueChanged(object sender, EventArgs e)
        {
            if (!isRequest) {
                GetlastDate(sender == t_create ? "CHANGE_CREATE" : "CHANGE_START");
            }
        }

        private void GetlastDate(string pAction) {
            isRequest = true;
            try
            {
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "GET_LAST_DATE", pAction + "[.,;TNC,;.]" + c_type.Text.Trim() + "[.,;TNC,;.]" + t_create.Value.ToString("yyyy-MM-dd") + "[.,;TNC,;.]" + t_from.Value.ToString("yyyy-MM-dd") + "[.,;TNC,;.]" + ClsGlouble.f_integer(t_term.Text.Trim()) }, vDb);
                DataRow r = ds.Tables[0].Rows[0];
                t_create.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_date"]), "yyyy-MM-dd", null);
                t_from.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_from"]), "yyyy-MM-dd", null);
                t_to.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_to"]), "yyyy-MM-dd", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            isRequest = false;
        }

        private void GetInterest()
        {
            isRequest = true;
            try
            {
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "GET_INTEREST_AMT", ClsGlouble.f_integer(t_term.Text.Trim()) + "[.,;TNC,;.]" + c_type.Text.Trim() + "[.,;TNC,;.]" + c_type1.Text.Trim() + "[.,;TNC,;.]" + ClsGlouble.f_double(t_amt.Text.Trim()) + "[.,;TNC,;.]" + ClsGlouble.f_double(t_rate_per.Text.Trim()) + "[.,;TNC,;.]" + ClsGlouble.f_double(t_rate1.Text.Trim()) },vDb);
                DataRow r = ds.Tables[0].Rows[0];
                t_rate_amt.Text = ClsGlouble.f_string(r["dou_rate_amt"]);
                t_total.Text = ClsGlouble.f_string(r["dou_total"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            isRequest = false;
        }

        private void CtrFocus(object sender, EventArgs e)
        {
            isRequest = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_cusid.Text.Trim() == "") {
                    MessageBox.Show("Please Select Customer !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t_cusid.Focus();
                    return;
                }

                if (c_type.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Term Type !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c_type.Focus();
                    return;
                }

                if (c_type1.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Select Interest Type !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c_type1.Focus();
                    return;
                }
                int vId = ClsGlouble.f_integer(t_id.Text.Trim());
                int vCusid = ClsGlouble.f_integer(t_cusid.Text.Trim());
                string vType = c_type.Text.Trim();
                string vType1 = c_type1.Text.Trim();
                int vTerm = ClsGlouble.f_integer(t_term.Text.Trim());
                double vRate1 = ClsGlouble.f_double(t_rate1.Text.Trim());
                double vAmt = ClsGlouble.f_double(t_amt.Text.Trim());
                double vRate = ClsGlouble.f_double(t_rate_per.Text.Trim());
                string vDate = t_create.Value.ToString("yyyy-MM-dd");
                string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");

                if (vTerm <= 0) {
                    MessageBox.Show("Term can't be zero !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t_term.Focus();
                    return;
                }

                if (vAmt <= 0)
                {
                    MessageBox.Show("Amount can't be zero !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t_amt.Focus();
                    return;
                }

                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_LOAN", vAction + "[.,;TNC,;.]" + vId + "[.,;TNC,;.]" + vCusid + "[.,;TNC,;.]" + vTerm + "[.,;TNC,;.]" + vDate + "[.,;TNC,;.]" + vDateFrom + "[.,;TNC,;.]" + vType + "[.,;TNC,;.]" + vType1 + "[.,;TNC,;.]" + vAmt + "[.,;TNC,;.]" + vRate + "[.,;TNC,;.]" + vRate1 },vDb);
                int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                if (result == 0)
                {
                    MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (vAction.Equals("ADD"))
                {
                    fCus.t_from.Value = t_create.Value;
                    fCus.t_to.Value = fCus.t_from.Value.AddMonths(1);
                    fCus.t_search.Text = "";
                    fCus.LoadData("LAST");
                    t_cusid.Text = "";
                    t_cusname.Text = "";
                    t_coname.Text = "";
                    c_type.SelectedIndex = 0;
                    c_type1.SelectedIndex = 0;
                    t_term.Text = "";
                    t_rate1.Text = "";
                    t_amt.Text = "";
                    t_rate_per.Text = "";
                    t_rate_amt.Text = "";
                    t_total.Text = "";
                    t_create.Value = DateTime.Now;
                    t_cusid.Focus();
                }
                else
                {
                    fCus.LoadData("");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBorrowSub_Load(object sender, EventArgs e)
        {
            tempDs = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_LOAN_LOAD", ClsGlouble.f_integer(t_id.Text.Trim()) + "" }, vDb);
            c_type.SelectedIndex = 0;
            c_type1.SelectedIndex = 0;
            t_rate1.Text = 1 + "";
            t_create.Value = DateTime.Now;
            t_from.Value = DateTime.Now;
            t_to.Value = DateTime.Now;
            DataRow r = tempDs.Tables[0].Rows[0];
            t_id.Text = ClsGlouble.f_string(r["int_id"]);
            t_cusid.Text = ClsGlouble.f_string(r["int_cusid"]);
            t_cusname.Text = ClsGlouble.f_string(r["var_cusname"]);
            t_coname.Text = ClsGlouble.f_string(r["var_coname"]);
            c_type.SelectedItem = ClsGlouble.f_string(r["var_type"]);
            c_type1.SelectedItem = ClsGlouble.f_string(r["var_type_other"]);
            t_term.Text = ClsGlouble.f_string(r["int_term"]);
            t_rate1.Text = ClsGlouble.f_string(r["dou_int_per_other"]);
            t_create.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_date"]), "yyyy-MM-dd", null);
            t_from.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_from"]), "yyyy-MM-dd", null);
            t_to.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_to"]), "yyyy-MM-dd", null);
            t_amt.Text = ClsGlouble.f_string(r["dou_amt"]);
            t_rate_per.Text = ClsGlouble.f_string(r["dou_int_per"]);
            t_rate_amt.Text = ClsGlouble.f_string(r["dou_int_amt"]);
            t_total.Text = ClsGlouble.f_string(r["dou_total"]);
        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.IntegerInput(e, (TextBox)sender);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.DoubleInput(e, (TextBox)sender);
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.DoubleInput(e, (TextBox)sender);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.DoubleInput(e, (TextBox)sender);
        }

        private void t_cusid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                frmDialog obj = new frmDialog();
                obj.vParam = new string[] { t_cusid.Text.Trim() };
                obj.vModule = "SEARCH_DIAlOG_CUS";
                obj.vDb = this.vDb;
                obj.Name = "SHOW";
                obj.ShowInTaskbar = false;
                obj.TopLevel = false;
                obj.Width = t_id.Width;
                obj.Height = this.Height - t_cusid.Top - t_cusid.Height - 30;
                obj.Location = new Point(t_cusid.Left, t_cusid.Top + t_cusid.Height);
                obj.FormClosing += Temp_Form_Closing;
                obj.dgv.CellDoubleClick += Temp_GridView_CellDoubleClick;
                obj.dgv.KeyDown += Temp_GridView_KeyDown;
                obj.afterBind += (frm =>
                {
                    frm.dgv.Columns[0].Width = t_id.Width / 2;
                    frm.dgv.Columns[1].Width = t_id.Width / 2;
                    frm.dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
                    {
                        c.DefaultCellStyle.Font = new Font("Khmer OS System", 9);

                        switch (c.Name)
                        {
                            case "int_id":
                                c.HeaderText = "IDអតិថិជន";
                                c.Width = 80;
                                break;
                            case "var_name":
                                c.HeaderText = "ឈ្មោះអតិថិជន";
                                c.Width = 150;
                                break;
                            case "var_coname":
                                c.HeaderText = "ឈ្មោះCO";
                                c.Width = 120;
                                break;
                            default:
                                break;
                        }
                    });
                });
                obj.LoadData("SEARCH");
                if (obj.dgv.Rows.Count > 0)
                {
                    if (obj.dgv.Rows.Count == 1)
                    {
                        t_cusid.Text = ClsGlouble.f_string(obj.dgv.Rows[0].Cells["int_id"].Value);
                        t_cusname.Text = ClsGlouble.f_string(obj.dgv.Rows[0].Cells["var_name"].Value);
                        t_coname.Text = ClsGlouble.f_string(obj.dgv.Rows[0].Cells["var_coname"].Value);
                    }
                    else
                    {
                        Controls.Add(obj);
                        obj.BringToFront();
                        obj.Show();
                        obj.dgv.Focus();
                    }
                }

            }
        }

        public void Temp_Form_Closing(object sender, FormClosingEventArgs e)
        {
            t_id.Focus();
        }

        public void Temp_GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
                this.DoubleClick_KeyPress(sender);
        }

        public void Temp_GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoubleClick_KeyPress(sender);
            }
        }

        public void DoubleClick_KeyPress(object sender)
        {
            Form F = this.Controls["SHOW"] as Form;
            DataGridView Temp = sender as DataGridView;
            if (Temp.SelectedRows.Count > 0)
            {
                t_cusid.Text = ClsGlouble.f_string(Temp.SelectedRows[0].Cells["int_id"].Value);
                t_cusname.Text = ClsGlouble.f_string(Temp.SelectedRows[0].Cells["var_name"].Value);
                t_coname.Text = ClsGlouble.f_string(Temp.SelectedRows[0].Cells["var_coname"].Value);
                F.Close();
            }
        }
    }
}
