namespace Micro_Finance
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.humanResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_loan = new System.Windows.Forms.ToolStripMenuItem();
            this.b_pay = new System.Windows.Forms.ToolStripMenuItem();
            this.b_daily = new System.Windows.Forms.ToolStripMenuItem();
            this.b_capital = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.b_income = new System.Windows.Forms.ToolStripMenuItem();
            this.b_new_cus_mas = new System.Windows.Forms.ToolStripMenuItem();
            this.b_new_cus_det = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.b_capital_all = new System.Windows.Forms.ToolStripMenuItem();
            this.b_income_all = new System.Windows.Forms.ToolStripMenuItem();
            this.b_new_cus_all = new System.Windows.Forms.ToolStripMenuItem();
            this.b_close = new System.Windows.Forms.ToolStripMenuItem();
            this.b_cus = new System.Windows.Forms.ToolStripMenuItem();
            this.b_co = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.humanResourceToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.b_close});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // humanResourceToolStripMenuItem
            // 
            this.humanResourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_cus,
            this.b_co});
            this.humanResourceToolStripMenuItem.Name = "humanResourceToolStripMenuItem";
            this.humanResourceToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.humanResourceToolStripMenuItem.Text = "&Human Resource";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_loan,
            this.b_pay,
            this.b_daily,
            this.b_capital,
            this.toolStripSeparator2,
            this.b_income,
            this.b_new_cus_mas,
            this.b_new_cus_det,
            this.toolStripSeparator3,
            this.b_capital_all,
            this.b_income_all,
            this.b_new_cus_all});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.transactionToolStripMenuItem.Text = "&Transaction";
            // 
            // b_loan
            // 
            this.b_loan.Name = "b_loan";
            this.b_loan.Size = new System.Drawing.Size(282, 22);
            this.b_loan.Text = "&Borrow Processing";
            // 
            // b_pay
            // 
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(282, 22);
            this.b_pay.Text = "Repayment";
            // 
            // b_daily
            // 
            this.b_daily.Name = "b_daily";
            this.b_daily.Size = new System.Drawing.Size(282, 22);
            this.b_daily.Text = "Daily Payment";
            // 
            // b_capital
            // 
            this.b_capital.Name = "b_capital";
            this.b_capital.Size = new System.Drawing.Size(282, 22);
            this.b_capital.Text = "Capital Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // b_income
            // 
            this.b_income.Name = "b_income";
            this.b_income.Size = new System.Drawing.Size(282, 22);
            this.b_income.Text = "CO Income";
            // 
            // b_new_cus_mas
            // 
            this.b_new_cus_mas.Name = "b_new_cus_mas";
            this.b_new_cus_mas.Size = new System.Drawing.Size(282, 22);
            this.b_new_cus_mas.Text = "CO\'s New Customer Summary";
            // 
            // b_new_cus_det
            // 
            this.b_new_cus_det.Name = "b_new_cus_det";
            this.b_new_cus_det.Size = new System.Drawing.Size(282, 22);
            this.b_new_cus_det.Text = "CO\'s New Customer Details";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(279, 6);
            // 
            // b_capital_all
            // 
            this.b_capital_all.Name = "b_capital_all";
            this.b_capital_all.Size = new System.Drawing.Size(282, 22);
            this.b_capital_all.Text = "Capital All Branch";
            // 
            // b_income_all
            // 
            this.b_income_all.Name = "b_income_all";
            this.b_income_all.Size = new System.Drawing.Size(282, 22);
            this.b_income_all.Text = "Income All Branch";
            // 
            // b_new_cus_all
            // 
            this.b_new_cus_all.Name = "b_new_cus_all";
            this.b_new_cus_all.Size = new System.Drawing.Size(282, 22);
            this.b_new_cus_all.Text = "New Customer All Branch";
            // 
            // b_close
            // 
            this.b_close.Image = global::Micro_Finance.Properties.Resources.deletered;
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(100, 22);
            this.b_close.Text = "Exit";
            // 
            // b_cus
            // 
            this.b_cus.Image = global::Micro_Finance.Properties.Resources.group_fav_256;
            this.b_cus.Name = "b_cus";
            this.b_cus.Size = new System.Drawing.Size(232, 22);
            this.b_cus.Text = "&Customer Management";
            // 
            // b_co
            // 
            this.b_co.Image = global::Micro_Finance.Properties.Resources.Employee_Management;
            this.b_co.Name = "b_co";
            this.b_co.Size = new System.Drawing.Size(232, 22);
            this.b_co.Text = "&CO Management";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 515);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem b_close;
        private System.Windows.Forms.ToolStripMenuItem humanResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b_co;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b_loan;
        private System.Windows.Forms.ToolStripMenuItem b_cus;
        private System.Windows.Forms.ToolStripMenuItem b_capital;
        private System.Windows.Forms.ToolStripMenuItem b_income;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem b_new_cus_mas;
        private System.Windows.Forms.ToolStripMenuItem b_daily;
        private System.Windows.Forms.ToolStripMenuItem b_new_cus_det;
        private System.Windows.Forms.ToolStripMenuItem b_pay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem b_capital_all;
        private System.Windows.Forms.ToolStripMenuItem b_income_all;
        private System.Windows.Forms.ToolStripMenuItem b_new_cus_all;

    }
}