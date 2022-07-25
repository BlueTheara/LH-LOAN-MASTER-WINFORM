namespace Micro_Finance
{
    partial class frmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialog));
            this.dgv = new Class.MyDatagridView();
            this.lbPage = new System.Windows.Forms.Label();
            this.b_last = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_pre = new System.Windows.Forms.Button();
            this.b_first = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.ColumnHeadersHeight = 30;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(300, 500);
            this.dgv.TabIndex = 0;
            // 
            // lbPage
            // 
            this.lbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPage.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPage.Location = new System.Drawing.Point(134, 10);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(70, 35);
            this.lbPage.TabIndex = 24;
            this.lbPage.Text = "14-14";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_last
            // 
            this.b_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_last.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_last.Location = new System.Drawing.Point(251, 10);
            this.b_last.Name = "b_last";
            this.b_last.Size = new System.Drawing.Size(35, 35);
            this.b_last.TabIndex = 23;
            this.b_last.Text = ">>";
            this.b_last.UseVisualStyleBackColor = true;
            // 
            // b_next
            // 
            this.b_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_next.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_next.Location = new System.Drawing.Point(210, 10);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(35, 35);
            this.b_next.TabIndex = 22;
            this.b_next.Text = ">";
            this.b_next.UseVisualStyleBackColor = true;
            // 
            // b_pre
            // 
            this.b_pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pre.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pre.Location = new System.Drawing.Point(93, 10);
            this.b_pre.Name = "b_pre";
            this.b_pre.Size = new System.Drawing.Size(35, 35);
            this.b_pre.TabIndex = 21;
            this.b_pre.Text = "<";
            this.b_pre.UseVisualStyleBackColor = true;
            // 
            // b_first
            // 
            this.b_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_first.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_first.Location = new System.Drawing.Point(52, 10);
            this.b_first.Name = "b_first";
            this.b_first.Size = new System.Drawing.Size(35, 35);
            this.b_first.TabIndex = 20;
            this.b_first.Text = "<<";
            this.b_first.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.b_last);
            this.panel1.Controls.Add(this.lbPage);
            this.panel1.Controls.Add(this.b_first);
            this.panel1.Controls.Add(this.b_pre);
            this.panel1.Controls.Add(this.b_next);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 59);
            this.panel1.TabIndex = 25;
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlert";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Class.MyDatagridView dgv;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Button b_last;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_pre;
        private System.Windows.Forms.Button b_first;
        private System.Windows.Forms.Panel panel1;


    }
}