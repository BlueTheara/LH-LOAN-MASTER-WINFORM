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
    public partial class frmAlert : Form
    {
        public int vId = 0;
        public DataSet ds;
        public string vDb = "";
        public frmAlert()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
        }

        private void frmAlert_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_PAYMENT_HISTORY", vId + "" }, vDb);
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
                    case "int_id":
                        c.HeaderText = "លេខកូដ";
                        break;
                    case "int_cusid":
                        c.HeaderText = "លេខកូដអតិថិជន";
                        break;
                    case "var_cusname":
                        c.HeaderText = "ឈ្មោះអតិថិជន";
                        break;
                    case "int_coid":
                        c.HeaderText = "លេខCO";
                        break;
                    case "var_coname":
                        c.HeaderText = "ឈ្មោះCO";
                        break;
                    case "dou_total":
                        c.HeaderText = "ប្រាក់ត្រូវបង់";
                        break;
                    case "dou_total_paid":
                        c.HeaderText = "ប្រាក់ទទួលបានសរុប";
                        break;
                    case "dou_prin_paid":
                        c.HeaderText = "ប្រាក់ដើមទទួលបាន";
                        break;
                    case "dou_int_paid":
                        c.HeaderText = "ការប្រាក់ទទួលបាន";
                        break;
                    case "dat_date":
                        c.HeaderText = "ថ្ងៃទទួលប្រាក់";
                        break;
                    case "dou_less":
                        c.HeaderText = "ប្រាក់ខ្វះ";
                        break;
                    case "dou_extra":
                        c.HeaderText = "ប្រាក់លើស";
                        break;
                }
            });
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            frmReport frmreport = new frmReport();
            frmreport.reportViewer1.LocalReport.ReportEmbeddedResource = "Micro_Finance.REPORTFILE.CUSPAYMENTRECORD_RP.rdlc";
            frmreport.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("DataSet1", ds.Tables[0]);
            frmreport.reportViewer1.LocalReport.DataSources.Add(rpts);
            frmreport.reportViewer1.RefreshReport();
            frmreport.ShowDialog();
        }
    }
}
