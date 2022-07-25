namespace Micro_Finance
{
    partial class frmBorrowSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowSub));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_term = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_amt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_rate_per = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_rate_amt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.c_type1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.t_rate1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.t_from = new System.Windows.Forms.DateTimePicker();
            this.t_create = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.t_to = new System.Windows.Forms.DateTimePicker();
            this.t_cusid = new System.Windows.Forms.TextBox();
            this.t_cusname = new System.Windows.Forms.TextBox();
            this.t_coname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.btnCancel.Location = new System.Drawing.Point(400, 605);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 44);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "ចាកចេញ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.btnOK.Location = new System.Drawing.Point(277, 605);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 44);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "រក្សាទុក";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "ឈ្មោះអតិថិជន:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "ឈ្មោះCO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "ប្រភេទនៃការបង់:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_term
            // 
            this.t_term.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_term.Location = new System.Drawing.Point(161, 281);
            this.t_term.Name = "t_term";
            this.t_term.Size = new System.Drawing.Size(350, 29);
            this.t_term.TabIndex = 6;
            this.t_term.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriod_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "ចំនួនថ្ងៃ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_amt
            // 
            this.t_amt.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_amt.Location = new System.Drawing.Point(161, 462);
            this.t_amt.Name = "t_amt";
            this.t_amt.Size = new System.Drawing.Size(350, 29);
            this.t_amt.TabIndex = 11;
            this.t_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "ប្រាក់ខ្ចី:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_id
            // 
            this.t_id.Enabled = false;
            this.t_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id.Location = new System.Drawing.Point(161, 72);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(350, 26);
            this.t_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "លេខកូដ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_rate_per
            // 
            this.t_rate_per.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_rate_per.Location = new System.Drawing.Point(161, 497);
            this.t_rate_per.Name = "t_rate_per";
            this.t_rate_per.Size = new System.Drawing.Size(350, 29);
            this.t_rate_per.TabIndex = 12;
            this.t_rate_per.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "ការប្រាក់(%):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c_type
            // 
            this.c_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_type.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_type.FormattingEnabled = true;
            this.c_type.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Week2",
            "Month"});
            this.c_type.Location = new System.Drawing.Point(161, 209);
            this.c_type.Name = "c_type";
            this.c_type.Size = new System.Drawing.Size(350, 30);
            this.c_type.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "IDអតិថិជន:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_rate_amt
            // 
            this.t_rate_amt.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_rate_amt.Location = new System.Drawing.Point(161, 532);
            this.t_rate_amt.Name = "t_rate_amt";
            this.t_rate_amt.ReadOnly = true;
            this.t_rate_amt.Size = new System.Drawing.Size(350, 29);
            this.t_rate_amt.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 26);
            this.label9.TabIndex = 33;
            this.label9.Text = "ការប្រាក់:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_total
            // 
            this.t_total.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_total.Location = new System.Drawing.Point(161, 567);
            this.t_total.Name = "t_total";
            this.t_total.ReadOnly = true;
            this.t_total.Size = new System.Drawing.Size(350, 29);
            this.t_total.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 26);
            this.label10.TabIndex = 35;
            this.label10.Text = "ប្រាក់សរុប:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 26);
            this.label11.TabIndex = 38;
            this.label11.Text = "ថ្ងៃចាប់ផ្តើម:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 26);
            this.label12.TabIndex = 40;
            this.label12.Text = "ថ្ងៃបញ្ចប់:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Khmer OS System", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(540, 63);
            this.label13.TabIndex = 302;
            this.label13.Text = "ពត៍មាននៃការខ្ចីប្រាក់";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c_type1
            // 
            this.c_type1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_type1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_type1.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.c_type1.FormattingEnabled = true;
            this.c_type1.Items.AddRange(new object[] {
            "ថេរ",
            "ប្រែប្រួល"});
            this.c_type1.Location = new System.Drawing.Point(161, 245);
            this.c_type1.Name = "c_type1";
            this.c_type1.Size = new System.Drawing.Size(350, 30);
            this.c_type1.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 30);
            this.label14.TabIndex = 58;
            this.label14.Text = "ប្រភេទការប្រាក់:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_rate1
            // 
            this.t_rate1.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_rate1.Location = new System.Drawing.Point(161, 316);
            this.t_rate1.Name = "t_rate1";
            this.t_rate1.Size = new System.Drawing.Size(350, 29);
            this.t_rate1.TabIndex = 7;
            this.t_rate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate1_KeyPress);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 26);
            this.label15.TabIndex = 60;
            this.label15.Text = "អត្រាប្រែប្រួល:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_from
            // 
            this.t_from.CustomFormat = "dd-MM-yyyy";
            this.t_from.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_from.Location = new System.Drawing.Point(161, 389);
            this.t_from.Margin = new System.Windows.Forms.Padding(4);
            this.t_from.Name = "t_from";
            this.t_from.Size = new System.Drawing.Size(350, 29);
            this.t_from.TabIndex = 9;
            this.t_from.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // t_create
            // 
            this.t_create.CustomFormat = "dd-MM-yyyy";
            this.t_create.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_create.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_create.Location = new System.Drawing.Point(161, 352);
            this.t_create.Margin = new System.Windows.Forms.Padding(4);
            this.t_create.Name = "t_create";
            this.t_create.Size = new System.Drawing.Size(350, 29);
            this.t_create.TabIndex = 8;
            this.t_create.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 26);
            this.label17.TabIndex = 63;
            this.label17.Text = "ថ្ងៃបញ្ចេញប្រាក់:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_to
            // 
            this.t_to.CustomFormat = "dd-MM-yyyy";
            this.t_to.Enabled = false;
            this.t_to.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_to.Location = new System.Drawing.Point(161, 426);
            this.t_to.Margin = new System.Windows.Forms.Padding(4);
            this.t_to.Name = "t_to";
            this.t_to.Size = new System.Drawing.Size(350, 29);
            this.t_to.TabIndex = 10;
            this.t_to.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            // 
            // t_cusid
            // 
            this.t_cusid.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cusid.Location = new System.Drawing.Point(161, 104);
            this.t_cusid.Name = "t_cusid";
            this.t_cusid.Size = new System.Drawing.Size(350, 29);
            this.t_cusid.TabIndex = 1;
            this.t_cusid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_cusid_KeyPress);
            // 
            // t_cusname
            // 
            this.t_cusname.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cusname.Location = new System.Drawing.Point(161, 139);
            this.t_cusname.Name = "t_cusname";
            this.t_cusname.ReadOnly = true;
            this.t_cusname.Size = new System.Drawing.Size(350, 29);
            this.t_cusname.TabIndex = 2;
            // 
            // t_coname
            // 
            this.t_coname.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_coname.Location = new System.Drawing.Point(161, 174);
            this.t_coname.Name = "t_coname";
            this.t_coname.ReadOnly = true;
            this.t_coname.Size = new System.Drawing.Size(350, 29);
            this.t_coname.TabIndex = 3;
            // 
            // frmBorrowSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 661);
            this.Controls.Add(this.t_coname);
            this.Controls.Add(this.t_cusname);
            this.Controls.Add(this.t_cusid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.t_to);
            this.Controls.Add(this.t_create);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.t_from);
            this.Controls.Add(this.t_rate1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.c_type1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t_rate_amt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c_type);
            this.Controls.Add(this.t_rate_per);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_term);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_amt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrowSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.frmBorrowSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox t_term;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox t_amt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox t_rate_per;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox c_type;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox t_rate_amt;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox c_type1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox t_rate1;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DateTimePicker t_from;
        public System.Windows.Forms.DateTimePicker t_create;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.DateTimePicker t_to;
        public System.Windows.Forms.TextBox t_cusid;
        public System.Windows.Forms.TextBox t_cusname;
        public System.Windows.Forms.TextBox t_coname;
    }
}