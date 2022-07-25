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
using forListBox;

namespace Micro_Finance
{
    public partial class frmCO : Form
    {
        public frmCO()
        {
            InitializeComponent();
            ClsGlouble.LoadBranch(c_branch);
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 35;
            dgv.ColumnHeadersDefaultCellStyle.Font = t_search.Font;
            dgv.Columns[0].Width = 35;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].Width = 100;
            b_first.Click += PaginationClick;
            b_pre.Click += PaginationClick;
            b_next.Click += PaginationClick;
            b_last.Click += PaginationClick;
            t_search.KeyPress +=t_search_KeyPress;
            c_branch.SelectedIndexChanged += c_branch_SelectedIndexChanged;
        }

        void c_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_branch.SelectedIndex >= 0) {
                LoadData("SEARCH");
            }
        }

        void PaginationClick(object sender, EventArgs e)
        {
            if (sender == b_first) {
                LoadData("FIRST");
            }
            else if (sender == b_pre) {
                LoadData("PRE");
            }
            else if (sender == b_next) {
                LoadData("NEXT");
            }
            else if (sender == b_last) {
                LoadData("LAST");
            }
        }

        public int vPage = 1, vPageMax = 1;

        public void LoadData(string pAction)
        {
            if (c_branch.SelectedIndex < 0) {
                MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_CO", t_search.Text.Trim() + "[.,;TNC,;.]" + pAction + "[.,;TNC,;.]" + vPage }, ClsGlouble.f_string(c_branch.SelectedValue));
                dgv.Rows.Clear();
                int i = 1;
                ds.Tables[0].Rows.Cast<DataRow>().ToList().ForEach(r =>
                {
                    dgv.Rows.Add(i, r["int_id"], r["var_name"], r["var_tel"], r["var_addr"]);
                    i++;
                });
                vPage = ClsGlouble.f_integer(ds.Tables[1].Rows[0]["int_page"]);
                vPageMax = ClsGlouble.f_integer(ds.Tables[1].Rows[0]["int_page_max"]);
                lbPage.Text = vPage + " - " + vPageMax;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCus_Load(object sender, EventArgs e)
        {
            if (c_branch.SelectedIndex >= 0)
            {
                LoadData("SEARCH");
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (c_branch.SelectedIndex < 0)
            {
                MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmCOSub frmCSUb = new frmCOSub();
            frmCSUb.vAction = "ADD";
            frmCSUb.vDb = ClsGlouble.f_string(c_branch.SelectedValue);
            frmCSUb.fCo = this;
            frmCSUb.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (c_branch.SelectedIndex < 0)
            {
                MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv.CurrentCell != null)
            {
                DataGridViewRow r = dgv.Rows[dgv.CurrentCell.RowIndex];
                frmCOSub frmCos = new frmCOSub();
                frmCos.vAction = "EDIT";
                frmCos.vDb = ClsGlouble.f_string(c_branch.SelectedValue);
                frmCos.fCo = this;
                frmCos.t_id.Text = r.Cells[1].Value.ToString();
                frmCos.ShowDialog();
                vPage = vPage - 1;
                LoadData("NEXT");
            }
            else
            {
                MessageBox.Show("No Row Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (c_branch.SelectedIndex < 0)
            {
                MessageBox.Show("Please Seelct Branch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (dgv.CurrentCell != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Do You Want to Delete This Once?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int id = ClsGlouble.f_integer(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[1].Value);
                        DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "DELETE_CO", id + "" }, ClsGlouble.f_string(c_branch.SelectedValue));
                        int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                        if (result == 0)
                        {
                            MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            vPage = vPage - 1;
                            LoadData("NEXT");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Row Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void stpSearch_Click(object sender, EventArgs e)
        {
            LoadData("SEARCH");
        }

        private void t_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadData("SEARCH");
            }
        }

    }
}





