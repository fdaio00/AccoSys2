namespace AccountingPR.Accounts
{
    partial class frmListAccounts
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
            this.tvAccounts = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParentAccountNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvAccounts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 553);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الحسابات";
            // 
            // tvAccounts
            // 
            this.tvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAccounts.Location = new System.Drawing.Point(3, 20);
            this.tvAccounts.Name = "tvAccounts";
            this.tvAccounts.RightToLeftLayout = true;
            this.tvAccounts.Size = new System.Drawing.Size(592, 530);
            this.tvAccounts.TabIndex = 0;
            this.tvAccounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAccounts_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCredit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDebit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAccountLevel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAccountName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtParentAccountNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAccountNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(616, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 292);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المدخلات";
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCredit.Location = new System.Drawing.Point(20, 178);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(220, 26);
            this.txtCredit.TabIndex = 5;
            this.txtCredit.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtCredit.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtCredit.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(260, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "دائن:";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBalance.Location = new System.Drawing.Point(20, 235);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(552, 26);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtBalance.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.Location = new System.Drawing.Point(658, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "رصيد:";
            // 
            // txtDebit
            // 
            this.txtDebit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDebit.Location = new System.Drawing.Point(347, 178);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(225, 26);
            this.txtDebit.TabIndex = 4;
            this.txtDebit.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtDebit.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtDebit.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(657, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "مدين:";
            // 
            // txtAccountLevel
            // 
            this.txtAccountLevel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAccountLevel.Location = new System.Drawing.Point(20, 131);
            this.txtAccountLevel.Name = "txtAccountLevel";
            this.txtAccountLevel.Size = new System.Drawing.Size(552, 26);
            this.txtAccountLevel.TabIndex = 3;
            this.txtAccountLevel.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtAccountLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtAccountLevel.Leave += new System.EventHandler(this.txtAccountLevel_Leave);
            this.txtAccountLevel.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(584, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "مستوى الحساب:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAccountName.Location = new System.Drawing.Point(20, 79);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(552, 26);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtAccountName.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtAccountName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(604, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم الحساب:";
            // 
            // txtParentAccountNo
            // 
            this.txtParentAccountNo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtParentAccountNo.Location = new System.Drawing.Point(20, 32);
            this.txtParentAccountNo.Name = "txtParentAccountNo";
            this.txtParentAccountNo.Size = new System.Drawing.Size(220, 26);
            this.txtParentAccountNo.TabIndex = 1;
            this.txtParentAccountNo.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtParentAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtParentAccountNo.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtParentAccountNo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(260, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "الحساب الأب:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAccountNo.Location = new System.Drawing.Point(369, 32);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(203, 26);
            this.txtAccountNo.TabIndex = 0;
            this.txtAccountNo.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtAccountNo.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtAccountNo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(612, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAccountType);
            this.groupBox3.Controls.Add(this.cbReport);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(616, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 124);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cbAccountType
            // 
            this.cbAccountType.BackColor = System.Drawing.Color.LightGreen;
            this.cbAccountType.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(20, 82);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(552, 26);
            this.cbAccountType.TabIndex = 9;
            // 
            // cbReport
            // 
            this.cbReport.BackColor = System.Drawing.Color.LightGreen;
            this.cbReport.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(20, 29);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(552, 26);
            this.cbReport.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label9.Location = new System.Drawing.Point(613, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "نوع الحساب:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(651, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "التقرير:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnNew);
            this.groupBox4.Location = new System.Drawing.Point(616, 455);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(729, 107);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Location = new System.Drawing.Point(11, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 57);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDelete.Location = new System.Drawing.Point(197, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 57);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSave.Location = new System.Drawing.Point(383, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 57);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNew.Location = new System.Drawing.Point(569, 28);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 57);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "جديد ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmListAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1346, 576);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListAccounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات";
            this.Load += new System.EventHandler(this.frmListAccounts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView tvAccounts;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParentAccountNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}