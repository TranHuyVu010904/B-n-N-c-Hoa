namespace Nuochoa
{
    partial class frmBill
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
            this.gbxGenInfo = new System.Windows.Forms.GroupBox();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cbxCustomerCode = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cbxStaffCode = new System.Windows.Forms.ComboBox();
            this.dtpDOS = new System.Windows.Forms.DateTimePicker();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProInfo = new System.Windows.Forms.GroupBox();
            this.dgvwBillDetails = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIntoMoney = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbxProductCode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOffBill = new System.Windows.Forms.Button();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbxSearchBillCode = new System.Windows.Forms.ComboBox();
            this.gbxGenInfo.SuspendLayout();
            this.gbxProInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBillDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGenInfo
            // 
            this.gbxGenInfo.Controls.Add(this.txtPhoneCustomer);
            this.gbxGenInfo.Controls.Add(this.txtAddressCustomer);
            this.gbxGenInfo.Controls.Add(this.txtCustomerName);
            this.gbxGenInfo.Controls.Add(this.cbxCustomerCode);
            this.gbxGenInfo.Controls.Add(this.txtStaffName);
            this.gbxGenInfo.Controls.Add(this.cbxStaffCode);
            this.gbxGenInfo.Controls.Add(this.dtpDOS);
            this.gbxGenInfo.Controls.Add(this.txtBillCode);
            this.gbxGenInfo.Controls.Add(this.label9);
            this.gbxGenInfo.Controls.Add(this.label8);
            this.gbxGenInfo.Controls.Add(this.label7);
            this.gbxGenInfo.Controls.Add(this.label6);
            this.gbxGenInfo.Controls.Add(this.label5);
            this.gbxGenInfo.Controls.Add(this.label4);
            this.gbxGenInfo.Controls.Add(this.label3);
            this.gbxGenInfo.Controls.Add(this.label2);
            this.gbxGenInfo.Location = new System.Drawing.Point(10, 52);
            this.gbxGenInfo.Name = "gbxGenInfo";
            this.gbxGenInfo.Size = new System.Drawing.Size(475, 378);
            this.gbxGenInfo.TabIndex = 0;
            this.gbxGenInfo.TabStop = false;
            this.gbxGenInfo.Text = "Tổng quan thông tin";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Enabled = false;
            this.txtPhoneCustomer.Location = new System.Drawing.Point(159, 346);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(286, 20);
            this.txtPhoneCustomer.TabIndex = 15;
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Enabled = false;
            this.txtAddressCustomer.Location = new System.Drawing.Point(159, 301);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(286, 20);
            this.txtAddressCustomer.TabIndex = 14;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(159, 252);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(286, 20);
            this.txtCustomerName.TabIndex = 13;
            // 
            // cbxCustomerCode
            // 
            this.cbxCustomerCode.FormattingEnabled = true;
            this.cbxCustomerCode.Location = new System.Drawing.Point(159, 215);
            this.cbxCustomerCode.Name = "cbxCustomerCode";
            this.cbxCustomerCode.Size = new System.Drawing.Size(286, 21);
            this.cbxCustomerCode.TabIndex = 12;
            this.cbxCustomerCode.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerCode_SelectedIndexChanged);
            this.cbxCustomerCode.SelectedValueChanged += new System.EventHandler(this.cbxCustomerCode_SelectedValueChanged);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Enabled = false;
            this.txtStaffName.Location = new System.Drawing.Point(159, 174);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(286, 20);
            this.txtStaffName.TabIndex = 11;
            // 
            // cbxStaffCode
            // 
            this.cbxStaffCode.FormattingEnabled = true;
            this.cbxStaffCode.Location = new System.Drawing.Point(159, 125);
            this.cbxStaffCode.Name = "cbxStaffCode";
            this.cbxStaffCode.Size = new System.Drawing.Size(286, 21);
            this.cbxStaffCode.TabIndex = 10;
            this.cbxStaffCode.SelectedIndexChanged += new System.EventHandler(this.cbxStaffCode_SelectedIndexChanged);
            this.cbxStaffCode.SelectedValueChanged += new System.EventHandler(this.cbxStaffCode_SelectedValueChanged);
            // 
            // dtpDOS
            // 
            this.dtpDOS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOS.Location = new System.Drawing.Point(159, 73);
            this.dtpDOS.Name = "dtpDOS";
            this.dtpDOS.Size = new System.Drawing.Size(286, 20);
            this.dtpDOS.TabIndex = 9;
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(159, 28);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(286, 20);
            this.txtBillCode.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "SDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Địa chỉ nhận:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã code:";
            // 
            // gbxProInfo
            // 
            this.gbxProInfo.Controls.Add(this.dgvwBillDetails);
            this.gbxProInfo.Location = new System.Drawing.Point(10, 434);
            this.gbxProInfo.Name = "gbxProInfo";
            this.gbxProInfo.Size = new System.Drawing.Size(1057, 214);
            this.gbxProInfo.TabIndex = 1;
            this.gbxProInfo.TabStop = false;
            this.gbxProInfo.Text = "Thông tin sản phẩm";
            // 
            // dgvwBillDetails
            // 
            this.dgvwBillDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvwBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwBillDetails.Location = new System.Drawing.Point(2, 19);
            this.dgvwBillDetails.Name = "dgvwBillDetails";
            this.dgvwBillDetails.RowHeadersWidth = 62;
            this.dgvwBillDetails.Size = new System.Drawing.Size(1048, 191);
            this.dgvwBillDetails.TabIndex = 17;
            this.dgvwBillDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwBillDetails_CellClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(940, 91);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(113, 20);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(862, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Doanh thu:";
            // 
            // txtIntoMoney
            // 
            this.txtIntoMoney.Enabled = false;
            this.txtIntoMoney.Location = new System.Drawing.Point(613, 330);
            this.txtIntoMoney.Name = "txtIntoMoney";
            this.txtIntoMoney.Size = new System.Drawing.Size(216, 20);
            this.txtIntoMoney.TabIndex = 16;
            this.txtIntoMoney.TextChanged += new System.EventHandler(this.txtIntoMoney_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(613, 277);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(217, 20);
            this.txtUnitPrice.TabIndex = 15;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(611, 178);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(218, 20);
            this.txtDiscount.TabIndex = 14;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(611, 229);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(218, 20);
            this.txtProductName.TabIndex = 13;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(613, 124);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 20);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // cbxProductCode
            // 
            this.cbxProductCode.FormattingEnabled = true;
            this.cbxProductCode.Location = new System.Drawing.Point(612, 74);
            this.cbxProductCode.Name = "cbxProductCode";
            this.cbxProductCode.Size = new System.Drawing.Size(217, 21);
            this.cbxProductCode.TabIndex = 11;
            this.cbxProductCode.SelectedValueChanged += new System.EventHandler(this.cbxProductCode_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(522, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(533, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Giá bán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(516, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Giảm giá%:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(501, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(530, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(505, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOffBill);
            this.panel2.Controls.Add(this.btnHideForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 50);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(428, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnOffBill
            // 
            this.btnOffBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOffBill.BackgroundImage = global::Nuochoa.Properties.Resources.cv;
            this.btnOffBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOffBill.FlatAppearance.BorderSize = 0;
            this.btnOffBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffBill.ForeColor = System.Drawing.Color.White;
            this.btnOffBill.Location = new System.Drawing.Point(1034, 9);
            this.btnOffBill.Name = "btnOffBill";
            this.btnOffBill.Size = new System.Drawing.Size(32, 28);
            this.btnOffBill.TabIndex = 15;
            this.btnOffBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffBill.UseVisualStyleBackColor = false;
            this.btnOffBill.Click += new System.EventHandler(this.btnOffBill_Click);
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = global::Nuochoa.Properties.Resources.lose;
            this.btnHideForm.Location = new System.Drawing.Point(990, 19);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(32, 12);
            this.btnHideForm.TabIndex = 21;
            this.btnHideForm.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(988, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click_1);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddBill.Image = global::Nuochoa.Properties.Resources.addd;
            this.btnAddBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBill.Location = new System.Drawing.Point(498, 405);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(111, 32);
            this.btnAddBill.TabIndex = 30;
            this.btnAddBill.Text = "TẠO BILL";
            this.btnAddBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Nuochoa.Properties.Resources.kim;
            this.btnSearch.Location = new System.Drawing.Point(902, 356);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 35);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Image = global::Nuochoa.Properties.Resources.xoa;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(880, 405);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(136, 32);
            this.btnDeleteProduct.TabIndex = 27;
            this.btnDeleteProduct.Text = "XÓA BILL";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBill.Image = global::Nuochoa.Properties.Resources.utilities_reset;
            this.btnCancelBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelBill.Location = new System.Drawing.Point(754, 405);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(128, 32);
            this.btnCancelBill.TabIndex = 26;
            this.btnCancelBill.Text = "CANCEL BILL";
            this.btnCancelBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelBill.UseVisualStyleBackColor = false;
            this.btnCancelBill.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddProduct.Image = global::Nuochoa.Properties.Resources.addd;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(610, 405);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(147, 32);
            this.btnAddProduct.TabIndex = 24;
            this.btnAddProduct.Text = "THÊM BILL";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbxSearchBillCode
            // 
            this.cbxSearchBillCode.FormattingEnabled = true;
            this.cbxSearchBillCode.Location = new System.Drawing.Point(512, 370);
            this.cbxSearchBillCode.Name = "cbxSearchBillCode";
            this.cbxSearchBillCode.Size = new System.Drawing.Size(384, 21);
            this.cbxSearchBillCode.TabIndex = 22;
            this.cbxSearchBillCode.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBillCode_SelectedIndexChanged);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1070, 654);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.cbxSearchBillCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnCancelBill);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxProInfo);
            this.Controls.Add(this.gbxGenInfo);
            this.Controls.Add(this.txtIntoMoney);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxProductCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.gbxGenInfo.ResumeLayout(false);
            this.gbxGenInfo.PerformLayout();
            this.gbxProInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBillDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGenInfo;
        private System.Windows.Forms.GroupBox gbxProInfo;
        private System.Windows.Forms.Button btnOffBill;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cbxCustomerCode;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.ComboBox cbxStaffCode;
        private System.Windows.Forms.DateTimePicker dtpDOS;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvwBillDetails;
        private System.Windows.Forms.TextBox txtIntoMoney;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbxProductCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbxSearchBillCode;
    }
}