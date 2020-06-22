namespace GUI.User_Controls
{
    partial class UC_DebtReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DebtReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientBackground1 = new GUI.GradientBackground();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDebt = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientBackground1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebt)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientBackground1
            // 
            this.gradientBackground1.Angle = 121F;
            this.gradientBackground1.Color0 = System.Drawing.Color.SkyBlue;
            this.gradientBackground1.Color1 = System.Drawing.Color.Violet;
            this.gradientBackground1.Controls.Add(this.pictureBox1);
            this.gradientBackground1.Controls.Add(this.bunifuImageButton1);
            this.gradientBackground1.Controls.Add(this.label1);
            this.gradientBackground1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientBackground1.Location = new System.Drawing.Point(0, 0);
            this.gradientBackground1.Name = "gradientBackground1";
            this.gradientBackground1.Size = new System.Drawing.Size(1012, 617);
            this.gradientBackground1.TabIndex = 1;
            this.gradientBackground1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientBackground1_Paint);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(480, 549);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(52, 49);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Neon 80s", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debt Report";
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dgvDebt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 617);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.bunifuDropdown2);
            this.panel2.Controls.Add(this.bunifuDropdown1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 181);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neon 80s", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Debt Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Color = System.Drawing.Color.DimGray;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.DimGray;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.DimGray;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.bunifuDropdown1.Location = new System.Drawing.Point(324, 115);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(128, 32);
            this.bunifuDropdown1.TabIndex = 1;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.BorderRadius = 1;
            this.bunifuDropdown2.Color = System.Drawing.Color.DimGray;
            this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.FillDropDown = false;
            this.bunifuDropdown2.FillIndicator = false;
            this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.FormattingEnabled = true;
            this.bunifuDropdown2.Icon = null;
            this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.DimGray;
            this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.DimGray;
            this.bunifuDropdown2.ItemHeight = 26;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.bunifuDropdown2.Location = new System.Drawing.Point(554, 115);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(128, 32);
            this.bunifuDropdown2.TabIndex = 2;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ActiveImage")));
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ImageActive")));
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 15;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(35, 38);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(50, 53);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(478, 104);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(50, 53);
            this.bunifuImageButton2.TabIndex = 35;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 15;
            this.bunifuImageButton2.ZoomSpeed = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Year";
            // 
            // dgvDebt
            // 
            this.dgvDebt.AllowCustomTheming = true;
            this.dgvDebt.AllowUserToAddRows = false;
            this.dgvDebt.AllowUserToDeleteRows = false;
            this.dgvDebt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDebt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDebt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDebt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDebt.ColumnHeadersHeight = 40;
            this.dgvDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CUSTOMER,
            this.DATE,
            this.TOTAL,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDebt.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDebt.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDebt.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDebt.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDebt.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDebt.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDebt.CurrentTheme.GridColor = System.Drawing.Color.Silver;
            this.dgvDebt.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvDebt.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDebt.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDebt.CurrentTheme.Name = null;
            this.dgvDebt.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebt.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDebt.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDebt.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDebt.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebt.EnableHeadersVisualStyles = false;
            this.dgvDebt.GridColor = System.Drawing.Color.Silver;
            this.dgvDebt.HeaderBackColor = System.Drawing.Color.Silver;
            this.dgvDebt.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDebt.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDebt.Location = new System.Drawing.Point(0, 181);
            this.dgvDebt.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDebt.Name = "dgvDebt";
            this.dgvDebt.ReadOnly = true;
            this.dgvDebt.RowHeadersVisible = false;
            this.dgvDebt.RowHeadersWidth = 51;
            this.dgvDebt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvDebt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDebt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gray;
            this.dgvDebt.RowTemplate.Height = 40;
            this.dgvDebt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebt.Size = new System.Drawing.Size(1012, 436);
            this.dgvDebt.TabIndex = 1;
            this.dgvDebt.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Order ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.DataPropertyName = "FULLNAME";
            this.CUSTOMER.HeaderText = "Customer";
            this.CUSTOMER.MinimumWidth = 6;
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.ReadOnly = true;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATE.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATE.HeaderText = "Date";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle4.Format = "C1";
            dataGridViewCellStyle4.NullValue = null;
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UC_DebtReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientBackground1);
            this.DoubleBuffered = true;
            this.Name = "UC_DebtReport";
            this.Size = new System.Drawing.Size(1012, 1234);
            this.Load += new System.EventHandler(this.UC_DebtReport_Load);
            this.gradientBackground1.ResumeLayout(false);
            this.gradientBackground1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientBackground gradientBackground1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
