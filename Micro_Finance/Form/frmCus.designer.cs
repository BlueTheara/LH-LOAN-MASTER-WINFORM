namespace Micro_Finance
{
    partial class frmCus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCus));
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.t_search = new System.Windows.Forms.TextBox();
            this.b_first = new System.Windows.Forms.Button();
            this.b_pre = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_last = new System.Windows.Forms.Button();
            this.lbPage = new System.Windows.Forms.Label();
            this.c_branch = new System.Windows.Forms.ComboBox();
            this.l_branch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cid,
            this.uname,
            this.pwd,
            this.usertype,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 104);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 35;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1301, 279);
            this.dgv.TabIndex = 7;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "ល.រ";
            this.Column1.MinimumWidth = 3;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cid
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.cid.DefaultCellStyle = dataGridViewCellStyle2;
            this.cid.HeaderText = "លេខសំគាល់";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // uname
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.uname.DefaultCellStyle = dataGridViewCellStyle3;
            this.uname.HeaderText = "ឈ្មោះអតិថិជន";
            this.uname.Name = "uname";
            this.uname.ReadOnly = true;
            // 
            // pwd
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            dataGridViewCellStyle4.NullValue = null;
            this.pwd.DefaultCellStyle = dataGridViewCellStyle4;
            this.pwd.HeaderText = "លេខទូរស័ព្ទ";
            this.pwd.Name = "pwd";
            this.pwd.ReadOnly = true;
            // 
            // usertype
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.usertype.DefaultCellStyle = dataGridViewCellStyle5;
            this.usertype.HeaderText = "អាស័យដ្ធាន";
            this.usertype.Name = "usertype";
            this.usertype.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "ទ្រព្យបញ្ចាំ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.HeaderText = "អ្នកធានា";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "លេខសំគាល់ CO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column4.HeaderText = "ឈ្មោះ CO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1325, 29);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Micro_Finance.Properties.Resources.download;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(43, 26);
            this.tsbAdd.Text = "ថ្មី";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Micro_Finance.Properties.Resources.file_edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(67, 26);
            this.tsbEdit.Text = "កែប្រែ";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Micro_Finance.Properties.Resources.Delete_Icon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(57, 26);
            this.tsbDelete.Text = "លុប";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(0, 26);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "ស្វែងរក";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_search
            // 
            this.t_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_search.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_search.Location = new System.Drawing.Point(85, 68);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(1228, 29);
            this.t_search.TabIndex = 9;
            // 
            // b_first
            // 
            this.b_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_first.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_first.Location = new System.Drawing.Point(1079, 390);
            this.b_first.Name = "b_first";
            this.b_first.Size = new System.Drawing.Size(35, 35);
            this.b_first.TabIndex = 10;
            this.b_first.Text = "<<";
            this.b_first.UseVisualStyleBackColor = true;
            // 
            // b_pre
            // 
            this.b_pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pre.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pre.Location = new System.Drawing.Point(1120, 390);
            this.b_pre.Name = "b_pre";
            this.b_pre.Size = new System.Drawing.Size(35, 35);
            this.b_pre.TabIndex = 11;
            this.b_pre.Text = "<";
            this.b_pre.UseVisualStyleBackColor = true;
            // 
            // b_next
            // 
            this.b_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_next.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_next.Location = new System.Drawing.Point(1237, 390);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(35, 35);
            this.b_next.TabIndex = 12;
            this.b_next.Text = ">";
            this.b_next.UseVisualStyleBackColor = true;
            // 
            // b_last
            // 
            this.b_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_last.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_last.Location = new System.Drawing.Point(1278, 390);
            this.b_last.Name = "b_last";
            this.b_last.Size = new System.Drawing.Size(35, 35);
            this.b_last.TabIndex = 13;
            this.b_last.Text = ">>";
            this.b_last.UseVisualStyleBackColor = true;
            // 
            // lbPage
            // 
            this.lbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPage.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPage.Location = new System.Drawing.Point(1161, 390);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(70, 35);
            this.lbPage.TabIndex = 14;
            this.lbPage.Text = "14-14";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c_branch
            // 
            this.c_branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_branch.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_branch.FormattingEnabled = true;
            this.c_branch.Location = new System.Drawing.Point(85, 32);
            this.c_branch.Name = "c_branch";
            this.c_branch.Size = new System.Drawing.Size(350, 30);
            this.c_branch.TabIndex = 26;
            // 
            // l_branch
            // 
            this.l_branch.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_branch.Location = new System.Drawing.Point(12, 32);
            this.l_branch.Name = "l_branch";
            this.l_branch.Size = new System.Drawing.Size(67, 29);
            this.l_branch.TabIndex = 27;
            this.l_branch.Text = "សាខា";
            this.l_branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 437);
            this.Controls.Add(this.c_branch);
            this.Controls.Add(this.l_branch);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.b_last);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.b_pre);
            this.Controls.Add(this.b_first);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Class.MyDatagridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.Button b_first;
        private System.Windows.Forms.Button b_pre;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_last;
        private System.Windows.Forms.Label lbPage;
        public System.Windows.Forms.ComboBox c_branch;
        private System.Windows.Forms.Label l_branch;
    }
}