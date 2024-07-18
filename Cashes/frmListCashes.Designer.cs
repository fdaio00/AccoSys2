//namespace AccountingPR.Bank
//{
//    partial class frmli
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.dsf = new System.Windows.Forms.GroupBox();
//            this.dgvCashes = new System.Windows.Forms.DataGridView();
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.txtAccountNameEn = new System.Windows.Forms.TextBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.txtAccountNameAr = new System.Windows.Forms.TextBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.txtAccountNo = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.groupBox3 = new System.Windows.Forms.GroupBox();
//            this.btnExit = new System.Windows.Forms.Button();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.btnSave = new System.Windows.Forms.Button();
//            this.btnNew = new System.Windows.Forms.Button();
//            this.dsf.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvCashes)).BeginInit();
//            this.groupBox2.SuspendLayout();
//            this.groupBox3.SuspendLayout();
//            // 
//            // dsf
//            // 
//            this.dsf.Controls.Add(this.dgvCashes);
//            this.dsf.Dock = System.Windows.Forms.DockStyle.Top;
//            this.dsf.Location = new System.Drawing.Point(0, 0);
//            this.dsf.Name = "dsf";
//            this.dsf.Size = new System.Drawing.Size(602, 299);
//            this.dsf.TabIndex = 0;
//            this.dsf.TabStop = false;
//            this.dsf.Text = "الصناديق";
//            // 
//            // dgvCashes
//            // 
//            this.dgvCashes.AllowUserToAddRows = false;
//            this.dgvCashes.AllowUserToDeleteRows = false;
//            this.dgvCashes.AllowUserToOrderColumns = true;
//            this.dgvCashes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvCashes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvCashes.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.dgvCashes.Location = new System.Drawing.Point(3, 21);
//            this.dgvCashes.Name = "dgvCashes";
//            this.dgvCashes.ReadOnly = true;
//            this.dgvCashes.RowHeadersWidth = 51;
//            this.dgvCashes.RowTemplate.Height = 24;
//            this.dgvCashes.Size = new System.Drawing.Size(596, 275);
//            this.dgvCashes.TabIndex = 0;
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Controls.Add(this.txtAccountNameEn);
//            this.groupBox2.Controls.Add(this.label3);
//            this.groupBox2.Controls.Add(this.txtAccountNameAr);
//            this.groupBox2.Controls.Add(this.label2);
//            this.groupBox2.Controls.Add(this.txtAccountNo);
//            this.groupBox2.Controls.Add(this.label1);
//            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
//            this.groupBox2.Location = new System.Drawing.Point(0, 299);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Size = new System.Drawing.Size(602, 194);
//            this.groupBox2.TabIndex = 1;
//            this.groupBox2.TabStop = false;
//            this.groupBox2.Text = "بيانات الصندوق";
//            // 
//            // txtAccountNameEn
//            // 
//            this.txtAccountNameEn.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.txtAccountNameEn.Location = new System.Drawing.Point(47, 137);
//            this.txtAccountNameEn.Name = "txtAccountNameEn";
//            this.txtAccountNameEn.Size = new System.Drawing.Size(394, 25);
//            this.txtAccountNameEn.TabIndex = 5;
//            // 
//            // label3
//            // 
//            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(454, 144);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(94, 18);
//            this.label3.TabIndex = 4;
//            this.label3.Text = "الاسم لاتيني:";
//            // 
//            // txtAccountNameAr
//            // 
//            this.txtAccountNameAr.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.txtAccountNameAr.Location = new System.Drawing.Point(47, 89);
//            this.txtAccountNameAr.Name = "txtAccountNameAr";
//            this.txtAccountNameAr.Size = new System.Drawing.Size(394, 25);
//            this.txtAccountNameAr.TabIndex = 3;
//            // 
//            // label2
//            // 
//            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(451, 96);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(97, 18);
//            this.label2.TabIndex = 2;
//            this.label2.Text = "اسم الحساب:";
//            // 
//            // txtAccountNo
//            // 
//            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.txtAccountNo.Location = new System.Drawing.Point(47, 37);
//            this.txtAccountNo.Name = "txtAccountNo";
//            this.txtAccountNo.Size = new System.Drawing.Size(394, 25);
//            this.txtAccountNo.TabIndex = 1;
//            // 
//            // label1
//            // 
//            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(459, 44);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(89, 18);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "رقم الحساب:";
//            // 
//            // groupBox3
//            // 
//            this.groupBox3.Controls.Add(this.btnExit);
//            this.groupBox3.Controls.Add(this.btnDelete);
//            this.groupBox3.Controls.Add(this.btnSave);
//            this.groupBox3.Controls.Add(this.btnNew);
//            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
//            this.groupBox3.Location = new System.Drawing.Point(0, 493);
//            this.groupBox3.Name = "groupBox3";
//            this.groupBox3.Size = new System.Drawing.Size(602, 82);
//            this.groupBox3.TabIndex = 2;
//            this.groupBox3.TabStop = false;
//            // 
//            // btnExit
//            // 
//            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
//            this.btnExit.Location = new System.Drawing.Point(18, 24);
//            this.btnExit.Name = "btnExit";
//            this.btnExit.Size = new System.Drawing.Size(88, 46);
//            this.btnExit.TabIndex = 17;
//            this.btnExit.Text = "خروج";
//            this.btnExit.UseVisualStyleBackColor = true;
//            // 
//            // btnDelete
//            // 
//            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
//            this.btnDelete.Location = new System.Drawing.Point(165, 24);
//            this.btnDelete.Name = "btnDelete";
//            this.btnDelete.Size = new System.Drawing.Size(88, 46);
//            this.btnDelete.TabIndex = 16;
//            this.btnDelete.Text = "حذف";
//            this.btnDelete.UseVisualStyleBackColor = true;
//            // 
//            // btnSave
//            // 
//            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F);
//            this.btnSave.Location = new System.Drawing.Point(312, 24);
//            this.btnSave.Name = "btnSave";
//            this.btnSave.Size = new System.Drawing.Size(88, 46);
//            this.btnSave.TabIndex = 15;
//            this.btnSave.Text = "حفظ";
//            this.btnSave.UseVisualStyleBackColor = true;
//            // 
//            // btnNew
//            // 
//            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F);
//            this.btnNew.Location = new System.Drawing.Point(459, 24);
//            this.btnNew.Name = "btnNew";
//            this.btnNew.Size = new System.Drawing.Size(88, 46);
//            this.btnNew.TabIndex = 14;
//            this.btnNew.Text = "جديد ";
//            this.btnNew.UseVisualStyleBackColor = true;
//            // 
//            // frmListCashes
//            //// 
//            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
//            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            //this.CancelButton = this.btnExit;
//            //this.ClientSize = new System.Drawing.Size(602, 588);
//            //this.Controls.Add(this.groupBox3);
//            //this.Controls.Add(this.groupBox2);
//            //this.Controls.Add(this.dsf);
//            //this.Font = new System.Drawing.Font("Tahoma", 8.5F);
//            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            //this.MaximizeBox = false;
//            //this.MinimizeBox = false;
//            //this.Name = "frmListCashes";
//            //this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            //this.RightToLeftLayout = true;
//            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            //this.Text = "الصناديق";
//            //this.Load += new System.EventHandler(this.frmListCashes_Load);
//            this.dsf.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvCashes)).EndInit();
//            this.groupBox2.ResumeLayout(false);
//            this.groupBox2.PerformLayout();
//            this.groupBox3.ResumeLayout(false);
//            //this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox dsf;
//        private System.Windows.Forms.GroupBox groupBox2;
//        private System.Windows.Forms.GroupBox groupBox3;
//        private System.Windows.Forms.DataGridView dgvCashes;
//        private System.Windows.Forms.TextBox txtAccountNameEn;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.TextBox txtAccountNameAr;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox txtAccountNo;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Button btnExit;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.Button btnSave;
//        private System.Windows.Forms.Button btnNew;
//    }
//}