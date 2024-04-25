namespace Quanlycafenew
{
    partial class frmXuathoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuathoadon));
            this.label2 = new System.Windows.Forms.Label();
            this.cbSurcharge = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowExchange = new System.Windows.Forms.Button();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnBacklogin = new System.Windows.Forms.Button();
            this.btnDoanhthu = new System.Windows.Forms.Button();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbOrder = new System.Windows.Forms.PictureBox();
            this.pbThunho = new System.Windows.Forms.PictureBox();
            this.pbDong = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnShowBill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThunho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 15;
            // 
            // cbSurcharge
            // 
            this.cbSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSurcharge.FormattingEnabled = true;
            this.cbSurcharge.Location = new System.Drawing.Point(446, 261);
            this.cbSurcharge.Name = "cbSurcharge";
            this.cbSurcharge.Size = new System.Drawing.Size(264, 33);
            this.cbSurcharge.TabIndex = 58;
            this.cbSurcharge.SelectedIndexChanged += new System.EventHandler(this.cbSurcharge_SelectedIndexChanged);
            this.cbSurcharge.SelectionChangeCommitted += new System.EventHandler(this.cbSurcharge_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(290, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 29);
            this.label10.TabIndex = 57;
            this.label10.Text = "Phụ thu:";
            // 
            // btnShowExchange
            // 
            this.btnShowExchange.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowExchange.FlatAppearance.BorderSize = 0;
            this.btnShowExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowExchange.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowExchange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowExchange.Location = new System.Drawing.Point(295, 379);
            this.btnShowExchange.Name = "btnShowExchange";
            this.btnShowExchange.Size = new System.Drawing.Size(279, 96);
            this.btnShowExchange.TabIndex = 50;
            this.btnShowExchange.Text = " Tính Số Dư Trả Lại";
            this.btnShowExchange.UseVisualStyleBackColor = false;
            this.btnShowExchange.Click += new System.EventHandler(this.btnShowExchange_Click);
            // 
            // cbStaff
            // 
            this.cbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(1003, 141);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(264, 33);
            this.cbStaff.TabIndex = 49;
            // 
            // dtpDay
            // 
            this.dtpDay.CustomFormat = "dd/MM/yyyy";
            this.dtpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDay.Location = new System.Drawing.Point(446, 207);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(264, 30);
            this.dtpDay.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(290, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(850, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nhân viên:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIDBill
            // 
            this.txtIDBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBill.Location = new System.Drawing.Point(446, 140);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.Size = new System.Drawing.Size(264, 30);
            this.txtIDBill.TabIndex = 24;
            this.txtIDBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDBill_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(290, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID hóa đơn";
            // 
            // txtExchange
            // 
            this.txtExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExchange.Location = new System.Drawing.Point(997, 207);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(264, 30);
            this.txtExchange.TabIndex = 12;
            this.txtExchange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExchange_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(850, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiền thừa";
            // 
            // txtGive
            // 
            this.txtGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGive.Location = new System.Drawing.Point(997, 260);
            this.txtGive.Name = "txtGive";
            this.txtGive.Size = new System.Drawing.Size(264, 30);
            this.txtGive.TabIndex = 10;
            this.txtGive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGive_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(853, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Khách trả";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(446, 328);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(264, 30);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(290, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(649, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 73);
            this.label1.TabIndex = 83;
            this.label1.Text = "Windows Coffee";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.SteelBlue;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(266, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1132, 75);
            this.listView2.TabIndex = 82;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnBacklogin
            // 
            this.btnBacklogin.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBacklogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBacklogin.FlatAppearance.BorderSize = 0;
            this.btnBacklogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnBacklogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnBacklogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacklogin.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacklogin.ForeColor = System.Drawing.Color.Black;
            this.btnBacklogin.Location = new System.Drawing.Point(3, 510);
            this.btnBacklogin.Name = "btnBacklogin";
            this.btnBacklogin.Size = new System.Drawing.Size(249, 59);
            this.btnBacklogin.TabIndex = 79;
            this.btnBacklogin.Text = "CT Khuyến Mãi";
            this.btnBacklogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBacklogin.UseVisualStyleBackColor = false;
            this.btnBacklogin.Click += new System.EventHandler(this.btnBacklogin_Click);
            // 
            // btnDoanhthu
            // 
            this.btnDoanhthu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDoanhthu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoanhthu.FlatAppearance.BorderSize = 0;
            this.btnDoanhthu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnDoanhthu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnDoanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhthu.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhthu.ForeColor = System.Drawing.Color.Black;
            this.btnDoanhthu.Location = new System.Drawing.Point(-11, 443);
            this.btnDoanhthu.Name = "btnDoanhthu";
            this.btnDoanhthu.Size = new System.Drawing.Size(263, 61);
            this.btnDoanhthu.TabIndex = 76;
            this.btnDoanhthu.Text = "  Doanh Thu";
            this.btnDoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhthu.UseVisualStyleBackColor = false;
            this.btnDoanhthu.Click += new System.EventHandler(this.btnDoanhthu_Click);
            // 
            // btnSanpham
            // 
            this.btnSanpham.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSanpham.FlatAppearance.BorderSize = 0;
            this.btnSanpham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnSanpham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnSanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanpham.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.ForeColor = System.Drawing.Color.Black;
            this.btnSanpham.Location = new System.Drawing.Point(-11, 372);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(263, 65);
            this.btnSanpham.TabIndex = 75;
            this.btnSanpham.Text = "  Quản Lý Sản Phẩm";
            this.btnSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanpham.UseVisualStyleBackColor = false;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnNhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanvien.Location = new System.Drawing.Point(-11, 300);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(263, 66);
            this.btnNhanvien.TabIndex = 73;
            this.btnNhanvien.Text = "   Quản Lý Nhân Viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.GhostWhite;
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnKhachhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachhang.Location = new System.Drawing.Point(-11, 229);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(263, 65);
            this.btnKhachhang.TabIndex = 74;
            this.btnKhachhang.Text = "  Quản Lý Khách Hàng";
            this.btnKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.UseVisualStyleBackColor = false;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-11, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(271, 784);
            this.listView1.TabIndex = 80;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(266, 490);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1132, 303);
            this.dgvOrder.TabIndex = 2;
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder.Location = new System.Drawing.Point(783, 328);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(384, 38);
            this.txtOrder.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 66);
            this.button1.TabIndex = 84;
            this.button1.Text = " Báo Cáo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbOrder
            // 
            this.pbOrder.Image = global::Quanlycafenew.Properties.Resources.iconTimKiem;
            this.pbOrder.Location = new System.Drawing.Point(1188, 328);
            this.pbOrder.Name = "pbOrder";
            this.pbOrder.Size = new System.Drawing.Size(40, 38);
            this.pbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrder.TabIndex = 14;
            this.pbOrder.TabStop = false;
            // 
            // pbThunho
            // 
            this.pbThunho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbThunho.BackColor = System.Drawing.Color.Transparent;
            this.pbThunho.Image = ((System.Drawing.Image)(resources.GetObject("pbThunho.Image")));
            this.pbThunho.Location = new System.Drawing.Point(1316, -19);
            this.pbThunho.Name = "pbThunho";
            this.pbThunho.Size = new System.Drawing.Size(48, 68);
            this.pbThunho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThunho.TabIndex = 81;
            this.pbThunho.TabStop = false;
            this.pbThunho.Click += new System.EventHandler(this.pbThunho_Click);
            // 
            // pbDong
            // 
            this.pbDong.BackColor = System.Drawing.Color.Transparent;
            this.pbDong.Image = global::Quanlycafenew.Properties.Resources.iconHuy;
            this.pbDong.Location = new System.Drawing.Point(1370, 0);
            this.pbDong.Name = "pbDong";
            this.pbDong.Size = new System.Drawing.Size(37, 29);
            this.pbDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDong.TabIndex = 77;
            this.pbDong.TabStop = false;
            this.pbDong.Click += new System.EventHandler(this.pbDong_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.pbLogo.ErrorImage = null;
            this.pbLogo.Image = global::Quanlycafenew.Properties.Resources.as__2_;
            this.pbLogo.Location = new System.Drawing.Point(3, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(249, 211);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 78;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnShowBill
            // 
            this.btnShowBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.btnShowBill.BackgroundImage = global::Quanlycafenew.Properties.Resources.hh;
            this.btnShowBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowBill.FlatAppearance.BorderSize = 0;
            this.btnShowBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBill.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBill.Location = new System.Drawing.Point(601, 379);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(97, 96);
            this.btnShowBill.TabIndex = 13;
            this.btnShowBill.UseVisualStyleBackColor = false;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 66);
            this.button2.TabIndex = 85;
            this.button2.Text = "Thống Kê Cửa hàng";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 719);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 66);
            this.button3.TabIndex = 86;
            this.button3.Text = "Doanh Thu Trong Tháng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frmXuathoadon
            // 
            this.AcceptButton = this.btnShowExchange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1410, 800);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbOrder);
            this.Controls.Add(this.cbSurcharge);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbThunho);
            this.Controls.Add(this.btnShowExchange);
            this.Controls.Add(this.btnBacklogin);
            this.Controls.Add(this.pbDong);
            this.Controls.Add(this.cbStaff);
            this.Controls.Add(this.btnDoanhthu);
            this.Controls.Add(this.txtIDBill);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.btnSanpham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKhachhang);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShowBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuathoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsCoffee";
            this.Load += new System.EventHandler(this.frmXuathoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThunho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSurcharge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShowExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.PictureBox pbThunho;
        private System.Windows.Forms.Button btnBacklogin;
        private System.Windows.Forms.PictureBox pbDong;
        private System.Windows.Forms.Button btnDoanhthu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.PictureBox pbOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}