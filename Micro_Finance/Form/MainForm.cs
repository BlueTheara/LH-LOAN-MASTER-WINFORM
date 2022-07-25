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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            b_close.Click += Menu_Click;
            b_cus.Click += Menu_Click;
            b_co.Click += Menu_Click;
            b_loan.Click += Menu_Click;
            b_pay.Click += Menu_Click;
            b_daily.Click += Menu_Click;
            b_capital.Click += Menu_Click;
            b_income.Click += Menu_Click;
            b_new_cus_mas.Click += Menu_Click;
            b_new_cus_det.Click += Menu_Click;
            b_capital_all.Click += Menu_Click;
            b_income_all.Click += Menu_Click;
            b_new_cus_all.Click += Menu_Click;
        }
        private void Menu_Click(object sender, EventArgs e) {
            if (sender == b_close) {
                DialogResult dr;
                dr = MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                if (sender == b_co)
                {
                    frmCO frmco = new frmCO();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_cus)
                {
                    frmCus frmco = new frmCus();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_loan)
                {
                    frmBorrow frmco = new frmBorrow();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_pay)
                {
                    frmPay frmco = new frmPay();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_daily)
                {
                    frmEverydayPay frmco = new frmEverydayPay();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_capital)
                {
                    frmCapital frmco = new frmCapital();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_income)
                {
                    frmCOIncome frmco = new frmCOIncome();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_new_cus_mas)
                {
                    frmNewCus frmco = new frmNewCus();
                    frmco.vDet = false;
                    frmco.Text = "CO's New Customer Summary";
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_new_cus_det)
                {
                    frmNewCus frmco = new frmNewCus();
                    frmco.vDet = true;
                    frmco.Text = "CO's New Customer Details";
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_capital_all)
                {
                    frmCapitalAll frmco = new frmCapitalAll();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_income_all)
                {
                    frmCOIncomeAll frmco = new frmCOIncomeAll();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }
                else if (sender == b_new_cus_all)
                {
                    frmNewCusAll frmco = new frmNewCusAll();
                    frmco.Show();
                    frmco.MdiParent = this;
                    frmco.WindowState = FormWindowState.Maximized;
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmBG frmc = new frmBG();
            frmc.Show();
            frmc.MdiParent = this;
            frmc.WindowState = FormWindowState.Maximized;
        }      

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
