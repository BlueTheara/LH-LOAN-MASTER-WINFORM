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
    public partial class frmEverydayPay : Form
    {
        DataSet ds;
        public frmEverydayPay()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
        }

        private void frmEverydayPay_Load(object sender, EventArgs e)
        {
            ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_FORM_DAILY", "" });
            c_co_id.DisplayMember = "int_id";
            c_co_id.ValueMember = "int_id";
            c_co_id.DataSource = ds.Tables[0];

            c_co_name.DisplayMember = "var_name";
            c_co_name.ValueMember = "int_id";
            c_co_name.DataSource = ds.Tables[0];

        }   

        private void button1_Click(object sender, EventArgs e)
        {
            ViewReport(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewReport(1);
        }

        private void ViewReport(int vAllCo) {
            if (vAllCo == 0 && c_co_id.SelectedIndex < 0) {
                MessageBox.Show("Please Select CO_ID!");
                return;
            }
            int vCoId = vAllCo == 1 ? 0 : ClsGlouble.f_integer(c_co_id.SelectedValue);
            string vRptName = vAllCo == 0 ? "Micro_Finance.REPORTFILE.EVERYDAYPAYONECO_RP.rdlc" : "Micro_Finance.REPORTFILE.EVERYDAYPAY_RP.rdlc";
            int vCheckLate = k_late.Checked ? 1 : 0;
            int vLateFrom = ClsGlouble.f_integer(t_late_from.Text.Trim());
            int vLateTo = ClsGlouble.f_integer(t_late_to.Text.Trim());
            DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_DAILY_PAY", vAllCo + "[.,;TNC,;.]" + vCoId + "[.,;TNC,;.]" + vCheckLate + "[.,;TNC,;.]" + vLateFrom + "[.,;TNC,;.]" + vLateTo });
            frmReport frmreport = new frmReport();
            frmreport.reportViewer1.LocalReport.ReportEmbeddedResource = vRptName;
            frmreport.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("DataSet1", temp_ds.Tables[0].Copy());
            frmreport.reportViewer1.LocalReport.DataSources.Add(rpts);
            DataRow row = temp_ds.Tables[1].Rows[0];
            double outstanding = ClsGlouble.f_double(row["dou_bal_all"]);
            double ODay = ClsGlouble.f_double(row["dou_bal_day"]);
            double OWeek = ClsGlouble.f_double(row["dou_bal_week"]);
            double OWeek2 = ClsGlouble.f_double(row["dou_bal_week2"]);
            double OMonth = ClsGlouble.f_double(row["dou_bal_month"]);
            double vTotalPay = ClsGlouble.f_double(row["dou_total_pay"]);
            double vPar = ClsGlouble.f_double(row["dou_par"]);
            ReportParameter[] p = new ReportParameter[10];
            p[0] = new ReportParameter("Late", vCheckLate + "");
            p[1] = new ReportParameter("FLate", vLateFrom + "");
            p[2] = new ReportParameter("TLate", vLateTo + "");
            p[3] = new ReportParameter("OutStanding", outstanding.ToString());
            p[4] = new ReportParameter("ODay", ODay + "");
            p[5] = new ReportParameter("OWeek", OWeek + "");
            p[6] = new ReportParameter("OWeek2", OWeek2 + "");
            p[7] = new ReportParameter("OMonth", OMonth + "");
            p[8] = new ReportParameter("TotalPay", vTotalPay + "");
            p[9] = new ReportParameter("Par", vPar + "");
            frmreport.reportViewer1.LocalReport.SetParameters(p);
            frmreport.reportViewer1.RefreshReport();
            frmreport.ShowDialog();
        }

        private void chLate_CheckedChanged(object sender, EventArgs e)
        {
            t_late_from.Enabled = k_late.Checked ? true : false;
            t_late_to.Enabled = k_late.Checked ? true : false;
        }

        private void txtFLate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.IntegerInput(e, t_late_from);
        }

        private void txtToLate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.IntegerInput(e, t_late_to);
        }

        private void cmbCOID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_co_id.SelectedIndex < 0) {
                dgv.DataSource = null;
                return;
            }
            int vId = ClsGlouble.f_integer(c_co_id.SelectedValue);
            int vAllCo = 0;
            int vCheckLate = k_late.Checked ? 1 : 0;
            int vLateFrom = ClsGlouble.f_integer(t_late_from.Text.Trim());
            int vLateTo = ClsGlouble.f_integer(t_late_to.Text.Trim());
            DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_DAILY_PAY", vAllCo + "[.,;TNC,;.]" + vId + "[.,;TNC,;.]" + vCheckLate + "[.,;TNC,;.]" + vLateFrom + "[.,;TNC,;.]" + vLateTo });
            dgv.DataSource = temp_ds.Tables[0];
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System", 9);
            dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
            {
                c.DefaultCellStyle.Font = new Font("Khmer OS System", 9);
                switch (c.Name)
                {
                    case "int_line":
                        c.HeaderText = "ល រ";
                        break;
                    case "BID":
                        c.HeaderText = "លេខកូដ";
                        break;
                    case "CusID":
                        c.HeaderText = "IDអតិថិជន";
                        break;
                    case "CName":
                        c.HeaderText = "ឈ្មោះអតិថិជន";
                        break;
                    case "Number":
                        c.HeaderText = "ទូរស័ព្ធ";
                        break;
                    case "Address":
                        c.HeaderText = "អាស័យដ្ឋាន";
                        break;
                    case "COID":
                        c.HeaderText = "លេខCO";
                        break;
                    case "COName":
                        c.HeaderText = "ឈ្មោះCO";
                        break;
                    case "B_Amount":
                        c.HeaderText = "ប្រាក់ខ្ចី";
                        break;
                    case "B_Date":
                        c.HeaderText = "ថ្ងៃខ្ចី";
                        break;
                    case "Schedule":
                        c.HeaderText = "កាលបរិច្ឆែត";
                        break;
                    case "Total_Pay":
                        c.HeaderText = "ប្រាក់ត្រូវបង់";
                        break;
                    case "New_Type":
                        c.HeaderText = "ប្រភេទ";
                        break;
                    case "PaidDay":
                        c.HeaderText = "ថ្ងៃបង់រួច";
                        break;
                    case "R_Day":
                        c.HeaderText = "ថ្ងៃនៅសល់";
                        break;
                    case "Late":
                        c.HeaderText = "យឹត";
                        break;
                    case "accept":
                        c.HeaderText = "ប្រាក់បង់លើស";
                        break;
                    case "Expr1":
                        c.HeaderText = "ប្រាក់ត្រូវបង់សរុប";
                        break;
                }
            });
            t_count.Text = dgv.Rows.Count + "";
        }

    }
}
