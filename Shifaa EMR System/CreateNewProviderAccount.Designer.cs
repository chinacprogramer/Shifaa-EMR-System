﻿namespace Shifaa_EMR_System
{
    partial class CreateNewProviderAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewProviderAccount));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PassCodeLabel = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PassCodeBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ReenterPasscodeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.JobTypeBox = new System.Windows.Forms.TextBox();
            this.JobTypeLabel = new System.Windows.Forms.Label();
            this.ChooseSchedulerLabel = new System.Windows.Forms.Label();
            this.SchedulerTable = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMRDatabaseDataSet = new Shifaa_EMR_System.EMRDatabaseDataSet();
            this.schedulerInfoTableAdapter = new Shifaa_EMR_System.EMRDatabaseDataSetTableAdapters.SchedulerInfoTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 47);
            this.panel2.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(4, 4);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 37);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.label1.Location = new System.Drawing.Point(182, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shifaa Health Systems Create Provider Account";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Light", 13F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(603, 6);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 37);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.UsernameLabel.Location = new System.Drawing.Point(200, 637);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 16);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username ";
            // 
            // PassCodeLabel
            // 
            this.PassCodeLabel.AutoSize = true;
            this.PassCodeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.PassCodeLabel.Location = new System.Drawing.Point(206, 688);
            this.PassCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassCodeLabel.Name = "PassCodeLabel";
            this.PassCodeLabel.Size = new System.Drawing.Size(66, 16);
            this.PassCodeLabel.TabIndex = 3;
            this.PassCodeLabel.Text = "Passcode ";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.UsernameBox.Location = new System.Drawing.Point(322, 637);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(145, 23);
            this.UsernameBox.TabIndex = 22;
            // 
            // PassCodeBox
            // 
            this.PassCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassCodeBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.PassCodeBox.Location = new System.Drawing.Point(322, 688);
            this.PassCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassCodeBox.Name = "PassCodeBox";
            this.PassCodeBox.Size = new System.Drawing.Size(145, 23);
            this.PassCodeBox.TabIndex = 23;
            this.PassCodeBox.TextChanged += new System.EventHandler(this.PassCodeBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginButton.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.LoginButton.Location = new System.Drawing.Point(296, 793);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(164, 48);
            this.LoginButton.TabIndex = 25;
            this.LoginButton.Text = "Create Account";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ReenterPasscodeBox
            // 
            this.ReenterPasscodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReenterPasscodeBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.ReenterPasscodeBox.Location = new System.Drawing.Point(322, 739);
            this.ReenterPasscodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReenterPasscodeBox.Name = "ReenterPasscodeBox";
            this.ReenterPasscodeBox.Size = new System.Drawing.Size(145, 23);
            this.ReenterPasscodeBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label2.Location = new System.Drawing.Point(164, 741);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reenter Passcode";
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.TitleBox.Location = new System.Drawing.Point(322, 201);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(145, 23);
            this.TitleBox.TabIndex = 15;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.Title.Location = new System.Drawing.Point(244, 203);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(32, 16);
            this.Title.TabIndex = 15;
            this.Title.Text = "Title";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.LastNameBox.Location = new System.Drawing.Point(322, 150);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(145, 23);
            this.LastNameBox.TabIndex = 14;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.FirstNameBox.Location = new System.Drawing.Point(322, 100);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(145, 23);
            this.FirstNameBox.TabIndex = 13;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.LastNameLabel.Location = new System.Drawing.Point(206, 150);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(69, 16);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.FirstNameLabel.Location = new System.Drawing.Point(200, 100);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(71, 16);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "First Name";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.PhoneNumberBox.Location = new System.Drawing.Point(322, 299);
            this.PhoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(145, 23);
            this.PhoneNumberBox.TabIndex = 17;
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.PhoneNumberBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(183, 301);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(93, 16);
            this.PhoneNumberLabel.TabIndex = 17;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.MaleCheckBox.Location = new System.Drawing.Point(428, 591);
            this.MaleCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(55, 20);
            this.MaleCheckBox.TabIndex = 21;
            this.MaleCheckBox.Text = "Male";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.FemaleCheckBox.Location = new System.Drawing.Point(318, 591);
            this.FemaleCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(70, 20);
            this.FemaleCheckBox.TabIndex = 20;
            this.FemaleCheckBox.Text = "Female";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(223, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gender";
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.EmailBox.Location = new System.Drawing.Point(322, 357);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(145, 23);
            this.EmailBox.TabIndex = 18;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.EmailLabel.Location = new System.Drawing.Point(231, 357);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Email";
            // 
            // JobTypeBox
            // 
            this.JobTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobTypeBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.JobTypeBox.Location = new System.Drawing.Point(322, 251);
            this.JobTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.JobTypeBox.Name = "JobTypeBox";
            this.JobTypeBox.Size = new System.Drawing.Size(145, 23);
            this.JobTypeBox.TabIndex = 16;
            // 
            // JobTypeLabel
            // 
            this.JobTypeLabel.AutoSize = true;
            this.JobTypeLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.JobTypeLabel.Location = new System.Drawing.Point(214, 251);
            this.JobTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTypeLabel.Name = "JobTypeLabel";
            this.JobTypeLabel.Size = new System.Drawing.Size(57, 16);
            this.JobTypeLabel.TabIndex = 28;
            this.JobTypeLabel.Text = "Job Type";
            // 
            // ChooseSchedulerLabel
            // 
            this.ChooseSchedulerLabel.AutoSize = true;
            this.ChooseSchedulerLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.ChooseSchedulerLabel.Location = new System.Drawing.Point(57, 469);
            this.ChooseSchedulerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseSchedulerLabel.Name = "ChooseSchedulerLabel";
            this.ChooseSchedulerLabel.Size = new System.Drawing.Size(219, 16);
            this.ChooseSchedulerLabel.TabIndex = 31;
            this.ChooseSchedulerLabel.Text = "Choose the Schedulers you work with";
            // 
            // SchedulerTable
            // 
            this.SchedulerTable.AllowUserToAddRows = false;
            this.SchedulerTable.AllowUserToDeleteRows = false;
            this.SchedulerTable.AutoGenerateColumns = false;
            this.SchedulerTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SchedulerTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SchedulerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedulerTable.ColumnHeadersVisible = false;
            this.SchedulerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.jobRoleDataGridViewTextBoxColumn});
            this.SchedulerTable.DataSource = this.schedulerInfoBindingSource;
            this.SchedulerTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SchedulerTable.Location = new System.Drawing.Point(318, 404);
            this.SchedulerTable.Margin = new System.Windows.Forms.Padding(4);
            this.SchedulerTable.Name = "SchedulerTable";
            this.SchedulerTable.ReadOnly = true;
            this.SchedulerTable.RowHeadersVisible = false;
            this.SchedulerTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SchedulerTable.Size = new System.Drawing.Size(183, 150);
            this.SchedulerTable.TabIndex = 19;
            this.SchedulerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // jobRoleDataGridViewTextBoxColumn
            // 
            this.jobRoleDataGridViewTextBoxColumn.DataPropertyName = "JobRole";
            this.jobRoleDataGridViewTextBoxColumn.HeaderText = "JobRole";
            this.jobRoleDataGridViewTextBoxColumn.Name = "jobRoleDataGridViewTextBoxColumn";
            this.jobRoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobRoleDataGridViewTextBoxColumn.Visible = false;
            // 
            // schedulerInfoBindingSource
            // 
            this.schedulerInfoBindingSource.DataMember = "SchedulerInfo";
            this.schedulerInfoBindingSource.DataSource = this.eMRDatabaseDataSet;
            // 
            // eMRDatabaseDataSet
            // 
            this.eMRDatabaseDataSet.DataSetName = "EMRDatabaseDataSet";
            this.eMRDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schedulerInfoTableAdapter
            // 
            this.schedulerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // CreateNewProviderAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(746, 763);
            this.Controls.Add(this.SchedulerTable);
            this.Controls.Add(this.ChooseSchedulerLabel);
            this.Controls.Add(this.JobTypeBox);
            this.Controls.Add(this.JobTypeLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.MaleCheckBox);
            this.Controls.Add(this.FemaleCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.ReenterPasscodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassCodeBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PassCodeLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateNewProviderAccount";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider Login";
            this.Load += new System.EventHandler(this.CreateNewProviderAccount_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PassCodeLabel;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PassCodeBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox ReenterPasscodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox JobTypeBox;
        private System.Windows.Forms.Label JobTypeLabel;
        private System.Windows.Forms.Label ChooseSchedulerLabel;
        private System.Windows.Forms.DataGridView SchedulerTable;
        private EMRDatabaseDataSet eMRDatabaseDataSet;
        private System.Windows.Forms.BindingSource schedulerInfoBindingSource;
        private EMRDatabaseDataSetTableAdapters.SchedulerInfoTableAdapter schedulerInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobRoleDataGridViewTextBoxColumn;
    }
}

