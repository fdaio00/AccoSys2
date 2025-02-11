﻿namespace AccountingPR.Bonds
{
    partial class frmBonds
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalBonds = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.dgvBondsList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnterHeaderDetails = new System.Windows.Forms.Button();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJournalHeaderID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCahsID = new System.Windows.Forms.TextBox();
            this.cbCashes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ckbIsPost = new System.Windows.Forms.CheckBox();
            this.dtpBondHeaderDate = new System.Windows.Forms.DateTimePicker();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCurrentBondHeaderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDisbursement = new System.Windows.Forms.RadioButton();
            this.rbReceipt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeadNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBondHeaderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.gbTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnNew);
            this.groupBox5.Controls.Add(this.txtUserName);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtTotalBonds);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 580);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1881, 93);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::AccountingPR.Properties.Resources.close;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(193, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::AccountingPR.Properties.Resources.delete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(349, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 59);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::AccountingPR.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(505, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 59);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Image = global::AccountingPR.Properties.Resources.add;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(661, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 59);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(1370, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(222, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1598, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "اسم المستخدم:";
            // 
            // txtTotalBonds
            // 
            this.txtTotalBonds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalBonds.Location = new System.Drawing.Point(850, 40);
            this.txtTotalBonds.Name = "txtTotalBonds";
            this.txtTotalBonds.ReadOnly = true;
            this.txtTotalBonds.Size = new System.Drawing.Size(364, 23);
            this.txtTotalBonds.TabIndex = 1;
            this.txtTotalBonds.Text = "0.00";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1220, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "اجمالي السندات:";
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.dgvBondsList);
            this.gbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTitle.Location = new System.Drawing.Point(0, 246);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(1881, 334);
            this.gbTitle.TabIndex = 6;
            this.gbTitle.TabStop = false;
            // 
            // dgvBondsList
            // 
            this.dgvBondsList.AllowUserToAddRows = false;
            this.dgvBondsList.AllowUserToDeleteRows = false;
            this.dgvBondsList.AllowUserToOrderColumns = true;
            this.dgvBondsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBondsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBondsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvBondsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBondsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBondsList.Location = new System.Drawing.Point(3, 19);
            this.dgvBondsList.Name = "dgvBondsList";
            this.dgvBondsList.ReadOnly = true;
            this.dgvBondsList.RowHeadersWidth = 51;
            this.dgvBondsList.RowTemplate.Height = 24;
            this.dgvBondsList.Size = new System.Drawing.Size(1875, 312);
            this.dgvBondsList.TabIndex = 0;
            this.dgvBondsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBondsList_CellClick);
            this.dgvBondsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBondsList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم السند";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم الحساب";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم الحساب";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "المبلغ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "رقم العملة";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العملة";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الصرف";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "البيان";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "اجمالي المبلغ";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "معرف السند";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem1.Text = "ازالة الصف";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnterHeaderDetails);
            this.groupBox3.Controls.Add(this.cbCurrency);
            this.groupBox3.Controls.Add(this.txtDetails);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtExchange);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAccountName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAccountNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1881, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnEnterHeaderDetails
            // 
            this.btnEnterHeaderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterHeaderDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterHeaderDetails.Location = new System.Drawing.Point(132, 22);
            this.btnEnterHeaderDetails.Name = "btnEnterHeaderDetails";
            this.btnEnterHeaderDetails.Size = new System.Drawing.Size(72, 50);
            this.btnEnterHeaderDetails.TabIndex = 5;
            this.btnEnterHeaderDetails.Text = "ادخال";
            this.btnEnterHeaderDetails.UseVisualStyleBackColor = false;
            this.btnEnterHeaderDetails.Click += new System.EventHandler(this.btnEnterJournalDetails_Click);
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(723, 48);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(202, 24);
            this.cbCurrency.TabIndex = 4;
            this.cbCurrency.TabStop = false;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Location = new System.Drawing.Point(225, 48);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(273, 23);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDetails_KeyDown);
            this.txtDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetails_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "البيان";
            // 
            // txtExchange
            // 
            this.txtExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExchange.Location = new System.Drawing.Point(512, 48);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.ReadOnly = true;
            this.txtExchange.Size = new System.Drawing.Size(201, 23);
            this.txtExchange.TabIndex = 7;
            this.txtExchange.TabStop = false;
            this.txtExchange.Text = "0.0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "الصرف";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(888, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "العملة";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(938, 48);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(204, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1105, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "المبلغ";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountName.Location = new System.Drawing.Point(1159, 48);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(318, 23);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountName_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1397, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "اسم الحساب";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountNo.Location = new System.Drawing.Point(1494, 48);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(186, 23);
            this.txtAccountNo.TabIndex = 1;
            this.txtAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNo_KeyDown);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1608, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم الحساب";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJournalHeaderID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCahsID);
            this.groupBox1.Controls.Add(this.cbCashes);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.ckbIsPost);
            this.groupBox1.Controls.Add(this.dtpBondHeaderDate);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.txtCurrentBondHeaderID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeadNote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBondHeaderID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1881, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtJournalHeaderID
            // 
            this.txtJournalHeaderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJournalHeaderID.Location = new System.Drawing.Point(1302, 32);
            this.txtJournalHeaderID.Name = "txtJournalHeaderID";
            this.txtJournalHeaderID.ReadOnly = true;
            this.txtJournalHeaderID.Size = new System.Drawing.Size(191, 23);
            this.txtJournalHeaderID.TabIndex = 22;
            this.txtJournalHeaderID.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1512, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "رقم القيد:";
            // 
            // txtCahsID
            // 
            this.txtCahsID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCahsID.Location = new System.Drawing.Point(724, 89);
            this.txtCahsID.Name = "txtCahsID";
            this.txtCahsID.ReadOnly = true;
            this.txtCahsID.Size = new System.Drawing.Size(201, 23);
            this.txtCahsID.TabIndex = 18;
            this.txtCahsID.Text = "0.0";
            // 
            // cbCashes
            // 
            this.cbCashes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCashes.BackColor = System.Drawing.SystemColors.Window;
            this.cbCashes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCashes.FormattingEnabled = true;
            this.cbCashes.Location = new System.Drawing.Point(495, 32);
            this.cbCashes.Name = "cbCashes";
            this.cbCashes.Size = new System.Drawing.Size(202, 24);
            this.cbCashes.TabIndex = 18;
            this.cbCashes.SelectedIndexChanged += new System.EventHandler(this.cbCashes_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(938, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "رقم الصندوق:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(214, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 50);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(709, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "الصندوق:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(307, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 23);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TabStop = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(577, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "بحث برقم السند:";
            // 
            // ckbIsPost
            // 
            this.ckbIsPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbIsPost.AutoSize = true;
            this.ckbIsPost.Checked = true;
            this.ckbIsPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIsPost.Location = new System.Drawing.Point(806, 32);
            this.ckbIsPost.Name = "ckbIsPost";
            this.ckbIsPost.Size = new System.Drawing.Size(59, 20);
            this.ckbIsPost.TabIndex = 3;
            this.ckbIsPost.Text = "مرحل";
            this.ckbIsPost.UseVisualStyleBackColor = true;
            // 
            // dtpBondHeaderDate
            // 
            this.dtpBondHeaderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBondHeaderDate.Location = new System.Drawing.Point(885, 33);
            this.dtpBondHeaderDate.Name = "dtpBondHeaderDate";
            this.dtpBondHeaderDate.Size = new System.Drawing.Size(304, 23);
            this.dtpBondHeaderDate.TabIndex = 4;
            this.dtpBondHeaderDate.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = global::AccountingPR.Properties.Resources.arrow_left2;
            this.btnMin.Location = new System.Drawing.Point(17, 16);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 57);
            this.btnMin.TabIndex = 10;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Image = global::AccountingPR.Properties.Resources.arrow_left;
            this.btnPrevious.Location = new System.Drawing.Point(78, 16);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(55, 57);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Image = global::AccountingPR.Properties.Resources.arrow_right2;
            this.btnMax.Location = new System.Drawing.Point(417, 17);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(55, 57);
            this.btnMax.TabIndex = 6;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = global::AccountingPR.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(356, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 57);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtCurrentBondHeaderID
            // 
            this.txtCurrentBondHeaderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentBondHeaderID.Location = new System.Drawing.Point(150, 38);
            this.txtCurrentBondHeaderID.Name = "txtCurrentBondHeaderID";
            this.txtCurrentBondHeaderID.ReadOnly = true;
            this.txtCurrentBondHeaderID.Size = new System.Drawing.Size(200, 23);
            this.txtCurrentBondHeaderID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1274, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "نوع السند:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbDisbursement);
            this.groupBox2.Controls.Add(this.rbReceipt);
            this.groupBox2.Location = new System.Drawing.Point(1056, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rbDisbursement
            // 
            this.rbDisbursement.AutoSize = true;
            this.rbDisbursement.Location = new System.Drawing.Point(18, 17);
            this.rbDisbursement.Name = "rbDisbursement";
            this.rbDisbursement.Size = new System.Drawing.Size(53, 20);
            this.rbDisbursement.TabIndex = 1;
            this.rbDisbursement.TabStop = true;
            this.rbDisbursement.Text = "قبض";
            this.rbDisbursement.UseVisualStyleBackColor = true;
            this.rbDisbursement.CheckedChanged += new System.EventHandler(this.rbDisbursement_CheckedChanged);
            // 
            // rbReceipt
            // 
            this.rbReceipt.AutoSize = true;
            this.rbReceipt.Location = new System.Drawing.Point(135, 16);
            this.rbReceipt.Name = "rbReceipt";
            this.rbReceipt.Size = new System.Drawing.Size(54, 20);
            this.rbReceipt.TabIndex = 0;
            this.rbReceipt.Text = "صرف";
            this.rbReceipt.UseVisualStyleBackColor = true;
            this.rbReceipt.CheckedChanged += new System.EventHandler(this.rbReceipt_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1211, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاريخ السند:";
            // 
            // txtHeadNote
            // 
            this.txtHeadNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeadNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtHeadNote.Location = new System.Drawing.Point(1370, 84);
            this.txtHeadNote.Name = "txtHeadNote";
            this.txtHeadNote.Size = new System.Drawing.Size(412, 23);
            this.txtHeadNote.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1811, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "البيان:";
            // 
            // txtBondHeaderID
            // 
            this.txtBondHeaderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBondHeaderID.Location = new System.Drawing.Point(1591, 34);
            this.txtBondHeaderID.Name = "txtBondHeaderID";
            this.txtBondHeaderID.ReadOnly = true;
            this.txtBondHeaderID.Size = new System.Drawing.Size(191, 23);
            this.txtBondHeaderID.TabIndex = 1;
            this.txtBondHeaderID.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1788, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند:";
            // 
            // frmBonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 725);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbTitle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBonds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند صرف";
            this.Load += new System.EventHandler(this.frmBonds_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBondsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalBonds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEnterHeaderDetails;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCahsID;
        private System.Windows.Forms.ComboBox cbCashes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ckbIsPost;
        private System.Windows.Forms.DateTimePicker dtpBondHeaderDate;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtCurrentBondHeaderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDisbursement;
        private System.Windows.Forms.RadioButton rbReceipt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeadNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBondHeaderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJournalHeaderID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvBondsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}