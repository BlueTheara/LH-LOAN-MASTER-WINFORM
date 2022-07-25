namespace Micro_Finance
{
    partial class frmCapitalAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapitalAll));
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.t_count = new System.Windows.Forms.TextBox();
            this.t_total = new System.Windows.Forms.TextBox();
            this.t_prin = new System.Windows.Forms.TextBox();
            this.t_int = new System.Windows.Forms.TextBox();
            this.t_total_paid = new System.Windows.Forms.TextBox();
            this.t_prin_paid = new System.Windows.Forms.TextBox();
            this.t_int_paid = new System.Windows.Forms.TextBox();
            this.t_total_bal = new System.Windows.Forms.TextBox();
            this.t_prin_bal = new System.Windows.Forms.TextBox();
            this.t_int_bal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.b_search = new System.Windows.Forms.Button();
            this.t_to = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.t_from = new System.Windows.Forms.DateTimePicker();
            this.b_print = new System.Windows.Forms.Button();
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
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 49);
            this.dgv.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1324, 448);
            this.dgv.TabIndex = 0;
            // 
            // t_count
            // 
            this.t_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_count.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_count.Location = new System.Drawing.Point(175, 508);
            this.t_count.Margin = new System.Windows.Forms.Padding(4);
            this.t_count.Name = "t_count";
            this.t_count.ReadOnly = true;
            this.t_count.Size = new System.Drawing.Size(239, 29);
            this.t_count.TabIndex = 2;
            // 
            // t_total
            // 
            this.t_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_total.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_total.Location = new System.Drawing.Point(175, 545);
            this.t_total.Margin = new System.Windows.Forms.Padding(4);
            this.t_total.Name = "t_total";
            this.t_total.ReadOnly = true;
            this.t_total.Size = new System.Drawing.Size(239, 29);
            this.t_total.TabIndex = 3;
            // 
            // t_prin
            // 
            this.t_prin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_prin.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_prin.Location = new System.Drawing.Point(175, 582);
            this.t_prin.Margin = new System.Windows.Forms.Padding(4);
            this.t_prin.Name = "t_prin";
            this.t_prin.ReadOnly = true;
            this.t_prin.Size = new System.Drawing.Size(239, 29);
            this.t_prin.TabIndex = 4;
            // 
            // t_int
            // 
            this.t_int.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_int.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_int.Location = new System.Drawing.Point(175, 619);
            this.t_int.Margin = new System.Windows.Forms.Padding(4);
            this.t_int.Name = "t_int";
            this.t_int.ReadOnly = true;
            this.t_int.Size = new System.Drawing.Size(239, 29);
            this.t_int.TabIndex = 5;
            // 
            // t_total_paid
            // 
            this.t_total_paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_total_paid.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_total_paid.Location = new System.Drawing.Point(605, 545);
            this.t_total_paid.Margin = new System.Windows.Forms.Padding(4);
            this.t_total_paid.Name = "t_total_paid";
            this.t_total_paid.ReadOnly = true;
            this.t_total_paid.Size = new System.Drawing.Size(269, 29);
            this.t_total_paid.TabIndex = 6;
            // 
            // t_prin_paid
            // 
            this.t_prin_paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_prin_paid.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_prin_paid.Location = new System.Drawing.Point(605, 582);
            this.t_prin_paid.Margin = new System.Windows.Forms.Padding(4);
            this.t_prin_paid.Name = "t_prin_paid";
            this.t_prin_paid.ReadOnly = true;
            this.t_prin_paid.Size = new System.Drawing.Size(269, 29);
            this.t_prin_paid.TabIndex = 7;
            // 
            // t_int_paid
            // 
            this.t_int_paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_int_paid.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_int_paid.Location = new System.Drawing.Point(605, 619);
            this.t_int_paid.Margin = new System.Windows.Forms.Padding(4);
            this.t_int_paid.Name = "t_int_paid";
            this.t_int_paid.ReadOnly = true;
            this.t_int_paid.Size = new System.Drawing.Size(269, 29);
            this.t_int_paid.TabIndex = 8;
            // 
            // t_total_bal
            // 
            this.t_total_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_total_bal.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_total_bal.Location = new System.Drawing.Point(1068, 545);
            this.t_total_bal.Margin = new System.Windows.Forms.Padding(4);
            this.t_total_bal.Name = "t_total_bal";
            this.t_total_bal.ReadOnly = true;
            this.t_total_bal.Size = new System.Drawing.Size(269, 29);
            this.t_total_bal.TabIndex = 9;
            // 
            // t_prin_bal
            // 
            this.t_prin_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_prin_bal.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_prin_bal.Location = new System.Drawing.Point(1068, 582);
            this.t_prin_bal.Margin = new System.Windows.Forms.Padding(4);
            this.t_prin_bal.Name = "t_prin_bal";
            this.t_prin_bal.ReadOnly = true;
            this.t_prin_bal.Size = new System.Drawing.Size(269, 29);
            this.t_prin_bal.TabIndex = 10;
            // 
            // t_int_bal
            // 
            this.t_int_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.t_int_bal.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_int_bal.Location = new System.Drawing.Point(1068, 619);
            this.t_int_bal.Margin = new System.Windows.Forms.Padding(4);
            this.t_int_bal.Name = "t_int_bal";
            this.t_int_bal.ReadOnly = true;
            this.t_int_bal.Size = new System.Drawing.Size(269, 29);
            this.t_int_bal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label1.Location = new System.Drawing.Point(12, 508);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ចំនួនអតិថិជនសរុប :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label2.Location = new System.Drawing.Point(12, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "ប្រាក់បញ្ចេញសរុប :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label3.Location = new System.Drawing.Point(12, 582);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "ប្រាក់ដើមបញ្ចេញសរុប :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label4.Location = new System.Drawing.Point(12, 619);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "ការប្រាក់បញ្ចេញសរុប :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label5.Location = new System.Drawing.Point(429, 545);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "ប្រាក់បង់រួចសរុប :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label6.Location = new System.Drawing.Point(429, 582);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "ប្រាក់ដើមបង់រួចសរុប :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label7.Location = new System.Drawing.Point(429, 619);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "ការប្រាក់បង់រួចសរុប :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label8.Location = new System.Drawing.Point(882, 545);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "ប្រាក់នៅសល់សរុប :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label9.Location = new System.Drawing.Point(882, 582);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "ប្រាក់ដើមនៅសល់សរុប :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label10.Location = new System.Drawing.Point(882, 619);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "ការប្រាក់នៅសល់សរុប :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.SystemColors.Control;
            this.b_search.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.b_search.Location = new System.Drawing.Point(498, 9);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(107, 29);
            this.b_search.TabIndex = 32;
            this.b_search.Text = "ស្វែងរក";
            this.b_search.UseVisualStyleBackColor = false;
            // 
            // t_to
            // 
            this.t_to.CustomFormat = "dd-MM-yyyy";
            this.t_to.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_to.Location = new System.Drawing.Point(336, 9);
            this.t_to.Margin = new System.Windows.Forms.Padding(4);
            this.t_to.Name = "t_to";
            this.t_to.Size = new System.Drawing.Size(155, 29);
            this.t_to.TabIndex = 31;
            this.t_to.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(244, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "ទៅដល់ថ្ងៃៈ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "ចាប់ពីថ្ងៃៈ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_from
            // 
            this.t_from.CustomFormat = "dd-MM-yyyy";
            this.t_from.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_from.Location = new System.Drawing.Point(82, 9);
            this.t_from.Margin = new System.Windows.Forms.Padding(4);
            this.t_from.Name = "t_from";
            this.t_from.Size = new System.Drawing.Size(155, 29);
            this.t_from.TabIndex = 28;
            this.t_from.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // b_print
            // 
            this.b_print.BackColor = System.Drawing.SystemColors.Control;
            this.b_print.Font = new System.Drawing.Font("Khmer OS System", 8.25F);
            this.b_print.Location = new System.Drawing.Point(611, 9);
            this.b_print.Name = "b_print";
            this.b_print.Size = new System.Drawing.Size(107, 29);
            this.b_print.TabIndex = 35;
            this.b_print.Text = "ព្រីន";
            this.b_print.UseVisualStyleBackColor = false;
            this.b_print.Click += new System.EventHandler(this.b_print_Click);
            // 
            // frmCapitalAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.b_print);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.t_to);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.t_from);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_int_bal);
            this.Controls.Add(this.t_prin_bal);
            this.Controls.Add(this.t_total_bal);
            this.Controls.Add(this.t_int_paid);
            this.Controls.Add(this.t_prin_paid);
            this.Controls.Add(this.t_total_paid);
            this.Controls.Add(this.t_int);
            this.Controls.Add(this.t_prin);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.t_count);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapitalAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPITAL ALL BRANCH FORM";
            this.Load += new System.EventHandler(this.frmCapital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Class.MyDatagridView dgv;
        private System.Windows.Forms.TextBox t_count;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.TextBox t_prin;
        private System.Windows.Forms.TextBox t_int;
        private System.Windows.Forms.TextBox t_total_paid;
        private System.Windows.Forms.TextBox t_prin_paid;
        private System.Windows.Forms.TextBox t_int_paid;
        private System.Windows.Forms.TextBox t_total_bal;
        private System.Windows.Forms.TextBox t_prin_bal;
        private System.Windows.Forms.TextBox t_int_bal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button b_search;
        public System.Windows.Forms.DateTimePicker t_to;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker t_from;
        private System.Windows.Forms.Button b_print;
    }
}