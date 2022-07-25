namespace Micro_Finance
{
    partial class frmBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bAdd = new System.Windows.Forms.ToolStripButton();
            this.bEdit = new System.Windows.Forms.ToolStripButton();
            this.bDel = new System.Windows.Forms.ToolStripButton();
            this.bPrintSchedule = new System.Windows.Forms.ToolStripButton();
            this.bPrintHistory = new System.Windows.Forms.ToolStripButton();
            this.lbPage = new System.Windows.Forms.Label();
            this.b_last = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_pre = new System.Windows.Forms.Button();
            this.b_first = new System.Windows.Forms.Button();
            this.t_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.k_clear = new System.Windows.Forms.CheckBox();
            this.t_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_to = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.c_branch = new System.Windows.Forms.ComboBox();
            this.l_branch = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAdd,
            this.bEdit,
            this.bDel,
            this.bPrintSchedule,
            this.bPrintHistory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1398, 29);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bAdd
            // 
            this.bAdd.Image = global::Micro_Finance.Properties.Resources.download;
            this.bAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(39, 26);
            this.bAdd.Text = "ថ្មី";
            this.bAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Image = global::Micro_Finance.Properties.Resources.file_edit;
            this.bEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(63, 26);
            this.bEdit.Text = "កែប្រែ";
            this.bEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // bDel
            // 
            this.bDel.Image = global::Micro_Finance.Properties.Resources.Delete_Icon;
            this.bDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(53, 26);
            this.bDel.Text = "លុប";
            this.bDel.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // bPrintSchedule
            // 
            this.bPrintSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bPrintSchedule.Name = "bPrintSchedule";
            this.bPrintSchedule.Size = new System.Drawing.Size(115, 26);
            this.bPrintSchedule.Text = "ព្រីនតារាងបង់ប្រាក់";
            this.bPrintSchedule.ToolTipText = "ព្រីនតារាងបង់ប្រាក់";
            this.bPrintSchedule.Click += new System.EventHandler(this.bPrintSchedule_Click);
            // 
            // bPrintHistory
            // 
            this.bPrintHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bPrintHistory.Name = "bPrintHistory";
            this.bPrintHistory.Size = new System.Drawing.Size(111, 26);
            this.bPrintHistory.Text = "ព្រីនប្រវត្តិបង់ប្រាក់";
            this.bPrintHistory.ToolTipText = "ព្រីនប្រវត្តិបង់ប្រាក់";
            this.bPrintHistory.Click += new System.EventHandler(this.bPrintHistory_Click);
            // 
            // lbPage
            // 
            this.lbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPage.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPage.Location = new System.Drawing.Point(1234, 694);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(70, 35);
            this.lbPage.TabIndex = 19;
            this.lbPage.Text = "14-14";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_last
            // 
            this.b_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_last.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_last.Location = new System.Drawing.Point(1351, 694);
            this.b_last.Name = "b_last";
            this.b_last.Size = new System.Drawing.Size(35, 35);
            this.b_last.TabIndex = 18;
            this.b_last.Text = ">>";
            this.b_last.UseVisualStyleBackColor = true;
            // 
            // b_next
            // 
            this.b_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_next.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_next.Location = new System.Drawing.Point(1310, 694);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(35, 35);
            this.b_next.TabIndex = 17;
            this.b_next.Text = ">";
            this.b_next.UseVisualStyleBackColor = true;
            // 
            // b_pre
            // 
            this.b_pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pre.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pre.Location = new System.Drawing.Point(1193, 694);
            this.b_pre.Name = "b_pre";
            this.b_pre.Size = new System.Drawing.Size(35, 35);
            this.b_pre.TabIndex = 16;
            this.b_pre.Text = "<";
            this.b_pre.UseVisualStyleBackColor = true;
            // 
            // b_first
            // 
            this.b_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_first.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_first.Location = new System.Drawing.Point(1152, 694);
            this.b_first.Name = "b_first";
            this.b_first.Size = new System.Drawing.Size(35, 35);
            this.b_first.TabIndex = 15;
            this.b_first.Text = "<<";
            this.b_first.UseVisualStyleBackColor = true;
            // 
            // t_search
            // 
            this.t_search.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_search.Location = new System.Drawing.Point(85, 68);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(474, 29);
            this.t_search.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "ស្វែងរក";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // k_clear
            // 
            this.k_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.k_clear.AutoSize = true;
            this.k_clear.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_clear.Location = new System.Drawing.Point(1220, 68);
            this.k_clear.Name = "k_clear";
            this.k_clear.Size = new System.Drawing.Size(166, 26);
            this.k_clear.TabIndex = 22;
            this.k_clear.Text = "បង្ហាញតែអតិថិជនបង់ផ្តាច់";
            this.k_clear.UseVisualStyleBackColor = true;
            // 
            // t_from
            // 
            this.t_from.CustomFormat = "dd-MM-yyyy";
            this.t_from.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_from.Location = new System.Drawing.Point(639, 68);
            this.t_from.Margin = new System.Windows.Forms.Padding(4);
            this.t_from.Name = "t_from";
            this.t_from.Size = new System.Drawing.Size(155, 29);
            this.t_from.TabIndex = 23;
            this.t_from.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "ចាប់ពីថ្ងៃៈ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "ទៅដល់ថ្ងៃៈ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_to
            // 
            this.t_to.CustomFormat = "dd-MM-yyyy";
            this.t_to.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_to.Location = new System.Drawing.Point(893, 68);
            this.t_to.Margin = new System.Windows.Forms.Padding(4);
            this.t_to.Name = "t_to";
            this.t_to.Size = new System.Drawing.Size(155, 29);
            this.t_to.TabIndex = 26;
            this.t_to.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(1055, 68);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 29);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "ស្វែងរក";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Location = new System.Drawing.Point(16, 103);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1370, 585);
            this.dgv.TabIndex = 3;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBorrow_MouseDoubleClick);
            // 
            // c_branch
            // 
            this.c_branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_branch.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_branch.FormattingEnabled = true;
            this.c_branch.Location = new System.Drawing.Point(85, 32);
            this.c_branch.Name = "c_branch";
            this.c_branch.Size = new System.Drawing.Size(474, 30);
            this.c_branch.TabIndex = 28;
            // 
            // l_branch
            // 
            this.l_branch.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_branch.Location = new System.Drawing.Point(12, 32);
            this.l_branch.Name = "l_branch";
            this.l_branch.Size = new System.Drawing.Size(67, 29);
            this.l_branch.TabIndex = 29;
            this.l_branch.Text = "សាខា";
            this.l_branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1398, 741);
            this.Controls.Add(this.c_branch);
            this.Controls.Add(this.l_branch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.t_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_from);
            this.Controls.Add(this.k_clear);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.b_last);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.b_pre);
            this.Controls.Add(this.b_first);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BORROW FORM";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Class.MyDatagridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bAdd;
        private System.Windows.Forms.ToolStripButton bEdit;
        private System.Windows.Forms.ToolStripButton bDel;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Button b_last;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_pre;
        private System.Windows.Forms.Button b_first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox k_clear;
        public System.Windows.Forms.DateTimePicker t_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker t_to;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.ToolStripButton bPrintSchedule;
        private System.Windows.Forms.ToolStripButton bPrintHistory;
        public System.Windows.Forms.ComboBox c_branch;
        private System.Windows.Forms.Label l_branch;
    }
}