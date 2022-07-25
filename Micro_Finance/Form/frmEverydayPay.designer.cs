namespace Micro_Finance
{
    partial class frmEverydayPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEverydayPay));
            this.dgv = new Class.MyDatagridView();
            this.label1 = new System.Windows.Forms.Label();
            this.c_co_id = new System.Windows.Forms.ComboBox();
            this.c_co_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_count = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_late_to = new System.Windows.Forms.TextBox();
            this.t_late_from = new System.Windows.Forms.TextBox();
            this.k_late = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_print_all = new System.Windows.Forms.Button();
            this.b_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 141);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1326, 514);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "លេខ CO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c_co_id
            // 
            this.c_co_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_co_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_co_id.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_co_id.FormattingEnabled = true;
            this.c_co_id.Location = new System.Drawing.Point(458, 37);
            this.c_co_id.Name = "c_co_id";
            this.c_co_id.Size = new System.Drawing.Size(261, 30);
            this.c_co_id.TabIndex = 2;
            this.c_co_id.SelectedIndexChanged += new System.EventHandler(this.cmbCOID_SelectedIndexChanged);
            // 
            // c_co_name
            // 
            this.c_co_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_co_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_co_name.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_co_name.FormattingEnabled = true;
            this.c_co_name.Location = new System.Drawing.Point(813, 37);
            this.c_co_name.Name = "c_co_name";
            this.c_co_name.Size = new System.Drawing.Size(239, 30);
            this.c_co_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ឈ្មោះCO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_count
            // 
            this.t_count.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_count.Location = new System.Drawing.Point(132, 37);
            this.t_count.Name = "t_count";
            this.t_count.ReadOnly = true;
            this.t_count.Size = new System.Drawing.Size(193, 29);
            this.t_count.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.t_late_to);
            this.groupBox1.Controls.Add(this.t_late_from);
            this.groupBox1.Controls.Add(this.k_late);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.b_print_all);
            this.groupBox1.Controls.Add(this.b_print);
            this.groupBox1.Controls.Add(this.t_count);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // t_late_to
            // 
            this.t_late_to.Enabled = false;
            this.t_late_to.Location = new System.Drawing.Point(238, 80);
            this.t_late_to.Name = "t_late_to";
            this.t_late_to.Size = new System.Drawing.Size(87, 26);
            this.t_late_to.TabIndex = 12;
            this.t_late_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToLate_KeyPress);
            // 
            // t_late_from
            // 
            this.t_late_from.Enabled = false;
            this.t_late_from.Location = new System.Drawing.Point(132, 80);
            this.t_late_from.Name = "t_late_from";
            this.t_late_from.Size = new System.Drawing.Size(87, 26);
            this.t_late_from.TabIndex = 11;
            this.t_late_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFLate_KeyPress);
            // 
            // k_late
            // 
            this.k_late.AutoSize = true;
            this.k_late.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_late.Location = new System.Drawing.Point(69, 84);
            this.k_late.Name = "k_late";
            this.k_late.Size = new System.Drawing.Size(52, 26);
            this.k_late.TabIndex = 10;
            this.k_late.Text = "យឺត";
            this.k_late.UseVisualStyleBackColor = true;
            this.k_late.CheckedChanged += new System.EventHandler(this.chLate_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "ចំនួនអតិថិជនៈ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_print_all
            // 
            this.b_print_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_print_all.Location = new System.Drawing.Point(1188, 29);
            this.b_print_all.Name = "b_print_all";
            this.b_print_all.Size = new System.Drawing.Size(123, 52);
            this.b_print_all.TabIndex = 1;
            this.b_print_all.Text = "Print All COs";
            this.b_print_all.UseVisualStyleBackColor = true;
            this.b_print_all.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_print
            // 
            this.b_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_print.Location = new System.Drawing.Point(1052, 29);
            this.b_print.Name = "b_print";
            this.b_print.Size = new System.Drawing.Size(127, 52);
            this.b_print.TabIndex = 0;
            this.b_print.Text = "Print One CO";
            this.b_print.UseVisualStyleBackColor = true;
            this.b_print.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEverydayPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_co_name);
            this.Controls.Add(this.c_co_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmEverydayPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAILY PAYMENT FORM";
            this.Load += new System.EventHandler(this.frmEverydayPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Class.MyDatagridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_co_name;
        public System.Windows.Forms.ComboBox c_co_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_print;
        private System.Windows.Forms.Button b_print_all;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_late_to;
        private System.Windows.Forms.TextBox t_late_from;
        private System.Windows.Forms.CheckBox k_late;
    }
}