namespace Micro_Finance
{
    partial class frmPay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPay));
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.t_count = new System.Windows.Forms.TextBox();
            this.t_amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_cus_id = new System.Windows.Forms.TextBox();
            this.t_cus_name = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.b_pay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.b_pay_all = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.b_undo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.b_print_schedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.b_print_history = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_id = new System.Windows.Forms.TextBox();
            this.c_branch = new System.Windows.Forms.ComboBox();
            this.l_branch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 197);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1320, 448);
            this.dgv.TabIndex = 5;
            // 
            // t_count
            // 
            this.t_count.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_count.Location = new System.Drawing.Point(528, 109);
            this.t_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_count.Name = "t_count";
            this.t_count.Size = new System.Drawing.Size(267, 29);
            this.t_count.TabIndex = 2;
            // 
            // t_amt
            // 
            this.t_amt.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_amt.Location = new System.Drawing.Point(528, 72);
            this.t_amt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_amt.Name = "t_amt";
            this.t_amt.Size = new System.Drawing.Size(268, 29);
            this.t_amt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "ប្រាក់សរុប";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "ចំនួនដង";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "លេខកូដកម្ចី";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "ឈ្មោះអតិថិជន :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID អតិថិជន";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_cus_id
            // 
            this.t_cus_id.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_cus_id.Location = new System.Drawing.Point(126, 109);
            this.t_cus_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_cus_id.Name = "t_cus_id";
            this.t_cus_id.ReadOnly = true;
            this.t_cus_id.Size = new System.Drawing.Size(268, 29);
            this.t_cus_id.TabIndex = 3;
            // 
            // t_cus_name
            // 
            this.t_cus_name.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_cus_name.Location = new System.Drawing.Point(126, 146);
            this.t_cus_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_cus_name.Name = "t_cus_name";
            this.t_cus_name.ReadOnly = true;
            this.t_cus_name.Size = new System.Drawing.Size(268, 29);
            this.t_cus_name.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_pay,
            this.toolStripSeparator5,
            this.b_pay_all,
            this.toolStripSeparator4,
            this.b_undo,
            this.toolStripSeparator1,
            this.b_print_schedule,
            this.toolStripSeparator3,
            this.b_print_history,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 29);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // b_pay
            // 
            this.b_pay.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pay.Image = global::Micro_Finance.Properties.Resources.donor_pay;
            this.b_pay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(48, 26);
            this.b_pay.Text = "បង់";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // b_pay_all
            // 
            this.b_pay_all.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pay_all.Image = global::Micro_Finance.Properties.Resources.paying_for_ppc_management_services_280x362;
            this.b_pay_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_pay_all.Name = "b_pay_all";
            this.b_pay_all.Size = new System.Drawing.Size(71, 26);
            this.b_pay_all.Text = "បង់ផ្ដាច់";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // b_undo
            // 
            this.b_undo.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_undo.Image = global::Micro_Finance.Properties.Resources.undo_4_256;
            this.b_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_undo.Name = "b_undo";
            this.b_undo.Size = new System.Drawing.Size(58, 26);
            this.b_undo.Text = "Undo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // b_print_schedule
            // 
            this.b_print_schedule.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_print_schedule.Image = global::Micro_Finance.Properties.Resources.Hardware_Printer_Blue_icon;
            this.b_print_schedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_print_schedule.Name = "b_print_schedule";
            this.b_print_schedule.Size = new System.Drawing.Size(53, 26);
            this.b_print_schedule.Text = "Print";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // b_print_history
            // 
            this.b_print_history.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_print_history.Image = global::Micro_Finance.Properties.Resources.Blue_History;
            this.b_print_history.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_print_history.Name = "b_print_history";
            this.b_print_history.Size = new System.Drawing.Size(137, 26);
            this.b_print_history.Text = "ប្រវិត្ដនៃការបង់ប្រាក់";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_id.Location = new System.Drawing.Point(126, 72);
            this.t_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(268, 29);
            this.t_id.TabIndex = 0;
            // 
            // c_branch
            // 
            this.c_branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_branch.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_branch.FormattingEnabled = true;
            this.c_branch.Location = new System.Drawing.Point(126, 35);
            this.c_branch.Name = "c_branch";
            this.c_branch.Size = new System.Drawing.Size(268, 30);
            this.c_branch.TabIndex = 28;
            // 
            // l_branch
            // 
            this.l_branch.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_branch.Location = new System.Drawing.Point(12, 35);
            this.l_branch.Name = "l_branch";
            this.l_branch.Size = new System.Drawing.Size(108, 29);
            this.l_branch.TabIndex = 29;
            this.l_branch.Text = "សាខា";
            this.l_branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.c_branch);
            this.Controls.Add(this.l_branch);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_cus_id);
            this.Controls.Add(this.t_cus_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.t_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_amt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repayment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Class.MyDatagridView dgv;
        private System.Windows.Forms.TextBox t_count;
        private System.Windows.Forms.TextBox t_amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_cus_id;
        private System.Windows.Forms.TextBox t_cus_name;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton b_pay;
        private System.Windows.Forms.ToolStripButton b_pay_all;
        private System.Windows.Forms.ToolStripButton b_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton b_print_schedule;
        private System.Windows.Forms.ToolStripButton b_print_history;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.TextBox t_id;
        public System.Windows.Forms.ComboBox c_branch;
        private System.Windows.Forms.Label l_branch;
    }
}