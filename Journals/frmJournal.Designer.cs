namespace AccountingPR.Journals
{
    partial class frmJournal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpJournalDate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbClosed = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeadDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJournalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnterJournalDetails = new System.Windows.Forms.Button();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvJournals = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsJournalDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDifferentBetweenDebitAndCredit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ckbIsPost = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournals)).BeginInit();
            this.cmsJournalDetails.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbIsPost);
            this.groupBox1.Controls.Add(this.dtpJournalDate);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeadDetails);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtJournalID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1495, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtpJournalDate
            // 
            this.dtpJournalDate.Location = new System.Drawing.Point(705, 31);
            this.dtpJournalDate.Name = "dtpJournalDate";
            this.dtpJournalDate.Size = new System.Drawing.Size(304, 25);
            this.dtpJournalDate.TabIndex = 26;
            this.dtpJournalDate.Enter += new System.EventHandler(this.EnteringTextBox);
            this.dtpJournalDate.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::AccountingPR.Properties.Resources.arrow_left2;
            this.button3.Location = new System.Drawing.Point(37, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 67);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::AccountingPR.Properties.Resources.arrow_left;
            this.button4.Location = new System.Drawing.Point(115, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 67);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::AccountingPR.Properties.Resources.arrow_right2;
            this.button2.Location = new System.Drawing.Point(477, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 67);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::AccountingPR.Properties.Resources.arrow_right;
            this.button1.Location = new System.Drawing.Point(399, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 67);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(193, 65);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(200, 25);
            this.textBox11.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(886, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "نوع الحساب:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbClosed);
            this.groupBox2.Controls.Add(this.rbGeneral);
            this.groupBox2.Location = new System.Drawing.Point(668, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rbClosed
            // 
            this.rbClosed.AutoSize = true;
            this.rbClosed.Location = new System.Drawing.Point(18, 17);
            this.rbClosed.Name = "rbClosed";
            this.rbClosed.Size = new System.Drawing.Size(62, 22);
            this.rbClosed.TabIndex = 1;
            this.rbClosed.TabStop = true;
            this.rbClosed.Text = "مغلق";
            this.rbClosed.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Checked = true;
            this.rbGeneral.Location = new System.Drawing.Point(135, 16);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(51, 22);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "عام";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1031, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاريخ القيد:";
            // 
            // txtHeadDetails
            // 
            this.txtHeadDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtHeadDetails.Location = new System.Drawing.Point(982, 85);
            this.txtHeadDetails.Name = "txtHeadDetails";
            this.txtHeadDetails.Size = new System.Drawing.Size(412, 25);
            this.txtHeadDetails.TabIndex = 0;
            this.txtHeadDetails.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtHeadDetails.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1423, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "البيان:";
            // 
            // txtJournalID
            // 
            this.txtJournalID.Location = new System.Drawing.Point(1130, 35);
            this.txtJournalID.Name = "txtJournalID";
            this.txtJournalID.ReadOnly = true;
            this.txtJournalID.Size = new System.Drawing.Size(264, 25);
            this.txtJournalID.TabIndex = 1;
            this.txtJournalID.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtJournalID.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1400, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم القيد:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnterJournalDetails);
            this.groupBox3.Controls.Add(this.cbCurrency);
            this.groupBox3.Controls.Add(this.txtCredit);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDetails);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtExchange);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDebit);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAccountName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAccountNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1495, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnEnterJournalDetails
            // 
            this.btnEnterJournalDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterJournalDetails.Location = new System.Drawing.Point(37, 37);
            this.btnEnterJournalDetails.Name = "btnEnterJournalDetails";
            this.btnEnterJournalDetails.Size = new System.Drawing.Size(72, 50);
            this.btnEnterJournalDetails.TabIndex = 6;
            this.btnEnterJournalDetails.Text = "إدخال";
            this.btnEnterJournalDetails.UseVisualStyleBackColor = false;
            this.btnEnterJournalDetails.Click += new System.EventHandler(this.btnEnterJournalDetails_Click);
            // 
            // cbCurrency
            // 
            this.cbCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(499, 51);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(148, 25);
            this.cbCurrency.TabIndex = 4;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            this.cbCurrency.SelectedValueChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            this.cbCurrency.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbCurrency_DragDrop);
            this.cbCurrency.DragEnter += new System.Windows.Forms.DragEventHandler(this.cbCurrency_DragEnter);
            this.cbCurrency.DragLeave += new System.EventHandler(this.cbCurrency_DragLeave);
            this.cbCurrency.Enter += new System.EventHandler(this.cbCurrency_Enter);
            this.cbCurrency.Leave += new System.EventHandler(this.cbCurrency_Leave);
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(668, 51);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(148, 25);
            this.txtCredit.TabIndex = 3;
            this.txtCredit.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtCredit.Leave += new System.EventHandler(this.LeaveTextBox);
            this.txtCredit.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoneyinsertingValues_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(785, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "دائن";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(138, 51);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(183, 25);
            this.txtDetails.TabIndex = 5;
            this.txtDetails.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtDetails.Leave += new System.EventHandler(this.LeaveTextBox);
            this.txtDetails.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "البيان";
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(338, 51);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.ReadOnly = true;
            this.txtExchange.Size = new System.Drawing.Size(148, 25);
            this.txtExchange.TabIndex = 16;
            this.txtExchange.Text = "0.0";
            this.txtExchange.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtExchange.Leave += new System.EventHandler(this.LeaveTextBox);
            this.txtExchange.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoneyinsertingValues_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "الصرف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "العملة";
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(833, 51);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(132, 25);
            this.txtDebit.TabIndex = 2;
            this.txtDebit.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtDebit.Leave += new System.EventHandler(this.LeaveTextBox);
            this.txtDebit.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoneyinsertingValues_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(929, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "مدين";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(982, 51);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(318, 25);
            this.txtAccountName.TabIndex = 1;
            this.txtAccountName.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtAccountName.Leave += new System.EventHandler(this.LeaveTextBox);
            this.txtAccountName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1211, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "اسم الحساب";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(1317, 51);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(148, 25);
            this.txtAccountNo.TabIndex = 0;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            this.txtAccountNo.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtAccountNo.Leave += new System.EventHandler(this.LeaveTextBox);
            this.txtAccountNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1384, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم الحساب";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvJournals);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1495, 334);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "قيد اليومية";
            // 
            // dgvJournals
            // 
            this.dgvJournals.AllowUserToAddRows = false;
            this.dgvJournals.AllowUserToDeleteRows = false;
            this.dgvJournals.AllowUserToOrderColumns = true;
            this.dgvJournals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dgvJournals.ContextMenuStrip = this.cmsJournalDetails;
            this.dgvJournals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJournals.Location = new System.Drawing.Point(3, 21);
            this.dgvJournals.Name = "dgvJournals";
            this.dgvJournals.ReadOnly = true;
            this.dgvJournals.RowHeadersWidth = 51;
            this.dgvJournals.RowTemplate.Height = 24;
            this.dgvJournals.Size = new System.Drawing.Size(1489, 310);
            this.dgvJournals.TabIndex = 0;
            this.dgvJournals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournals_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "رقم القيد";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 89.83953F;
            this.Column1.HeaderText = "رقم الحساب";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 171.123F;
            this.Column2.HeaderText = "اسم الحساب";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 89.83953F;
            this.Column4.HeaderText = "مدين";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 89.83953F;
            this.Column3.HeaderText = "دائن";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 89.83953F;
            this.Column5.HeaderText = "رقم العملة";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 89.83953F;
            this.Column6.HeaderText = "العملة";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 89.83953F;
            this.Column7.HeaderText = "الصرف";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 89.83953F;
            this.Column8.HeaderText = "البيان";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "اجمالي مدين";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "اجمالي دائن";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // cmsJournalDetails
            // 
            this.cmsJournalDetails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsJournalDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsJournalDetails.Name = "cmsJournalDetails";
            this.cmsJournalDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsJournalDetails.Size = new System.Drawing.Size(198, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.toolStripMenuItem1.Text = "حذف الصف الحالي";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnNew);
            this.groupBox5.Controls.Add(this.txtDifferentBetweenDebitAndCredit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtTotalDebit);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtTotalCredit);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 580);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1495, 93);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::AccountingPR.Properties.Resources.close;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(19, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::AccountingPR.Properties.Resources.delete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(175, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 59);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::AccountingPR.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(331, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Image = global::AccountingPR.Properties.Resources.add;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(487, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 59);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDifferentBetweenDebitAndCredit
            // 
            this.txtDifferentBetweenDebitAndCredit.Location = new System.Drawing.Point(704, 42);
            this.txtDifferentBetweenDebitAndCredit.Name = "txtDifferentBetweenDebitAndCredit";
            this.txtDifferentBetweenDebitAndCredit.ReadOnly = true;
            this.txtDifferentBetweenDebitAndCredit.Size = new System.Drawing.Size(167, 25);
            this.txtDifferentBetweenDebitAndCredit.TabIndex = 2;
            this.txtDifferentBetweenDebitAndCredit.Text = "0.00";
            this.txtDifferentBetweenDebitAndCredit.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtDifferentBetweenDebitAndCredit.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(887, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "الفرق:";
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.Location = new System.Drawing.Point(1192, 42);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.ReadOnly = true;
            this.txtTotalDebit.Size = new System.Drawing.Size(167, 25);
            this.txtTotalDebit.TabIndex = 0;
            this.txtTotalDebit.Text = "0.00";
            this.txtTotalDebit.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtTotalDebit.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1365, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "مدين:";
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Location = new System.Drawing.Point(951, 42);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.ReadOnly = true;
            this.txtTotalCredit.Size = new System.Drawing.Size(167, 25);
            this.txtTotalCredit.TabIndex = 1;
            this.txtTotalCredit.Text = "0.00";
            this.txtTotalCredit.Enter += new System.EventHandler(this.EnteringTextBox);
            this.txtTotalCredit.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1124, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "دائن:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ckbIsPost
            // 
            this.ckbIsPost.AutoSize = true;
            this.ckbIsPost.Checked = true;
            this.ckbIsPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIsPost.Location = new System.Drawing.Point(620, 30);
            this.ckbIsPost.Name = "ckbIsPost";
            this.ckbIsPost.Size = new System.Drawing.Size(65, 22);
            this.ckbIsPost.TabIndex = 27;
            this.ckbIsPost.Text = "مرحل";
            this.ckbIsPost.UseVisualStyleBackColor = true;
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1495, 675);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJournal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قيد اليومية";
            this.TransparencyKey = System.Drawing.Color.LightGreen;
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournals)).EndInit();
            this.cmsJournalDetails.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbClosed;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeadDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJournalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvJournals;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDifferentBetweenDebitAndCredit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpJournalDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Button btnEnterJournalDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.ContextMenuStrip cmsJournalDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox ckbIsPost;
    }
}