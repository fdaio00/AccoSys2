namespace AccountingPR.Currencies
{
    partial class frmListCurrencies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCureencies = new System.Windows.Forms.DataGridView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.gbCurrecntyType = new System.Windows.Forms.GroupBox();
            this.rbForegin = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPenni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrencyNameEn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrencyNameAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCureencies)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.gbCurrecntyType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.dgvCureencies);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملات";
            // 
            // dgvCureencies
            // 
            this.dgvCureencies.AllowUserToAddRows = false;
            this.dgvCureencies.AllowUserToDeleteRows = false;
            this.dgvCureencies.AllowUserToOrderColumns = true;
            this.dgvCureencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCureencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCureencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCureencies.Location = new System.Drawing.Point(3, 21);
            this.dgvCureencies.Name = "dgvCureencies";
            this.dgvCureencies.ReadOnly = true;
            this.dgvCureencies.RowHeadersWidth = 51;
            this.dgvCureencies.RowTemplate.Height = 24;
            this.dgvCureencies.Size = new System.Drawing.Size(597, 193);
            this.dgvCureencies.TabIndex = 0;
            this.dgvCureencies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCureencies_CellClick);
            // 
            // gbDetails
            // 
            this.gbDetails.BackColor = System.Drawing.Color.White;
            this.gbDetails.Controls.Add(this.gbCurrecntyType);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.txtPenni);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.txtExchange);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.txtSymbol);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.txtCurrencyNameEn);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.txtCurrencyNameAr);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetails.Location = new System.Drawing.Point(0, 217);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(603, 301);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "بيانات العملة";
            // 
            // gbCurrecntyType
            // 
            this.gbCurrecntyType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCurrecntyType.Controls.Add(this.rbForegin);
            this.gbCurrecntyType.Controls.Add(this.rbLocal);
            this.gbCurrecntyType.Enabled = false;
            this.gbCurrecntyType.Location = new System.Drawing.Point(24, 239);
            this.gbCurrecntyType.Name = "gbCurrecntyType";
            this.gbCurrecntyType.Size = new System.Drawing.Size(446, 56);
            this.gbCurrecntyType.TabIndex = 16;
            this.gbCurrecntyType.TabStop = false;
            // 
            // rbForegin
            // 
            this.rbForegin.AutoSize = true;
            this.rbForegin.Location = new System.Drawing.Point(31, 21);
            this.rbForegin.Name = "rbForegin";
            this.rbForegin.Size = new System.Drawing.Size(104, 22);
            this.rbForegin.TabIndex = 1;
            this.rbForegin.TabStop = true;
            this.rbForegin.Text = "عملة أجنبية";
            this.rbForegin.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Checked = true;
            this.rbLocal.Location = new System.Drawing.Point(288, 21);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(103, 22);
            this.rbLocal.TabIndex = 0;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "عملة محلية";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "نوع العملة:";
            // 
            // txtPenni
            // 
            this.txtPenni.Enabled = false;
            this.txtPenni.Location = new System.Drawing.Point(24, 210);
            this.txtPenni.Name = "txtPenni";
            this.txtPenni.Size = new System.Drawing.Size(446, 25);
            this.txtPenni.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "الفكة:";
            // 
            // txtExchange
            // 
            this.txtExchange.Enabled = false;
            this.txtExchange.Location = new System.Drawing.Point(24, 169);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(446, 25);
            this.txtExchange.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "الصرف:";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Enabled = false;
            this.txtSymbol.Location = new System.Drawing.Point(24, 122);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(446, 25);
            this.txtSymbol.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "الرمز:";
            // 
            // txtCurrencyNameEn
            // 
            this.txtCurrencyNameEn.Enabled = false;
            this.txtCurrencyNameEn.Location = new System.Drawing.Point(24, 81);
            this.txtCurrencyNameEn.Name = "txtCurrencyNameEn";
            this.txtCurrencyNameEn.Size = new System.Drawing.Size(446, 25);
            this.txtCurrencyNameEn.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "الاسم لاتيني:";
            // 
            // txtCurrencyNameAr
            // 
            this.txtCurrencyNameAr.Enabled = false;
            this.txtCurrencyNameAr.Location = new System.Drawing.Point(24, 34);
            this.txtCurrencyNameAr.Name = "txtCurrencyNameAr";
            this.txtCurrencyNameAr.Size = new System.Drawing.Size(446, 25);
            this.txtCurrencyNameAr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العملة:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::AccountingPR.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(36, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 63);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::AccountingPR.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(192, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 63);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::AccountingPR.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(348, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 63);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Image = global::AccountingPR.Properties.Resources.add;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.Location = new System.Drawing.Point(506, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 63);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmListCurrencies
            // 
            this.AcceptButton = this.btnNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(603, 628);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListCurrencies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملات";
            this.Load += new System.EventHandler(this.frmListCurrencies_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCureencies)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbCurrecntyType.ResumeLayout(false);
            this.gbCurrecntyType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCureencies;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbCurrecntyType;
        private System.Windows.Forms.RadioButton rbForegin;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPenni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrencyNameEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrencyNameAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
    }
}