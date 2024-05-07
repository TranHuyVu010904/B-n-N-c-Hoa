namespace Nuochoa
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.lblID = new System.Windows.Forms.Label();
            this.gbxIPIFStaff = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearchStaff = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.txtAddressStaff = new System.Windows.Forms.TextBox();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxStaffList = new System.Windows.Forms.GroupBox();
            this.dgvwStaff = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffStaff = new System.Windows.Forms.Button();
            this.gbxIPIFStaff.SuspendLayout();
            this.gbxStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwStaff)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1304, 37);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // gbxIPIFStaff
            // 
            this.gbxIPIFStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxIPIFStaff.Controls.Add(this.btnSearch);
            this.gbxIPIFStaff.Controls.Add(this.txtSearch);
            this.gbxIPIFStaff.Controls.Add(this.cbxSearchStaff);
            this.gbxIPIFStaff.Controls.Add(this.label8);
            this.gbxIPIFStaff.Controls.Add(this.lblID);
            this.gbxIPIFStaff.Controls.Add(this.btnUpdate);
            this.gbxIPIFStaff.Controls.Add(this.btnClose);
            this.gbxIPIFStaff.Controls.Add(this.btnDelete);
            this.gbxIPIFStaff.Controls.Add(this.btnSave);
            this.gbxIPIFStaff.Controls.Add(this.dtpDOB);
            this.gbxIPIFStaff.Controls.Add(this.cbxGender);
            this.gbxIPIFStaff.Controls.Add(this.txtAddressStaff);
            this.gbxIPIFStaff.Controls.Add(this.txtPhoneStaff);
            this.gbxIPIFStaff.Controls.Add(this.txtStaffName);
            this.gbxIPIFStaff.Controls.Add(this.txtStaffCode);
            this.gbxIPIFStaff.Controls.Add(this.label7);
            this.gbxIPIFStaff.Controls.Add(this.label6);
            this.gbxIPIFStaff.Controls.Add(this.label5);
            this.gbxIPIFStaff.Controls.Add(this.label4);
            this.gbxIPIFStaff.Controls.Add(this.label3);
            this.gbxIPIFStaff.Controls.Add(this.label2);
            this.gbxIPIFStaff.Location = new System.Drawing.Point(4, 72);
            this.gbxIPIFStaff.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIPIFStaff.Name = "gbxIPIFStaff";
            this.gbxIPIFStaff.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIPIFStaff.Size = new System.Drawing.Size(1422, 298);
            this.gbxIPIFStaff.TabIndex = 2;
            this.gbxIPIFStaff.TabStop = false;
            this.gbxIPIFStaff.Text = "Nhập thông tin";
            this.gbxIPIFStaff.Enter += new System.EventHandler(this.gbxIPIFStaff_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1300, 193);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1009, 193);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 22);
            this.txtSearch.TabIndex = 18;
            // 
            // cbxSearchStaff
            // 
            this.cbxSearchStaff.FormattingEnabled = true;
            this.cbxSearchStaff.Location = new System.Drawing.Point(827, 192);
            this.cbxSearchStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchStaff.Name = "cbxSearchStaff";
            this.cbxSearchStaff.Size = new System.Drawing.Size(160, 24);
            this.cbxSearchStaff.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(722, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tìm kiếm:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Nuochoa.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1070, 251);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Nuochoa.Properties.Resources.utilities_reset;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1220, 251);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 45);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLEAR";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Nuochoa.Properties.Resources.xoa;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(890, 251);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "XÓA NHÂN VIÊN";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Nuochoa.Properties.Resources.addd;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(706, 251);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "THÊM NHÂN VIÊN";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(251, 265);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(349, 22);
            this.dtpDOB.TabIndex = 9;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(251, 204);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(349, 24);
            this.cbxGender.TabIndex = 8;
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.cbxGender_SelectedIndexChanged);
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.Location = new System.Drawing.Point(915, 136);
            this.txtAddressStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.Size = new System.Drawing.Size(349, 22);
            this.txtAddressStaff.TabIndex = 11;
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Location = new System.Drawing.Point(915, 64);
            this.txtPhoneStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(349, 22);
            this.txtPhoneStaff.TabIndex = 10;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(251, 146);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(349, 22);
            this.txtStaffName.TabIndex = 7;
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Location = new System.Drawing.Point(251, 88);
            this.txtStaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(349, 22);
            this.txtStaffCode.TabIndex = 6;
            this.txtStaffCode.TextChanged += new System.EventHandler(this.txtStaffCode_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(766, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sdt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // gbxStaffList
            // 
            this.gbxStaffList.Controls.Add(this.dgvwStaff);
            this.gbxStaffList.Location = new System.Drawing.Point(0, 378);
            this.gbxStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxStaffList.Name = "gbxStaffList";
            this.gbxStaffList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxStaffList.Size = new System.Drawing.Size(1426, 301);
            this.gbxStaffList.TabIndex = 3;
            this.gbxStaffList.TabStop = false;
            this.gbxStaffList.Text = "Danh sách nhân viên";
            // 
            // dgvwStaff
            // 
            this.dgvwStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvwStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwStaff.Location = new System.Drawing.Point(0, 16);
            this.dgvwStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwStaff.Name = "dgvwStaff";
            this.dgvwStaff.RowHeadersWidth = 62;
            this.dgvwStaff.Size = new System.Drawing.Size(1426, 277);
            this.dgvwStaff.TabIndex = 0;
            this.dgvwStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwStaff_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnHideForm);
            this.panel2.Controls.Add(this.btnOffStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 64);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label10.Location = new System.Drawing.Point(528, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(367, 38);
            this.label10.TabIndex = 34;
            this.label10.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = global::Nuochoa.Properties.Resources.lose;
            this.btnHideForm.Location = new System.Drawing.Point(1321, 31);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 10);
            this.btnHideForm.TabIndex = 20;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnOffStaff
            // 
            this.btnOffStaff.BackgroundImage = global::Nuochoa.Properties.Resources.cv;
            this.btnOffStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOffStaff.FlatAppearance.BorderSize = 0;
            this.btnOffStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffStaff.ForeColor = System.Drawing.Color.White;
            this.btnOffStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffStaff.Location = new System.Drawing.Point(1370, 13);
            this.btnOffStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffStaff.Name = "btnOffStaff";
            this.btnOffStaff.Size = new System.Drawing.Size(43, 34);
            this.btnOffStaff.TabIndex = 21;
            this.btnOffStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffStaff.UseVisualStyleBackColor = true;
            this.btnOffStaff.Click += new System.EventHandler(this.btnOffStaff_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1426, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxStaffList);
            this.Controls.Add(this.gbxIPIFStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.gbxIPIFStaff.ResumeLayout(false);
            this.gbxIPIFStaff.PerformLayout();
            this.gbxStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwStaff)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxIPIFStaff;
        private System.Windows.Forms.GroupBox gbxStaffList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox txtAddressStaff;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvwStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOffStaff;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSearchStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
    }
}