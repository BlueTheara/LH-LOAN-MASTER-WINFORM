using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using forListBox;


namespace Micro_Finance
{
    public partial class frmPay : Form
    {
        public DataSet ds;
        public frmPay()
        {
            InitializeComponent();
            ClsGlouble.LoadBranch(c_branch);
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 25;
            t_id.KeyPress += my_KeyPress;
            t_amt.KeyPress += my_KeyPress;
            t_count.KeyPress += my_KeyPress;
            t_amt.KeyUp += my_KeyUp;
            t_count.KeyUp += my_KeyUp;
            b_pay.Click += MenuCLick;
            b_pay_all.Click += MenuCLick;
            b_undo.Click += MenuCLick;
            b_print_schedule.Click += MenuCLick;
            b_print_history.Click += MenuCLick;
            c_branch.SelectedIndexChanged += c_branch_SelectedIndexChanged;
        }

        void c_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsGlouble.ClearCtrl(new Control[] {t_id, t_cus_id, t_cus_name, t_amt, t_count});
            dgv.DataSource = null;
        }

        void MenuCLick(object sender, EventArgs e)
        {
            if (c_branch.SelectedIndex < 0)
            {
                MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sender == b_pay) {
                DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "SAVE_DATA_PAY", ClsGlouble.f_integer(t_id.Text.Trim()) + "[.,;TNC,;.]" + ClsGlouble.f_double(t_amt.Text.Trim(), 0) }, ClsGlouble.f_string(c_branch.SelectedValue));
                DataRow row = temp_ds.Tables[0].Rows[0];
                if (ClsGlouble.f_integer(row["int_result"]) == 0)
                {
                    MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temp_ds.Tables.RemoveAt(0);
                    LoadData(temp_ds);
                }
            }
            else if (sender == b_undo) {
                DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_UNDO", ClsGlouble.f_integer(t_id.Text.Trim()) + "" }, ClsGlouble.f_string(c_branch.SelectedValue));
                DataRow row = temp_ds.Tables[0].Rows[0];
                if (ClsGlouble.f_integer(row["int_result"]) == 0)
                {
                    MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    row = temp_ds.Tables[1].Rows[0];
                    if (MessageBox.Show("Do you wanto undo the last post on " + ClsGlouble.f_string(row["dat_date"]) + " and pay_amount = " + ClsGlouble.f_string(row["dou_pmt"]) + "?", "Confirm Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "SAVE_UNDO", ClsGlouble.f_integer(t_id.Text.Trim()) + "" },ClsGlouble.f_string(c_branch.SelectedValue));
                        row = temp_ds.Tables[0].Rows[0];
                        if (ClsGlouble.f_integer(row["int_result"]) == 0)
                        {
                            MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            temp_ds.Tables.RemoveAt(0);
                            LoadData(temp_ds);
                        }
                    }
                }
            }
            else if (sender == b_pay_all) {
                DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_PAY_ALL", ClsGlouble.f_integer(t_id.Text.Trim()) + "" }, ClsGlouble.f_string(c_branch.SelectedValue));
                DataRow row = temp_ds.Tables[0].Rows[0];
                if (ClsGlouble.f_integer(row["int_result"]) == 0)
                {
                    MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    row = temp_ds.Tables[1].Rows[0];
                    frmPayAll obj = new frmPayAll();
                    obj.t_id.Text = ClsGlouble.f_string(row["int_id"]);
                    obj.t_cus_id.Text = ClsGlouble.f_string(row["int_cusid"]);
                    obj.t_cus_name.Text = ClsGlouble.f_string(row["var_cusname"]);
                    obj.t_term.Text = ClsGlouble.f_string(row["int_term"]);
                    obj.t_prin.Text = ClsGlouble.f_string(row["dou_prin"]);
                    obj.t_rate.Text = ClsGlouble.f_string(row["dou_rate"]);
                    obj.t_interest.Text = ClsGlouble.f_string(row["dou_int"]);
                    obj.t_total.Text = ClsGlouble.f_string(row["dou_total"]);
                    obj.t_term_paid.Text = ClsGlouble.f_string(row["int_term_paid"]);
                    obj.t_prin_paid.Text = ClsGlouble.f_string(row["dou_prin_paid"]);
                    obj.t_interest_paid.Text = ClsGlouble.f_string(row["dou_int_paid"]);
                    obj.t_total_paid.Text = ClsGlouble.f_string(row["dou_total_paid"]);
                    obj.t_term_bal.Text = ClsGlouble.f_string(row["int_term_bal"]);
                    obj.t_prin_bal.Text = ClsGlouble.f_string(row["dou_prin_bal"]);
                    obj.t_interest_bal.Text = ClsGlouble.f_string(row["dou_int_bal"]);
                    obj.t_total_bal.Text = ClsGlouble.f_string(row["dou_total_bal"]);
                    obj.t_total_pay.Text = ClsGlouble.f_string(row["dou_total_bal"]);
                    if (obj.ShowDialog() == DialogResult.OK) {
                        temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "SAVE_PAY_ALL", ClsGlouble.f_integer(t_id.Text.Trim()) + "[.,;TNC,;.]" + (obj.k_wave.Checked ? "1" : "0") }, ClsGlouble.f_string(c_branch.SelectedValue));
                        row = temp_ds.Tables[0].Rows[0];
                        if (ClsGlouble.f_integer(row["int_result"]) == 0)
                        {
                            MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(ClsGlouble.f_string(row["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            temp_ds.Tables.RemoveAt(0);
                            LoadData(temp_ds);
                        }
                    }
                }
            }
            else if (sender == b_print_schedule) {
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "PRINT_SCHEDULE", ClsGlouble.f_integer(t_id.Text.Trim()) + ""},ClsGlouble.f_string(c_branch.SelectedValue));
                if (ds.Tables[0].Rows.Count <= 0) {
                    MessageBox.Show("លេខកូដឥណទានមិនត្រឹមត្រូវ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                frmReport frmreport = new frmReport();
                frmreport.reportViewer1.LocalReport.ReportEmbeddedResource = "Micro_Finance.REPORTFILE.PAYSCHEDULE_RP.rdlc";
                frmreport.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rpts = new ReportDataSource("DataSet1", ds.Tables[0]);
                frmreport.reportViewer1.LocalReport.DataSources.Add(rpts);
                frmreport.reportViewer1.LocalReport.SetParameters(new ReportParameter("Tel", ClsGlouble.f_string(ds.Tables[1].Rows[0]["var_tel"])));
                frmreport.reportViewer1.LocalReport.SetParameters(new ReportParameter("P1", "1.0"));
                frmreport.reportViewer1.RefreshReport();
                frmreport.ShowDialog();
            }
            else if (sender == b_print_history) {
                frmAlert obj = new frmAlert();
                obj.vDb = ClsGlouble.f_string(c_branch.SelectedValue);
                obj.vId = ClsGlouble.f_integer(t_id.Text.Trim());
                obj.ShowDialog();
            }
        }

        private void my_KeyUp(object sender, KeyEventArgs e) {
            if (ds == null) {
                return;
            }

            if (ds.Tables[0].Rows.Count <= 0) {
                return;
            }
            double vPay = ClsGlouble.f_double(ds.Tables[0].Rows[0]["dou_pay"]);
            if (sender == t_count)
            {
                int vCount = ClsGlouble.f_integer(t_count.Text.Trim());
                t_amt.Text = (vPay * vCount) + "";
            }
            else if(sender == t_amt) {
                double vAmt = ClsGlouble.f_double(t_amt.Text.Trim());
                if (vPay == 0) {
                    t_count.Text = "1";
                }
                else
                {
                    t_count.Text = Math.Floor(vAmt / vPay) + "";
                }
            }
        }

        private void my_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == t_amt) {
                ClsGlouble.DoubleInput(e, t_amt);
            }
            else if (sender == t_count) {
                ClsGlouble.IntegerInput(e, t_count);
            }
            else if (sender == t_id) {
                if (e.KeyChar == (char)13) {
                    if (c_branch.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    frmDialog obj = new frmDialog();
                    obj.vParam = new string[] { t_id.Text.Trim()};
                    obj.vDb = ClsGlouble.f_string(c_branch.SelectedValue);
                    obj.vModule = "SEARCH_DIAlOG_LOAN";
                    obj.Name = "SHOW";
                    obj.ShowInTaskbar = false;
                    obj.TopLevel = false;
                    obj.Width = t_id.Width;
                    obj.Height = dgv.Height;
                    obj.Location = new Point(t_id.Left, t_id.Top + t_id.Height);
                    obj.FormClosing += Temp_Form_Closing;
                    obj.dgv.CellDoubleClick += Temp_GridView_CellDoubleClick;
                    obj.dgv.KeyDown += Temp_GridView_KeyDown;
                    obj.afterBind += (frm => {
                        frm.dgv.Columns[0].Width = t_id.Width / 2;
                        frm.dgv.Columns[1].Width = t_id.Width / 2;
                        frm.dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
                        {
                            c.DefaultCellStyle.Font = new Font("Khmer OS System", 9);

                            switch (c.Name)
                            {
                                case "int_id":
                                    c.HeaderText = "លេខកូដឥណទាន";
                                    break;
                                case "var_name":
                                    c.HeaderText = "ឈ្មោះអតិថិជន";
                                    break;
                                default:
                                    break;
                            }
                        });
                    });
                    obj.LoadData("SEARCH");
                    if (obj.dgv.Rows.Count > 0) {
                        if (obj.dgv.Rows.Count == 1)
                        {
                            t_id.Text = ClsGlouble.f_string(obj.dgv.Rows[0].Cells["int_id"].Value);
                            LoadData();
                        }
                        else {
                            Controls.Add(obj);
                            obj.BringToFront();
                            obj.Show();
                            obj.dgv.Focus();
                        }
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
            if (e.KeyCode == Keys.Enter){
                DoubleClick_KeyPress(sender);
            }
        }

        public void DoubleClick_KeyPress(object sender)
        {
            Form F = this.Controls["SHOW"] as Form;
            DataGridView Temp = sender as DataGridView;
            if (Temp.SelectedRows.Count > 0) {
                t_id.Text = ClsGlouble.f_string(Temp.SelectedRows[0].Cells["int_id"].Value);
                LoadData();
                F.Close();
            }
        }

        public void LoadData(DataSet temp_ds = null) {
            if (c_branch.SelectedIndex < 0)
            {
                MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ds = temp_ds == null ? ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_PAY", ClsGlouble.f_integer(t_id.Text.Trim()) + "" }, ClsGlouble.f_string(c_branch.SelectedValue)) : temp_ds.Copy();
            if (ds.Tables[0].Rows.Count > 0)
            {
                t_cus_id.Text = ClsGlouble.f_string(ds.Tables[0].Rows[0]["int_cusid"]);
                t_cus_name.Text = ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_name"]);
                t_count.Text = "1";
                t_amt.Text = ClsGlouble.f_string(ds.Tables[0].Rows[0]["dou_pay"]);
            }
            else {
                t_cus_id.Text = "";
                t_cus_name.Text = "";
                t_count.Text = "";
                t_amt.Text = "";
            }
            dgv.DataSource = ds.Tables[1].Copy();
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System", 9);
            dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
            {
                c.DefaultCellStyle.Font = new Font("Khmer OS System", 9);

                switch (c.Name)
                {
                    case "int_line":
                        c.HeaderText = "ល រ";
                        break;
                    case "dou_amt_bal":
                        c.HeaderText = "ប្រាក់សរុប";
                        break;
                    case "dou_total":
                        c.HeaderText = "ប្រាក់បង់សរុប";
                        break;
                    case "dou_amt":
                        c.HeaderText = "ប្រាក់ដើម";
                        break;
                    case "dou_int_amt":
                        c.HeaderText = "ការប្រាក់";
                        c.Width = 120;
                        break;
                    case "dat_date":
                        c.HeaderText = "កាលបរិច្ឆែត";
                        break;
                    case "dou_paid":
                        c.HeaderText = "ប្រាក់ទទួល";
                        break;
                    case "dou_bal":
                        c.HeaderText = "ប្រាក់ខ្វះ";
                        break;
                    case "var_status":
                        c.HeaderText = "បញ្ជាក់";
                        break;
                    default:
                        break;
                }
            });
        }

        private void frmPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form F = this.Controls["SHOW"] as Form;
            if (F != null) {
                F.Close();
            }
        }
    }
}
