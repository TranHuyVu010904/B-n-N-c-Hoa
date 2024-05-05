namespace Nuochoa
{
    partial class frmCustomer
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
            this.gbxIPIFCustomer = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.cbxSearchCus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.txtAddressCus = new System.Windows.Forms.TextBox();
            this.txtPhoneCus = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCustomerList = new System.Windows.Forms.GroupBox();
            this.dgvwCus = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffCustomer = new System.Windows.Forms.Button();
            this.gbxIPIFCustomer.SuspendLayout();
            this.gbxCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwCus)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIPIFCustomer
            // 
            this.gbxIPIFCustomer.Controls.Add(this.label9);
            this.gbxIPIFCustomer.Controls.Add(this.label22);
            this.gbxIPIFCustomer.Controls.Add(this.lblID);
            this.gbxIPIFCustomer.Controls.Add(this.cbb);
            this.gbxIPIFCustomer.Controls.Add(this.cbxSearchCus);
            this.gbxIPIFCustomer.Controls.Add(this.btnSearch);
            this.gbxIPIFCustomer.Controls.Add(this.txtSearch);
            this.gbxIPIFCustomer.Controls.Add(this.label8);
            this.gbxIPIFCustomer.Controls.Add(this.btnUpdate);
            this.gbxIPIFCustomer.Controls.Add(this.btnClose);
            this.gbxIPIFCustomer.Controls.Add(this.btnDelete);
            this.gbxIPIFCustomer.Controls.Add(this.btnSave);
            this.gbxIPIFCustomer.Controls.Add(this.dtpDOB);
            this.gbxIPIFCustomer.Controls.Add(this.cbxGender);
            this.gbxIPIFCustomer.Controls.Add(this.txtAddressCus);
            this.gbxIPIFCustomer.Controls.Add(this.txtPhoneCus);
            this.gbxIPIFCustomer.Controls.Add(this.txtCustomerName);
            this.gbxIPIFCustomer.Controls.Add(this.txtCustomerCode);
            this.gbxIPIFCustomer.Controls.Add(this.label7);
            this.gbxIPIFCustomer.Controls.Add(this.label6);
            this.gbxIPIFCustomer.Controls.Add(this.label5);
            this.gbxIPIFCustomer.Controls.Add(this.label4);
            this.gbxIPIFCustomer.Controls.Add(this.label3);
            this.gbxIPIFCustomer.Controls.Add(this.label2);
            this.gbxIPIFCustomer.Location = new System.Drawing.Point(0, 70);
            this.gbxIPIFCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIPIFCustomer.Name = "gbxIPIFCustomer";
            this.gbxIPIFCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIPIFCustomer.Size = new System.Drawing.Size(1358, 363);
            this.gbxIPIFCustomer.TabIndex = 3;
            this.gbxIPIFCustomer.TabStop = false;
            this.gbxIPIFCustomer.Text = "Nhập thông tin";
            this.gbxIPIFCustomer.Enter += new System.EventHandler(this.gbxIPIFCustomer_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Loại khách hàng:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1216, 19);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 18);
            this.label22.TabIndex = 18;
            this.label22.Text = "ID :";
            this.label22.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(1252, 19);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 18);
            this.lblID.TabIndex = 18;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "Vip",
            "Thường",
            "Đặc biệt"});
            this.cbb.Location = new System.Drawing.Point(244, 244);
            this.cbb.Margin = new System.Windows.Forms.Padding(4);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(340, 24);
            this.cbb.TabIndex = 20;
            this.cbb.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // cbxSearchCus
            // 
            this.cbxSearchCus.FormattingEnabled = true;
            this.cbxSearchCus.Location = new System.Drawing.Point(782, 239);
            this.cbxSearchCus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchCus.Name = "cbxSearchCus";
            this.cbxSearchCus.Size = new System.Drawing.Size(160, 24);
            this.cbxSearchCus.TabIndex = 17;
            this.cbxSearchCus.SelectedIndexChanged += new System.EventHandler(this.cbxSearchCus_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Nuochoa.Properties.Resources.kim;
            this.btnSearch.Location = new System.Drawing.Point(1255, 240);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(964, 240);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Nuochoa.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(917, 296);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 55);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Nuochoa.Properties.Resources.utilities_reset;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1045, 296);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 55);
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
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Nuochoa.Properties.Resources.xoa;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(792, 296);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 55);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Nuochoa.Properties.Resources.addd;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(652, 296);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 55);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "THÊM KH";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(900, 56);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(349, 22);
            this.dtpDOB.TabIndex = 9;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(244, 183);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(340, 24);
            this.cbxGender.TabIndex = 8;
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.cbxGender_SelectedIndexChanged);
            // 
            // txtAddressCus
            // 
            this.txtAddressCus.Location = new System.Drawing.Point(900, 178);
            this.txtAddressCus.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressCus.Name = "txtAddressCus";
            this.txtAddressCus.Size = new System.Drawing.Size(349, 22);
            this.txtAddressCus.TabIndex = 11;
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.Location = new System.Drawing.Point(900, 121);
            this.txtPhoneCus.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.Size = new System.Drawing.Size(349, 22);
            this.txtPhoneCus.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(244, 125);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(340, 22);
            this.txtCustomerName.TabIndex = 7;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(244, 60);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(340, 22);
            this.txtCustomerCode.TabIndex = 6;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(809, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sdt khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(789, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 182);
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
            this.label3.Location = new System.Drawing.Point(93, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbxCustomerList
            // 
            this.gbxCustomerList.Controls.Add(this.dgvwCus);
            this.gbxCustomerList.Location = new System.Drawing.Point(0, 429);
            this.gbxCustomerList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCustomerList.Name = "gbxCustomerList";
            this.gbxCustomerList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCustomerList.Size = new System.Drawing.Size(1426, 292);
            this.gbxCustomerList.TabIndex = 5;
            this.gbxCustomerList.TabStop = false;
            this.gbxCustomerList.Text = "Danh sách khách hàng";
            // 
            // dgvwCus
            // 
            this.dgvwCus.BackgroundColor = System.Drawing.Color.White;
            this.dgvwCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwCus.Location = new System.Drawing.Point(8, 23);
            this.dgvwCus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwCus.Name = "dgvwCus";
            this.dgvwCus.RowHeadersWidth = 62;
            this.dgvwCus.Size = new System.Drawing.Size(1379, 294);
            this.dgvwCus.TabIndex = 0;
            this.dgvwCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwCus_CellClick);
            this.dgvwCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwCus_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnHideForm);
            this.panel2.Controls.Add(this.btnOffCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1398, 62);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(532, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = global::Nuochoa.Properties.Resources.lose;
            this.btnHideForm.Location = new System.Drawing.Point(1315, 10);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 14);
            this.btnHideForm.TabIndex = 20;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnOffCustomer
            // 
            this.btnOffCustomer.BackColor = System.Drawing.Color.LightCyan;
            this.btnOffCustomer.BackgroundImage = global::Nuochoa.Properties.Resources.cv;
            this.btnOffCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOffCustomer.FlatAppearance.BorderSize = 0;
            this.btnOffCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffCustomer.ForeColor = System.Drawing.Color.White;
            this.btnOffCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffCustomer.Location = new System.Drawing.Point(1366, 0);
            this.btnOffCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffCustomer.Name = "btnOffCustomer";
            this.btnOffCustomer.Size = new System.Drawing.Size(43, 30);
            this.btnOffCustomer.TabIndex = 21;
            this.btnOffCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffCustomer.UseVisualStyleBackColor = false;
            this.btnOffCustomer.Click += new System.EventHandler(this.btnOffCustomer_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1398, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxCustomerList);
            this.Controls.Add(this.gbxIPIFCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.gbxIPIFCustomer.ResumeLayout(false);
            this.gbxIPIFCustomer.PerformLayout();
            this.gbxCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwCus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIPIFCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox txtAddressCus;
        private System.Windows.Forms.TextBox txtPhoneCus;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxCustomerList;
        private System.Windows.Forms.DataGridView dgvwCus;
        private System.Windows.Forms.Button btnOffCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSearchCus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnHideForm;
    }
}