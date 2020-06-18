namespace GUI.User_Controls
{
    partial class Employee_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Profile));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbDob = new System.Windows.Forms.Label();
            this.lbCmnd = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbPhonenumber = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.ddGender = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbEmployee
            // 
            this.lbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Dream Meadow", 42F);
            this.lbEmployee.Location = new System.Drawing.Point(374, 0);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(181, 74);
            this.lbEmployee.TabIndex = 6;
            this.lbEmployee.Text = "Employee";
            // 
            // lbLastname
            // 
            this.lbLastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLastname.AutoSize = true;
            this.lbLastname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastname.Location = new System.Drawing.Point(104, 116);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(107, 22);
            this.lbLastname.TabIndex = 7;
            this.lbLastname.Text = "Last Name";
            // 
            // lbFirstname
            // 
            this.lbFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.Location = new System.Drawing.Point(292, 116);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(103, 22);
            this.lbFirstname.TabIndex = 7;
            this.lbFirstname.Text = "First Name";
            // 
            // lbDob
            // 
            this.lbDob.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDob.AutoSize = true;
            this.lbDob.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDob.Location = new System.Drawing.Point(104, 287);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(47, 22);
            this.lbDob.TabIndex = 7;
            this.lbDob.Text = "DoB";
            // 
            // lbCmnd
            // 
            this.lbCmnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCmnd.AutoSize = true;
            this.lbCmnd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCmnd.Location = new System.Drawing.Point(104, 205);
            this.lbCmnd.Name = "lbCmnd";
            this.lbCmnd.Size = new System.Drawing.Size(70, 22);
            this.lbCmnd.TabIndex = 7;
            this.lbCmnd.Text = "CMND";
            // 
            // lbGender
            // 
            this.lbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(529, 116);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(82, 22);
            this.lbGender.TabIndex = 7;
            this.lbGender.Text = "Gender";
            // 
            // lbRole
            // 
            this.lbRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(529, 287);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(49, 22);
            this.lbRole.TabIndex = 7;
            this.lbRole.Text = "Role";
            // 
            // lbPhonenumber
            // 
            this.lbPhonenumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPhonenumber.AutoSize = true;
            this.lbPhonenumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonenumber.Location = new System.Drawing.Point(529, 368);
            this.lbPhonenumber.Name = "lbPhonenumber";
            this.lbPhonenumber.Size = new System.Drawing.Size(148, 22);
            this.lbPhonenumber.TabIndex = 7;
            this.lbPhonenumber.Text = "Phone Number";
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(104, 368);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(83, 22);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Address";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(529, 205);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(65, 22);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Status";
            // 
            // ddGender
            // 
            this.ddGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ddGender.BackColor = System.Drawing.Color.White;
            this.ddGender.BorderRadius = 1;
            this.ddGender.Color = System.Drawing.Color.White;
            this.ddGender.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddGender.DisabledColor = System.Drawing.Color.Gray;
            this.ddGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddGender.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddGender.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddGender.FillDropDown = false;
            this.ddGender.FillIndicator = false;
            this.ddGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddGender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddGender.ForeColor = System.Drawing.Color.Black;
            this.ddGender.FormattingEnabled = true;
            this.ddGender.Icon = null;
            this.ddGender.IndicatorColor = System.Drawing.Color.Black;
            this.ddGender.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddGender.ItemBackColor = System.Drawing.Color.White;
            this.ddGender.ItemBorderColor = System.Drawing.Color.White;
            this.ddGender.ItemForeColor = System.Drawing.Color.Black;
            this.ddGender.ItemHeight = 26;
            this.ddGender.ItemHighLightColor = System.Drawing.Color.LightSkyBlue;
            this.ddGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.ddGender.Location = new System.Drawing.Point(533, 141);
            this.ddGender.Name = "ddGender";
            this.ddGender.Size = new System.Drawing.Size(217, 32);
            this.ddGender.TabIndex = 10;
            this.ddGender.Text = "Choose one";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuDropdown1.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Color = System.Drawing.Color.White;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuDropdown1.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.bunifuDropdown1.Location = new System.Drawing.Point(533, 312);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 32);
            this.bunifuDropdown1.TabIndex = 10;
            this.bunifuDropdown1.Text = "Choose one";
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuDropdown2.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.BorderRadius = 1;
            this.bunifuDropdown2.Color = System.Drawing.Color.White;
            this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.FillDropDown = false;
            this.bunifuDropdown2.FillIndicator = false;
            this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.FormattingEnabled = true;
            this.bunifuDropdown2.Icon = null;
            this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.ItemHeight = 26;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuDropdown2.Items.AddRange(new object[] {
            "Part-time",
            "Full-time"});
            this.bunifuDropdown2.Location = new System.Drawing.Point(533, 230);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(217, 32);
            this.bunifuDropdown2.TabIndex = 10;
            this.bunifuDropdown2.Text = "Choose one";
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveImage = null;
            this.btnEdit.AllowAnimations = true;
            this.btnEdit.AllowBuffering = false;
            this.btnEdit.AllowZooming = true;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ErrorImage")));
            this.btnEdit.FadeWhenInactive = false;
            this.btnEdit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.ImageLocation = null;
            this.btnEdit.ImageMargin = 40;
            this.btnEdit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEdit.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.InitialImage")));
            this.btnEdit.Location = new System.Drawing.Point(789, 59);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0;
            this.btnEdit.ShowActiveImage = true;
            this.btnEdit.ShowCursorChanges = true;
            this.btnEdit.ShowImageBorders = true;
            this.btnEdit.ShowSizeMarkers = false;
            this.btnEdit.Size = new System.Drawing.Size(90, 90);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.ToolTipText = "";
            this.btnEdit.WaitOnLoad = false;
            this.btnEdit.Zoom = 40;
            this.btnEdit.ZoomSpeed = 10;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderRadius = 40;
            this.bunifuTextBox1.BorderThickness = 3;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(108, 141);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Enter text";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(154, 51);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 12;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Enter text";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // Employee_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.ddGender);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhonenumber);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbCmnd);
            this.Controls.Add(this.lbDob);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbEmployee);
            this.Name = "Employee_Profile";
            this.Size = new System.Drawing.Size(937, 798);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhonenumber;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbCmnd;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbLastname;
        private Bunifu.UI.WinForms.BunifuDropdown ddGender;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private Bunifu.UI.WinForms.BunifuImageButton btnEdit;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
    }
}
