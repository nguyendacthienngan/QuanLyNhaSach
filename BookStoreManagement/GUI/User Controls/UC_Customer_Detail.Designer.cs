namespace GUI.User_Controls
{
    partial class UC_Customer_Detail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer_Detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnInput = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtId = new Bunifu.Framework.BunifuCustomTextbox();
            this.ddGender = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtFirstName = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtPhone = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtLastName = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtAddress = new Bunifu.Framework.BunifuCustomTextbox();
            this.txtEmail = new Bunifu.Framework.BunifuCustomTextbox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvCustomerDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetail)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.76316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.23684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.46743F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.532567F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 438F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Controls.Add(this.pnInput, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvCustomerDetail, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1008, 477);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pnInput
            // 
            this.pnInput.BackColor = System.Drawing.Color.White;
            this.pnInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInput.BackgroundImage")));
            this.pnInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInput.Controls.Add(this.txtId);
            this.pnInput.Controls.Add(this.ddGender);
            this.pnInput.Controls.Add(this.txtFirstName);
            this.pnInput.Controls.Add(this.txtPhone);
            this.pnInput.Controls.Add(this.txtLastName);
            this.pnInput.Controls.Add(this.txtAddress);
            this.pnInput.Controls.Add(this.txtEmail);
            this.pnInput.Controls.Add(this.btnDelete);
            this.pnInput.Controls.Add(this.btnCancel);
            this.pnInput.Controls.Add(this.btnSave);
            this.pnInput.Controls.Add(this.btnAdd);
            this.pnInput.Controls.Add(this.bunifuLabel6);
            this.pnInput.Controls.Add(this.bunifuLabel5);
            this.pnInput.Controls.Add(this.bunifuLabel4);
            this.pnInput.Controls.Add(this.bunifuLabel3);
            this.pnInput.Controls.Add(this.bunifuLabel2);
            this.pnInput.Controls.Add(this.bunifuLabel1);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInput.ForeColor = System.Drawing.Color.Black;
            this.pnInput.GradientBottomLeft = System.Drawing.Color.White;
            this.pnInput.GradientBottomRight = System.Drawing.Color.White;
            this.pnInput.GradientTopLeft = System.Drawing.Color.White;
            this.pnInput.GradientTopRight = System.Drawing.Color.White;
            this.pnInput.Location = new System.Drawing.Point(2, 2);
            this.pnInput.Margin = new System.Windows.Forms.Padding(2);
            this.pnInput.Name = "pnInput";
            this.pnInput.Quality = 10;
            this.pnInput.Size = new System.Drawing.Size(499, 464);
            this.pnInput.TabIndex = 21;
            this.pnInput.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtId.Location = new System.Drawing.Point(147, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 31);
            this.txtId.TabIndex = 52;
            this.txtId.Visible = false;
            // 
            // ddGender
            // 
            this.ddGender.BackColor = System.Drawing.Color.White;
            this.ddGender.BorderRadius = 1;
            this.ddGender.Color = System.Drawing.Color.Black;
            this.ddGender.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddGender.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddGender.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddGender.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddGender.FillDropDown = false;
            this.ddGender.FillIndicator = false;
            this.ddGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddGender.ForeColor = System.Drawing.Color.White;
            this.ddGender.FormattingEnabled = true;
            this.ddGender.Icon = null;
            this.ddGender.IndicatorColor = System.Drawing.Color.Black;
            this.ddGender.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddGender.ItemBackColor = System.Drawing.Color.White;
            this.ddGender.ItemBorderColor = System.Drawing.Color.White;
            this.ddGender.ItemForeColor = System.Drawing.Color.White;
            this.ddGender.ItemHeight = 26;
            this.ddGender.ItemHighLightColor = System.Drawing.Color.Black;
            this.ddGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddGender.Location = new System.Drawing.Point(40, 179);
            this.ddGender.Name = "ddGender";
            this.ddGender.Size = new System.Drawing.Size(200, 32);
            this.ddGender.TabIndex = 51;
            this.ddGender.Text = "-select-";
            this.ddGender.SelectedIndexChanged += new System.EventHandler(this.ddGender_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(40, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 31);
            this.txtFirstName.TabIndex = 50;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(260, 180);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 31);
            this.txtPhone.TabIndex = 49;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(261, 89);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 31);
            this.txtLastName.TabIndex = 47;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(39, 355);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(422, 31);
            this.txtAddress.TabIndex = 46;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(39, 272);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(422, 31);
            this.txtEmail.TabIndex = 45;
            this.txtEmail.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.Red;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Red;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(193)))), ((int)(((byte)(221)))));
            this.btnDelete.IdleForecolor = System.Drawing.Color.Black;
            this.btnDelete.IdleLineColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(381, 417);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 42);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.btnCancel.Location = new System.Drawing.Point(205, 417);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 42);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnSave.ActiveForecolor = System.Drawing.Color.Black;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(293, 417);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 42);
            this.btnSave.TabIndex = 42;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(254)))), ((int)(((byte)(83)))));
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.btnAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.btnAdd.Location = new System.Drawing.Point(381, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 42);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.BackColor = System.Drawing.Color.White;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel6.Location = new System.Drawing.Point(39, 329);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(64, 22);
            this.bunifuLabel6.TabIndex = 39;
            this.bunifuLabel6.Text = "Address";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel6.Click += new System.EventHandler(this.bunifuLabel6_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel5.Location = new System.Drawing.Point(39, 246);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(43, 22);
            this.bunifuLabel5.TabIndex = 37;
            this.bunifuLabel5.Text = "Email";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(261, 158);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(47, 22);
            this.bunifuLabel4.TabIndex = 35;
            this.bunifuLabel4.Text = "Phone";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(40, 158);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(57, 22);
            this.bunifuLabel3.TabIndex = 34;
            this.bunifuLabel3.Text = "Gender";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(260, 63);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(87, 22);
            this.bunifuLabel2.TabIndex = 31;
            this.bunifuLabel2.Text = "Last Name";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(39, 63);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(90, 22);
            this.bunifuLabel1.TabIndex = 29;
            this.bunifuLabel1.Text = "First Name";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvCustomerDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCustomerDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerDetail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCustomerDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(193)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerDetail.DoubleBuffered = true;
            this.dgvCustomerDetail.EnableHeadersVisualStyles = false;
            this.dgvCustomerDetail.HeaderBgColor = System.Drawing.Color.Black;
            this.dgvCustomerDetail.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCustomerDetail.Location = new System.Drawing.Point(513, 3);
            this.dgvCustomerDetail.Name = "dgvCustomerDetail";
            this.dgvCustomerDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerDetail.Size = new System.Drawing.Size(432, 462);
            this.dgvCustomerDetail.TabIndex = 7;
            this.dgvCustomerDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDetail_CellClick);
            this.dgvCustomerDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDetail_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.bunifuSeparator1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbCustomer, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.40816F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.59184F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 98);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(244, 75);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(520, 15);
            this.bunifuSeparator1.TabIndex = 54;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Dream Meadow", 42F);
            this.lbCustomer.Location = new System.Drawing.Point(3, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(1002, 68);
            this.lbCustomer.TabIndex = 53;
            this.lbCustomer.Text = "Customer";
            this.lbCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_Customer_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Customer_Detail";
            this.Size = new System.Drawing.Size(1014, 608);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetail)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnInput;
        private Bunifu.Framework.BunifuCustomTextbox txtFirstName;
        private Bunifu.Framework.BunifuCustomTextbox txtPhone;
        private Bunifu.Framework.BunifuCustomTextbox txtLastName;
        private Bunifu.Framework.BunifuCustomTextbox txtAddress;
        private Bunifu.Framework.BunifuCustomTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbCustomer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCustomerDetail;
        private Bunifu.UI.WinForms.BunifuDropdown ddGender;
        private Bunifu.Framework.BunifuCustomTextbox txtId;
    }
}
