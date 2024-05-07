namespace Nuochoa
{
    partial class frmSalary
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOffStaff = new System.Windows.Forms.Button();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.gbxInfoSalary = new System.Windows.Forms.GroupBox();
            this.txtTotalSalayList = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkProbation = new System.Windows.Forms.CheckBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cbxStaffCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvwSalary = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.gbxInfoSalary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnOffStaff);
            this.panel2.Controls.Add(this.btnHideForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 64);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(382, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(642, 42);
            this.label10.TabIndex = 34;
            this.label10.Text = "THANH TOÁN LƯƠNG NHÂN VIÊN";
            // 
            // btnOffStaff
            // 
            this.btnOffStaff.BackgroundImage = global::Nuochoa.Properties.Resources.cv;
            this.btnOffStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOffStaff.FlatAppearance.BorderSize = 0;
            this.btnOffStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffStaff.ForeColor = System.Drawing.Color.White;
            this.btnOffStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffStaff.Location = new System.Drawing.Point(1330, 13);
            this.btnOffStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffStaff.Name = "btnOffStaff";
            this.btnOffStaff.Size = new System.Drawing.Size(43, 30);
            this.btnOffStaff.TabIndex = 22;
            this.btnOffStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffStaff.UseVisualStyleBackColor = true;
            this.btnOffStaff.Click += new System.EventHandler(this.btnOffStaff_Click);
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = global::Nuochoa.Properties.Resources.lose;
            this.btnHideForm.Location = new System.Drawing.Point(1279, 22);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 16);
            this.btnHideForm.TabIndex = 23;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(1302, 10);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 20);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // gbxInfoSalary
            // 
            this.gbxInfoSalary.Controls.Add(this.txtTotalSalayList);
            this.gbxInfoSalary.Controls.Add(this.label6);
            this.gbxInfoSalary.Controls.Add(this.txtTotalSalary);
            this.gbxInfoSalary.Controls.Add(this.label7);
            this.gbxInfoSalary.Controls.Add(this.btnClose);
            this.gbxInfoSalary.Controls.Add(this.btnDelete);
            this.gbxInfoSalary.Controls.Add(this.lblID);
            this.gbxInfoSalary.Controls.Add(this.btnUpdate);
            this.gbxInfoSalary.Controls.Add(this.btnSave);
            this.gbxInfoSalary.Controls.Add(this.txtBonus);
            this.gbxInfoSalary.Controls.Add(this.label5);
            this.gbxInfoSalary.Controls.Add(this.txtHours);
            this.gbxInfoSalary.Controls.Add(this.label4);
            this.gbxInfoSalary.Controls.Add(this.chkProbation);
            this.gbxInfoSalary.Controls.Add(this.txtStaffName);
            this.gbxInfoSalary.Controls.Add(this.cbxStaffCode);
            this.gbxInfoSalary.Controls.Add(this.label3);
            this.gbxInfoSalary.Controls.Add(this.label2);
            this.gbxInfoSalary.Location = new System.Drawing.Point(0, 72);
            this.gbxInfoSalary.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInfoSalary.Name = "gbxInfoSalary";
            this.gbxInfoSalary.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInfoSalary.Size = new System.Drawing.Size(1386, 349);
            this.gbxInfoSalary.TabIndex = 26;
            this.gbxInfoSalary.TabStop = false;
            this.gbxInfoSalary.Text = "Nhập thông tin";
            this.gbxInfoSalary.Enter += new System.EventHandler(this.gbxInfoSalary_Enter);
            // 
            // txtTotalSalayList
            // 
            this.txtTotalSalayList.Enabled = false;
            this.txtTotalSalayList.Location = new System.Drawing.Point(957, 219);
            this.txtTotalSalayList.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalayList.Name = "txtTotalSalayList";
            this.txtTotalSalayList.Size = new System.Drawing.Size(283, 22);
            this.txtTotalSalayList.TabIndex = 29;
            this.txtTotalSalayList.TextChanged += new System.EventHandler(this.txtTotalSalayList_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(642, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tổng lương phải thanh toán trong tháng:";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Location = new System.Drawing.Point(960, 140);
            this.txtTotalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(280, 22);
            this.txtTotalSalary.TabIndex = 14;
            this.txtTotalSalary.TextChanged += new System.EventHandler(this.txtTotalSalary_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(833, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng lương:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Image = global::Nuochoa.Properties.Resources.utilities_reset;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1106, 262);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "CLEAR";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = global::Nuochoa.Properties.Resources.xoa;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1001, 262);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Image = global::Nuochoa.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(866, 262);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 45);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::Nuochoa.Properties.Resources.addd;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(750, 262);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 45);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "THÊM";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(531, 143);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(239, 22);
            this.txtBonus.TabIndex = 8;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thưởng thêm:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(960, 64);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(280, 22);
            this.txtHours.TabIndex = 6;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(833, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ làm việc";
            // 
            // chkProbation
            // 
            this.chkProbation.AutoSize = true;
            this.chkProbation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProbation.ForeColor = System.Drawing.Color.Red;
            this.chkProbation.Location = new System.Drawing.Point(119, 145);
            this.chkProbation.Margin = new System.Windows.Forms.Padding(4);
            this.chkProbation.Name = "chkProbation";
            this.chkProbation.Size = new System.Drawing.Size(139, 22);
            this.chkProbation.TabIndex = 4;
            this.chkProbation.Text = "Lương thử việc";
            this.chkProbation.UseVisualStyleBackColor = true;
            this.chkProbation.CheckedChanged += new System.EventHandler(this.chkProbation_CheckedChanged);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Enabled = false;
            this.txtStaffName.Location = new System.Drawing.Point(531, 66);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(239, 22);
            this.txtStaffName.TabIndex = 3;
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // cbxStaffCode
            // 
            this.cbxStaffCode.FormattingEnabled = true;
            this.cbxStaffCode.Location = new System.Drawing.Point(119, 66);
            this.cbxStaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStaffCode.Name = "cbxStaffCode";
            this.cbxStaffCode.Size = new System.Drawing.Size(221, 24);
            this.cbxStaffCode.TabIndex = 2;
            this.cbxStaffCode.SelectedIndexChanged += new System.EventHandler(this.cbxStaffCode_SelectedIndexChanged);
            this.cbxStaffCode.SelectedValueChanged += new System.EventHandler(this.cbxStaffCode_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dgvwSalary);
            this.groupBox1.Location = new System.Drawing.Point(0, 406);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1386, 326);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lương";
            // 
            // dgvwSalary
            // 
            this.dgvwSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvwSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSalary.Location = new System.Drawing.Point(8, 23);
            this.dgvwSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwSalary.Name = "dgvwSalary";
            this.dgvwSalary.RowHeadersWidth = 62;
            this.dgvwSalary.Size = new System.Drawing.Size(1378, 299);
            this.dgvwSalary.TabIndex = 0;
            this.dgvwSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSalary_CellClick);
            this.dgvwSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSalary_CellContentClick);
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 745);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxInfoSalary);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxInfoSalary.ResumeLayout(false);
            this.gbxInfoSalary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOffStaff;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxInfoSalary;
        private System.Windows.Forms.ComboBox cbxStaffCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkProbation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvwSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSalayList;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}