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
using Microsoft.Reporting.WinForms;
using Excel = Microsoft.Office.Interop.Excel; 
using forListBox;
using System.Text.RegularExpressions;
namespace Micro_Finance
{
    public partial class frmCapitalAll : Form
    {
        public DataSet ds;
        public frmCapitalAll()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
            b_search.Click += btnSearch_Click;
        }

        private void frmCapital_Load(object sender, EventArgs e)
        {
            t_from.Value = DateTime.Now;
            t_to.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData() {
            string vDateTo = t_to.Value.ToString("yyyy-MM-dd");
            string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");
            ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_CAPITAL", vDateFrom + "[.,;TNC,;.]" + vDateTo }, "loansystem");
            dgv.DataSource = ds.Tables[0].Copy();
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System", 9);
            dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
            {
                c.DefaultCellStyle.Font = new Font("Khmer OS System", 9);
                switch (c.Name)
                {
                    case "int_line":
                        c.HeaderText = "ល រ";
                        break;
                    case "int_coid":
                        c.HeaderText = "លេខCO";
                        break;
                    case "var_coname":
                        c.HeaderText = "សាខា";
                        break;
                    case "int_cus_count":
                        c.HeaderText = "ចំនួនអតិថិជន";
                        break;
                    case "dou_total":
                        c.HeaderText = "ប្រាក់បញ្ចេញសរុប";
                        break;
                    case "dou_prin":
                        c.HeaderText = "ប្រាក់ដើមបញ្ចេញ";
                        break;
                    case "dou_int":
                        c.HeaderText = "ការប្រាក់បញ្ចេញ";
                        break;
                    case "dou_total_paid":
                        c.HeaderText = "ប្រាក់បង់រួចសរុប";
                        break;
                    case "dou_prin_paid":
                        c.HeaderText = "ប្រាក់ដើមបង់រួច";
                        break;
                    case "dou_int_paid":
                        c.HeaderText = "ការប្រាក់បង់រួច";
                        break;
                    case "dou_total_bal":
                        c.HeaderText = "ប្រាក់នៅសល់សរុប";
                        break;
                    case "dou_prin_bal":
                        c.HeaderText = "ប្រាក់ដើមនៅសល់";
                        break;
                    case "dou_int_bal":
                        c.HeaderText = "ការប្រាក់នៅសល់";
                        break;
                }
            });

            if (ds.Tables[1].Rows.Count <= 0)
            {
                ClsGlouble.ClearCtrl(new Control[] {t_count, t_total, t_total_bal, t_total_paid, t_prin, t_prin_bal, t_prin_paid, t_int, t_int_bal, t_int_paid });
            }
            else {
                DataRow r = ds.Tables[1].Rows[0];
                t_count.Text = ClsGlouble.f_string(r["int_cus_count"]);
                t_total.Text = ClsGlouble.f_string(r["dou_total"]);
                t_total_bal.Text = ClsGlouble.f_string(r["dou_total_bal"]);
                t_total_paid.Text = ClsGlouble.f_string(r["dou_total_paid"]);
                t_prin.Text = ClsGlouble.f_string(r["dou_prin"]);
                t_prin_bal.Text = ClsGlouble.f_string(r["dou_prin_bal"]);
                t_prin_paid.Text = ClsGlouble.f_string(r["dou_prin_paid"]);
                t_int.Text = ClsGlouble.f_string(r["dou_int"]);
                t_int_bal.Text = ClsGlouble.f_string(r["dou_int_bal"]);
                t_int_paid.Text = ClsGlouble.f_string(r["dou_int_paid"]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void b_print_Click(object sender, EventArgs e)
        {
            if (ds != null) {
                string vRptName = "Micro_Finance.REPORTFILE.CAPITAL_SUMMARY_ALL.rdlc";
                frmReport frmreport = new frmReport();
                frmreport.reportViewer1.LocalReport.ReportEmbeddedResource = vRptName;
                frmreport.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rpts = new ReportDataSource("DataSet1", ds.Tables[0].Copy());
                frmreport.reportViewer1.LocalReport.DataSources.Add(rpts);
                DataRow row = ds.Tables[1].Rows[0];
                string vTotal = ClsGlouble.f_string(row["dou_total"]);
                string vPrin = ClsGlouble.f_string(row["dou_prin"]);
                string vInt = ClsGlouble.f_string(row["dou_int"]);
                string vTotalPaid = ClsGlouble.f_string(row["dou_total_paid"]);
                string vPrinPaid = ClsGlouble.f_string(row["dou_prin_paid"]);
                string vIntPaid = ClsGlouble.f_string(row["dou_int_paid"]);
                string vTotalBal = ClsGlouble.f_string(row["dou_total_bal"]);
                string vPrinBal = ClsGlouble.f_string(row["dou_prin_bal"]);
                string vIntBal = ClsGlouble.f_string(row["dou_int_bal"]);
                string vCusCount = ClsGlouble.f_string(row["int_cus_count"]);

                ReportParameter[] p = new ReportParameter[12];
                p[0] = new ReportParameter("sDate", t_from.Value.ToString("dd-MM-yyyy"));
                p[1] = new ReportParameter("eDate", t_to.Value.ToString("dd-MM-yyyy"));
                p[2] = new ReportParameter("vTotal", vTotal);
                p[3] = new ReportParameter("vPrin", vPrin);
                p[4] = new ReportParameter("vInt", vInt);
                p[5] = new ReportParameter("vTotalPaid", vTotalPaid);
                p[6] = new ReportParameter("vPrinPaid", vPrinPaid);
                p[7] = new ReportParameter("vIntPaid", vIntPaid);
                p[8] = new ReportParameter("vTotalBal", vTotalBal);
                p[9] = new ReportParameter("vPrinBal", vPrinBal);
                p[10] = new ReportParameter("vIntBal", vIntBal);
                p[11] = new ReportParameter("vCount", vCusCount);
                frmreport.reportViewer1.LocalReport.SetParameters(p);
                frmreport.reportViewer1.RefreshReport();
                frmreport.ShowDialog();
            }
        }   
    }
}
