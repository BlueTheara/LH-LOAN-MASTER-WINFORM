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
using forListBox;
namespace Micro_Finance
{
    public partial class frmCOIncomeAll : Form
    {
        public frmCOIncomeAll()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmCOIncome_Load(object sender, EventArgs e)
        {
            t_from.Value = DateTime.Now;
            t_to.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            string vDateTo = t_to.Value.ToString("yyyy-MM-dd");
            string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_CO_IONCOME", vDateFrom + "[.,;TNC,;.]" + vDateTo }, "loansystem");
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
                    case "var_coname":
                        c.HeaderText = "សាខា";
                        break;
                    case "dou_total_paid":
                        c.HeaderText = "ប្រាក់បានទទួលសរុប";
                        break;
                    case "dou_prin_paid":
                        c.HeaderText = "ប្រាក់ដើមបានទទួល";
                        break;
                    case "dou_int_paid":
                        c.HeaderText = "ការប្រាក់បានទទួល";
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
                }
            });

            if (ds.Tables[1].Rows.Count <= 0)
            {
                ClsGlouble.ClearCtrl(new Control[] { t_total, t_total_paid, t_prin, t_prin_paid, t_int, t_int_paid });
            }
            else
            {
                DataRow r = ds.Tables[1].Rows[0];
                t_total.Text = ClsGlouble.f_string(r["dou_total"]);
                t_total_paid.Text = ClsGlouble.f_string(r["dou_total_paid"]);
                t_prin.Text = ClsGlouble.f_string(r["dou_prin"]);
                t_prin_paid.Text = ClsGlouble.f_string(r["dou_prin_paid"]);
                t_int.Text = ClsGlouble.f_string(r["dou_int"]);
                t_int_paid.Text = ClsGlouble.f_string(r["dou_int_paid"]);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataPrint();
        }

        private void LoadDataPrint()
        {
            string vDateTo = t_to.Value.ToString("yyyy-MM-dd");
            string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_CO_IONCOME", vDateFrom + "[.,;TNC,;.]" + vDateTo }, "loansystem");

            string vRptName = "Micro_Finance.REPORTFILE.INCOME_SUMMARY_ALL.rdlc";
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

            ReportParameter[] p = new ReportParameter[8];
            p[0] = new ReportParameter("sDate", t_from.Value.ToString("dd-MM-yyyy"));
            p[1] = new ReportParameter("eDate", t_to.Value.ToString("dd-MM-yyyy"));
            p[2] = new ReportParameter("vTotal", vTotal);
            p[3] = new ReportParameter("vPrin", vPrin);
            p[4] = new ReportParameter("vInt", vInt);
            p[5] = new ReportParameter("vTotalPaid", vTotalPaid);
            p[6] = new ReportParameter("vPrinPaid", vPrinPaid);
            p[7] = new ReportParameter("vIntPaid", vIntPaid);
            frmreport.reportViewer1.LocalReport.SetParameters(p);
            frmreport.reportViewer1.RefreshReport();
            frmreport.ShowDialog();
        }
    }
}
