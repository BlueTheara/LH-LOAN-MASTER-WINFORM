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
    public partial class frmDialog : Form
    {
        public int vPage = 1, vPageMax = 1;
        public string[] vParam;
        public string vModule;
        public delegate void AfterBind(frmDialog sender);
        public event AfterBind afterBind;
        public string vDb = "";

        public frmDialog()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System", 9);
            dgv.LostFocus += dgv_LostFocus;
            b_last.LostFocus += dgv_LostFocus;
            b_first.LostFocus += dgv_LostFocus;
            b_next.LostFocus += dgv_LostFocus;
            b_pre.LostFocus += dgv_LostFocus;
            b_last.Click += PaginationClick;
            b_first.Click += PaginationClick;
            b_next.Click += PaginationClick;
            b_pre.Click += PaginationClick;
        }
        void PaginationClick(object sender, EventArgs e)
        {
            if (sender == b_first)
            {
                LoadData("FIRST");
            }
            else if (sender == b_pre)
            {
                LoadData("PRE");
            }
            else if (sender == b_next)
            {
                LoadData("NEXT");
            }
            else if (sender == b_last)
            {
                LoadData("LAST");
            }
        }

        public void LoadData(string vAction){
            DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { vModule, String.Join("[.,;TNC,;.]", vParam) + "[.,;TNC,;.]" + vAction + "[.,;TNC,;.]" + vPage }, vDb);
            dgv.DataSource = temp_ds.Tables[0];
            vPage = ClsGlouble.f_integer(temp_ds.Tables[1].Rows[0]["int_page"]);
            vPageMax = ClsGlouble.f_integer(temp_ds.Tables[1].Rows[0]["int_page_max"]);
            lbPage.Text = vPage + " - " + vPageMax;
            if (afterBind != null) {
                afterBind(this);
            }
        }

        void dgv_LostFocus(object sender, EventArgs e)
        {
            if (!(b_first.Focused || b_last.Focused || b_next.Focused || b_pre.Focused || dgv.Focused))
                this.Close();
        }
    }
}
