namespace ContactsPresentationLayer
{
    partial class frmAddEditContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gtxtbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblContactID = new System.Windows.Forms.Label();
            this.LblMode = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.LbRemove = new System.Windows.Forms.LinkLabel();
            this.LblSetImage = new System.Windows.Forms.LinkLabel();
            this.gpbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbCountry = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gtbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gpbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ContactID: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName:  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "DateOfBirth: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 41);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country: ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address: ";
            // 
            // gtxtbFirstName
            // 
            this.gtxtbFirstName.BorderRadius = 5;
            this.gtxtbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtbFirstName.DefaultText = "";
            this.gtxtbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbFirstName.Location = new System.Drawing.Point(167, 143);
            this.gtxtbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtxtbFirstName.Name = "gtxtbFirstName";
            this.gtxtbFirstName.PlaceholderText = "";
            this.gtxtbFirstName.SelectedText = "";
            this.gtxtbFirstName.Size = new System.Drawing.Size(229, 36);
            this.gtxtbFirstName.TabIndex = 8;
            // 
            // gtxtbLastName
            // 
            this.gtxtbLastName.BorderRadius = 5;
            this.gtxtbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtbLastName.DefaultText = "";
            this.gtxtbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbLastName.Location = new System.Drawing.Point(167, 199);
            this.gtxtbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtxtbLastName.Name = "gtxtbLastName";
            this.gtxtbLastName.PlaceholderText = "";
            this.gtxtbLastName.SelectedText = "";
            this.gtxtbLastName.Size = new System.Drawing.Size(229, 36);
            this.gtxtbLastName.TabIndex = 9;
            // 
            // gtxtbEmail
            // 
            this.gtxtbEmail.BorderRadius = 5;
            this.gtxtbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtbEmail.DefaultText = "";
            this.gtxtbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbEmail.Location = new System.Drawing.Point(167, 255);
            this.gtxtbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtxtbEmail.Name = "gtxtbEmail";
            this.gtxtbEmail.PlaceholderText = "";
            this.gtxtbEmail.SelectedText = "";
            this.gtxtbEmail.Size = new System.Drawing.Size(229, 36);
            this.gtxtbEmail.TabIndex = 10;
            // 
            // gtxtbPhone
            // 
            this.gtxtbPhone.BorderRadius = 5;
            this.gtxtbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtbPhone.DefaultText = "";
            this.gtxtbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtxtbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtbPhone.Location = new System.Drawing.Point(167, 311);
            this.gtxtbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtxtbPhone.Name = "gtxtbPhone";
            this.gtxtbPhone.PlaceholderText = "";
            this.gtxtbPhone.SelectedText = "";
            this.gtxtbPhone.Size = new System.Drawing.Size(229, 36);
            this.gtxtbPhone.TabIndex = 11;
            // 
            // LblContactID
            // 
            this.LblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactID.ForeColor = System.Drawing.Color.Black;
            this.LblContactID.Location = new System.Drawing.Point(178, 98);
            this.LblContactID.Name = "LblContactID";
            this.LblContactID.Size = new System.Drawing.Size(78, 41);
            this.LblContactID.TabIndex = 12;
            this.LblContactID.Text = "???";
            // 
            // LblMode
            // 
            this.LblMode.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMode.ForeColor = System.Drawing.Color.Black;
            this.LblMode.Location = new System.Drawing.Point(177, 22);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(327, 41);
            this.LblMode.TabIndex = 13;
            this.LblMode.Text = "Add New Contact";
            this.LblMode.Click += new System.EventHandler(this.LblMode_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(167, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(435, 549);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LbRemove
            // 
            this.LbRemove.BackColor = System.Drawing.Color.Transparent;
            this.LbRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRemove.LinkColor = System.Drawing.Color.Black;
            this.LbRemove.Location = new System.Drawing.Point(576, 78);
            this.LbRemove.Name = "LbRemove";
            this.LbRemove.Size = new System.Drawing.Size(95, 40);
            this.LbRemove.TabIndex = 17;
            this.LbRemove.TabStop = true;
            this.LbRemove.Text = "Remve";
            this.LbRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbRemove_LinkClicked);
            // 
            // LblSetImage
            // 
            this.LblSetImage.BackColor = System.Drawing.Color.Transparent;
            this.LblSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetImage.LinkColor = System.Drawing.Color.Black;
            this.LblSetImage.Location = new System.Drawing.Point(408, 78);
            this.LblSetImage.Name = "LblSetImage";
            this.LblSetImage.Size = new System.Drawing.Size(123, 40);
            this.LblSetImage.TabIndex = 18;
            this.LblSetImage.TabStop = true;
            this.LblSetImage.Text = "Set Image";
            this.LblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblSetImage_LinkClicked);
            // 
            // gpbImage
            // 
            this.gpbImage.BackColor = System.Drawing.Color.Transparent;
            this.gpbImage.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.gpbImage.ImageRotate = 0F;
            this.gpbImage.Location = new System.Drawing.Point(413, 143);
            this.gpbImage.Name = "gpbImage";
            this.gpbImage.Size = new System.Drawing.Size(246, 223);
            this.gpbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gpbImage.TabIndex = 19;
            this.gpbImage.TabStop = false;
            this.gpbImage.Click += new System.EventHandler(this.gpbImage_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.BackColor = System.Drawing.Color.Transparent;
            this.cbCountry.BorderRadius = 7;
            this.cbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountry.ItemHeight = 30;
            this.cbCountry.Location = new System.Drawing.Point(167, 423);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(229, 36);
            this.cbCountry.TabIndex = 20;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.BorderColor = System.Drawing.Color.DimGray;
            this.dtpDateOfBirth.BorderRadius = 7;
            this.dtpDateOfBirth.Checked = true;
            this.dtpDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfBirth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(167, 367);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(229, 36);
            this.dtpDateOfBirth.TabIndex = 21;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 10, 13, 23, 41, 9, 669);
            // 
            // gtbAddress
            // 
            this.gtbAddress.BorderRadius = 5;
            this.gtbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbAddress.DefaultText = "";
            this.gtbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gtbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtbAddress.Location = new System.Drawing.Point(167, 481);
            this.gtbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbAddress.Name = "gtbAddress";
            this.gtbAddress.PlaceholderText = "";
            this.gtbAddress.SelectedText = "";
            this.gtbAddress.Size = new System.Drawing.Size(229, 61);
            this.gtbAddress.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(671, 630);
            this.Controls.Add(this.gtbAddress);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.gpbImage);
            this.Controls.Add(this.LblSetImage);
            this.Controls.Add(this.LbRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.LblContactID);
            this.Controls.Add(this.gtxtbPhone);
            this.Controls.Add(this.gtxtbEmail);
            this.Controls.Add(this.gtxtbLastName);
            this.Controls.Add(this.gtxtbFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditContact";
            this.Load += new System.EventHandler(this.frmAddEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox gtxtbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox gtxtbLastName;
        private Guna.UI2.WinForms.Guna2TextBox gtxtbEmail;
        private Guna.UI2.WinForms.Guna2TextBox gtxtbPhone;
        private System.Windows.Forms.Label LblContactID;
        private System.Windows.Forms.Label LblMode;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.LinkLabel LbRemove;
        private System.Windows.Forms.LinkLabel LblSetImage;
        private Guna.UI2.WinForms.Guna2PictureBox gpbImage;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountry;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox gtbAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}