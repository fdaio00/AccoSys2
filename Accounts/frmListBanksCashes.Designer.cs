namespace AccountingPR.Bank
{
    partial class frmListBanksCashes
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtAccountNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.dgvBanksCashes = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.gbTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanksCashes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowDetails);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDetails.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnShowDetails.Image = global::AccountingPR.Properties.Resources.document4;
            this.btnShowDetails.Location = new System.Drawing.Point(238, 24);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(102, 68);
            this.btnShowDetails.TabIndex = 18;
            this.btnShowDetails.Text = "عرض البيانات";
            this.btnShowDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Image = global::AccountingPR.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(12, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 68);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "خروج";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDelete.Image = global::AccountingPR.Properties.Resources.delete1;
            this.btnDelete.Location = new System.Drawing.Point(119, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 68);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSave.Image = global::AccountingPR.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(369, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 68);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNew.Image = global::AccountingPR.Properties.Resources.add;
            this.btnNew.Location = new System.Drawing.Point(488, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 68);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "جديد ";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtAccountNameAr);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.txtAccountNo);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetails.Location = new System.Drawing.Point(0, 299);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(590, 144);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "بيانات البنك";
            // 
            // txtAccountNameAr
            // 
            this.txtAccountNameAr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAccountNameAr.Enabled = false;
            this.txtAccountNameAr.Location = new System.Drawing.Point(41, 89);
            this.txtAccountNameAr.Name = "txtAccountNameAr";
            this.txtAccountNameAr.Size = new System.Drawing.Size(394, 25);
            this.txtAccountNameAr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الحساب:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Location = new System.Drawing.Point(41, 37);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(394, 25);
            this.txtAccountNo.TabIndex = 1;
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب:";
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.dgvBanksCashes);
            this.gbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTitle.Location = new System.Drawing.Point(0, 0);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(590, 299);
            this.gbTitle.TabIndex = 3;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "البنوك";
            // 
            // dgvBanksCashes
            // 
            this.dgvBanksCashes.AllowUserToAddRows = false;
            this.dgvBanksCashes.AllowUserToDeleteRows = false;
            this.dgvBanksCashes.AllowUserToOrderColumns = true;
            this.dgvBanksCashes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanksCashes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanksCashes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanksCashes.Location = new System.Drawing.Point(3, 21);
            this.dgvBanksCashes.Name = "dgvBanksCashes";
            this.dgvBanksCashes.ReadOnly = true;
            this.dgvBanksCashes.RowHeadersWidth = 51;
            this.dgvBanksCashes.RowTemplate.Height = 24;
            this.dgvBanksCashes.Size = new System.Drawing.Size(584, 275);
            this.dgvBanksCashes.TabIndex = 0;
            this.dgvBanksCashes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanksCashes_CellClick);
            // 
            // frmListBanksCashes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(590, 569);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListBanksCashes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "البنوك";
            this.Load += new System.EventHandler(this.frmListBanks_Load);
            this.groupBox3.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanksCashes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtAccountNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.DataGridView dgvBanksCashes;
        private System.Windows.Forms.Button btnShowDetails;
    }
}