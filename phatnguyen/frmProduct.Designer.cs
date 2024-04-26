namespace Nuochoa
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxIPIFProduct = new System.Windows.Forms.GroupBox();
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProductTypee = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearchProduct = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProductList = new System.Windows.Forms.GroupBox();
            this.dgvwProduct = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOffPRO = new System.Windows.Forms.Button();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gbxIPIFProduct.SuspendLayout();
            this.gbxProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnOffPRO);
            this.panel2.Controls.Add(this.btnHideForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 87);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(560, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(348, 44);
            this.label10.TabIndex = 33;
            this.label10.Text = "NHẬP HÀNG HÓA";
            // 
            // gbxIPIFProduct
            // 
            this.gbxIPIFProduct.AutoSize = true;
            this.gbxIPIFProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxIPIFProduct.Controls.Add(this.ckb1);
            this.gbxIPIFProduct.Controls.Add(this.ckb2);
            this.gbxIPIFProduct.Controls.Add(this.label1);
            this.gbxIPIFProduct.Controls.Add(this.cbxProductTypee);
            this.gbxIPIFProduct.Controls.Add(this.lblID);
            this.gbxIPIFProduct.Controls.Add(this.btnSearch);
            this.gbxIPIFProduct.Controls.Add(this.txtSearch);
            this.gbxIPIFProduct.Controls.Add(this.cbxSearchProduct);
            this.gbxIPIFProduct.Controls.Add(this.label9);
            this.gbxIPIFProduct.Controls.Add(this.txtAmount);
            this.gbxIPIFProduct.Controls.Add(this.txtPrice);
            this.gbxIPIFProduct.Controls.Add(this.label8);
            this.gbxIPIFProduct.Controls.Add(this.cbxColor);
            this.gbxIPIFProduct.Controls.Add(this.btnUpdate);
            this.gbxIPIFProduct.Controls.Add(this.btnClose);
            this.gbxIPIFProduct.Controls.Add(this.btnDelete);
            this.gbxIPIFProduct.Controls.Add(this.btnSave);
            this.gbxIPIFProduct.Controls.Add(this.cbxSize);
            this.gbxIPIFProduct.Controls.Add(this.txtProductName);
            this.gbxIPIFProduct.Controls.Add(this.txtProductCode);
            this.gbxIPIFProduct.Controls.Add(this.label7);
            this.gbxIPIFProduct.Controls.Add(this.label6);
            this.gbxIPIFProduct.Controls.Add(this.label5);
            this.gbxIPIFProduct.Controls.Add(this.label4);
            this.gbxIPIFProduct.Controls.Add(this.label3);
            this.gbxIPIFProduct.Controls.Add(this.label2);
            this.gbxIPIFProduct.Location = new System.Drawing.Point(0, 70);
            this.gbxIPIFProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIPIFProduct.Name = "gbxIPIFProduct";
            this.gbxIPIFProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIPIFProduct.Size = new System.Drawing.Size(1426, 437);
            this.gbxIPIFProduct.TabIndex = 10;
            this.gbxIPIFProduct.TabStop = false;
            this.gbxIPIFProduct.Text = "Nhập thông tin";
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb1.ForeColor = System.Drawing.Color.Red;
            this.ckb1.Location = new System.Drawing.Point(225, 357);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(52, 22);
            this.ckb1.TabIndex = 27;
            this.ckb1.Text = "Có";
            this.ckb1.UseVisualStyleBackColor = true;
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb2.ForeColor = System.Drawing.Color.Red;
            this.ckb2.Location = new System.Drawing.Point(308, 357);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(78, 22);
            this.ckb2.TabIndex = 26;
            this.ckb2.Text = "Không";
            this.ckb2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hàng nhập khẩu:";
            // 
            // cbxProductTypee
            // 
            this.cbxProductTypee.FormattingEnabled = true;
            this.cbxProductTypee.Location = new System.Drawing.Point(900, 96);
            this.cbxProductTypee.Name = "cbxProductTypee";
            this.cbxProductTypee.Size = new System.Drawing.Size(349, 24);
            this.cbxProductTypee.TabIndex = 24;
            this.cbxProductTypee.SelectedIndexChanged += new System.EventHandler(this.cbxProductTypee_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(1272, 38);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 20);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1017, 313);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbxSearchProduct
            // 
            this.cbxSearchProduct.FormattingEnabled = true;
            this.cbxSearchProduct.Location = new System.Drawing.Point(835, 312);
            this.cbxSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchProduct.Name = "cbxSearchProduct";
            this.cbxSearchProduct.Size = new System.Drawing.Size(160, 24);
            this.cbxSearchProduct.TabIndex = 17;
            this.cbxSearchProduct.SelectedIndexChanged += new System.EventHandler(this.cbxSearchProduct_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(769, 317);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Search:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(900, 171);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(349, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(900, 241);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(349, 22);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(770, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá bán:";
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(225, 284);
            this.cbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(349, 24);
            this.cbxColor.TabIndex = 9;
            // 
            // cbxSize
            // 
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(225, 224);
            this.cbxSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(349, 24);
            this.cbxSize.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(225, 157);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(349, 22);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(225, 96);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(349, 22);
            this.txtProductCode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(692, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thương hiệu/ Kiểu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(761, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Màu sắc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Nước Hoa/ Chiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID sản phẩm:";
            // 
            // gbxProductList
            // 
            this.gbxProductList.AutoSize = true;
            this.gbxProductList.BackColor = System.Drawing.Color.BurlyWood;
            this.gbxProductList.Controls.Add(this.dgvwProduct);
            this.gbxProductList.Location = new System.Drawing.Point(0, 477);
            this.gbxProductList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProductList.Name = "gbxProductList";
            this.gbxProductList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProductList.Size = new System.Drawing.Size(1434, 442);
            this.gbxProductList.TabIndex = 11;
            this.gbxProductList.TabStop = false;
            this.gbxProductList.Text = "Danh sách sản phẩm";
            // 
            // dgvwProduct
            // 
            this.dgvwProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwProduct.Location = new System.Drawing.Point(0, 26);
            this.dgvwProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwProduct.Name = "dgvwProduct";
            this.dgvwProduct.RowHeadersWidth = 62;
            this.dgvwProduct.Size = new System.Drawing.Size(1426, 393);
            this.dgvwProduct.TabIndex = 0;
            this.dgvwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwProduct_CellClick);
            this.dgvwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwProduct_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1303, 312);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Nuochoa.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1017, 359);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "CẬP NHẬT";
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
            this.btnClose.Location = new System.Drawing.Point(1166, 359);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 45);
            this.btnClose.TabIndex = 16;
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
            this.btnDelete.Location = new System.Drawing.Point(837, 359);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "XÓA SẢN PHẨM";
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
            this.btnSave.Location = new System.Drawing.Point(642, 359);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 45);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "THÊM SẢN PHẨM";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOffPRO
            // 
            this.btnOffPRO.BackgroundImage = global::Nuochoa.Properties.Resources.cv;
            this.btnOffPRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOffPRO.FlatAppearance.BorderSize = 0;
            this.btnOffPRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffPRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffPRO.ForeColor = System.Drawing.Color.White;
            this.btnOffPRO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffPRO.Location = new System.Drawing.Point(1370, 13);
            this.btnOffPRO.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffPRO.Name = "btnOffPRO";
            this.btnOffPRO.Size = new System.Drawing.Size(43, 30);
            this.btnOffPRO.TabIndex = 21;
            this.btnOffPRO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffPRO.UseVisualStyleBackColor = true;
            this.btnOffPRO.Click += new System.EventHandler(this.btnOffPRO_Click);
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = global::Nuochoa.Properties.Resources.lose;
            this.btnHideForm.Location = new System.Drawing.Point(1319, 21);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 11);
            this.btnHideForm.TabIndex = 20;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1426, 790);
            this.Controls.Add(this.gbxProductList);
            this.Controls.Add(this.gbxIPIFProduct);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxIPIFProduct.ResumeLayout(false);
            this.gbxIPIFProduct.PerformLayout();
            this.gbxProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOffPRO;
        private System.Windows.Forms.GroupBox gbxIPIFProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxProductList;
        private System.Windows.Forms.DataGridView dgvwProduct;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxSearchProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxProductTypee;
        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}