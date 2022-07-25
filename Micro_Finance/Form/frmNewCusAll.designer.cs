namespace Micro_Finance
{
    partial class frmNewCusAll
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
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t_to = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.t_from = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_count = new System.Windows.Forms.TextBox();
            this.t_int = new System.Windows.Forms.TextBox();
            this.t_prin = new System.Windows.Forms.TextBox();
            this.t_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 53);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1325, 553);
            this.dgv.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(506, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "ស្វែងរក";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "ព្រីន";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_to
            // 
            this.t_to.CustomFormat = "dd-MM-yyyy";
            this.t_to.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_to.Location = new System.Drawing.Point(338, 10);
            this.t_to.Margin = new System.Windows.Forms.Padding(4);
            this.t_to.Name = "t_to";
            this.t_to.Size = new System.Drawing.Size(155, 29);
            this.t_to.TabIndex = 35;
            this.t_to.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 30);
            this.label11.TabIndex = 34;
            this.label11.Text = "ទៅដល់ថ្ងៃៈ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 30);
            this.label12.TabIndex = 33;
            this.label12.Text = "ចាប់ពីថ្ងៃៈ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_from
            // 
            this.t_from.CustomFormat = "dd-MM-yyyy";
            this.t_from.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_from.Location = new System.Drawing.Point(94, 9);
            this.t_from.Margin = new System.Windows.Forms.Padding(4);
            this.t_from.Name = "t_from";
            this.t_from.Size = new System.Drawing.Size(155, 29);
            this.t_from.TabIndex = 32;
            this.t_from.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label5.Location = new System.Drawing.Point(426, 616);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "ចំនួនអតិថិជនសរុបៈ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label4.Location = new System.Drawing.Point(9, 690);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "ការប្រាក់បញ្ចេញ :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label3.Location = new System.Drawing.Point(9, 653);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "ប្រាក់ដើមបញ្ចេញ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label8.Location = new System.Drawing.Point(9, 616);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "ប្រាក់បញ្ចេញសរុប :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_count
            // 
            this.t_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_count.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_count.Location = new System.Drawing.Point(602, 616);
            this.t_count.Margin = new System.Windows.Forms.Padding(4);
            this.t_count.Name = "t_count";
            this.t_count.ReadOnly = true;
            this.t_count.Size = new System.Drawing.Size(269, 29);
            this.t_count.TabIndex = 39;
            // 
            // t_int
            // 
            this.t_int.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_int.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_int.Location = new System.Drawing.Point(172, 690);
            this.t_int.Margin = new System.Windows.Forms.Padding(4);
            this.t_int.Name = "t_int";
            this.t_int.ReadOnly = true;
            this.t_int.Size = new System.Drawing.Size(239, 29);
            this.t_int.TabIndex = 38;
            // 
            // t_prin
            // 
            this.t_prin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_prin.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_prin.Location = new System.Drawing.Point(172, 653);
            this.t_prin.Margin = new System.Windows.Forms.Padding(4);
            this.t_prin.Name = "t_prin";
            this.t_prin.ReadOnly = true;
            this.t_prin.Size = new System.Drawing.Size(239, 29);
            this.t_prin.TabIndex = 37;
            // 
            // t_total
            // 
            this.t_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_total.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_total.Location = new System.Drawing.Point(172, 616);
            this.t_total.Margin = new System.Windows.Forms.Padding(4);
            this.t_total.Name = "t_total";
            this.t_total.ReadOnly = true;
            this.t_total.Size = new System.Drawing.Size(239, 29);
            this.t_total.TabIndex = 36;
            // 
            // frmNewCusAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 728);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_count);
            this.Controls.Add(this.t_int);
            this.Controls.Add(this.t_prin);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.t_to);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.t_from);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "frmNewCusAll";
            this.Text = "New Customer Summary All Branches";
            this.Load += new System.EventHandler(this.frmCOIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Class.MyDatagridView dgv;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker t_to;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker t_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_count;
        private System.Windows.Forms.TextBox t_int;
        private System.Windows.Forms.TextBox t_prin;
        private System.Windows.Forms.TextBox t_total;
    }
}