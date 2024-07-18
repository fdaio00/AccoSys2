namespace AccountingPR.Company
{
    partial class frmCompanyInfo
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
            this.txtCompNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddressAr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompNameEn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddressEN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWebiste = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListCompines = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemovePc = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbCompImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCompines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompNameAr
            // 
            this.txtCompNameAr.Enabled = false;
            this.txtCompNameAr.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCompNameAr.Location = new System.Drawing.Point(151, 20);
            this.txtCompNameAr.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompNameAr.Name = "txtCompNameAr";
            this.txtCompNameAr.Size = new System.Drawing.Size(364, 28);
            this.txtCompNameAr.TabIndex = 3;
            this.txtCompNameAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCompNameAr.Enter += new System.EventHandler(this.txtCompNameAr_Enter);
            this.txtCompNameAr.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "الاسم بالعربي: ";
            // 
            // txtAddressAr
            // 
            this.txtAddressAr.Enabled = false;
            this.txtAddressAr.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAddressAr.Location = new System.Drawing.Point(151, 103);
            this.txtAddressAr.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressAr.Name = "txtAddressAr";
            this.txtAddressAr.Size = new System.Drawing.Size(364, 28);
            this.txtAddressAr.TabIndex = 7;
            this.txtAddressAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddressAr.Enter += new System.EventHandler(this.txtCompNameAr_Enter);
            this.txtAddressAr.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "العنوان عربي:";
            // 
            // txtCompNameEn
            // 
            this.txtCompNameEn.Enabled = false;
            this.txtCompNameEn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCompNameEn.Location = new System.Drawing.Point(151, 62);
            this.txtCompNameEn.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompNameEn.Name = "txtCompNameEn";
            this.txtCompNameEn.Size = new System.Drawing.Size(364, 28);
            this.txtCompNameEn.TabIndex = 5;
            this.txtCompNameEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCompNameEn.TextChanged += new System.EventHandler(this.txtCompNameEn_TextChanged);
            this.txtCompNameEn.Enter += new System.EventHandler(this.txtCompNameEn_Enter);
            this.txtCompNameEn.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "الاسم لاتيني:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtEmail.Location = new System.Drawing.Point(151, 266);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(364, 28);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new System.EventHandler(this.txtCompNameEn_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "بريد الكتروني:";
            // 
            // txtFax
            // 
            this.txtFax.Enabled = false;
            this.txtFax.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFax.Location = new System.Drawing.Point(151, 227);
            this.txtFax.Margin = new System.Windows.Forms.Padding(2);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(364, 28);
            this.txtFax.TabIndex = 13;
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFax.Enter += new System.EventHandler(this.txtCompNameEn_Enter);
            this.txtFax.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "فاكس:";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhone.Location = new System.Drawing.Point(151, 186);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(364, 28);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.Enter += new System.EventHandler(this.txtCompNameEn_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(18, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "تلفون:";
            // 
            // txtAddressEN
            // 
            this.txtAddressEN.Enabled = false;
            this.txtAddressEN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAddressEN.Location = new System.Drawing.Point(151, 144);
            this.txtAddressEN.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressEN.Name = "txtAddressEN";
            this.txtAddressEN.Size = new System.Drawing.Size(364, 28);
            this.txtAddressEN.TabIndex = 9;
            this.txtAddressEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddressEN.Enter += new System.EventHandler(this.txtCompNameEn_Enter);
            this.txtAddressEN.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(18, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "العنوان لاتيني:";
            // 
            // txtWebiste
            // 
            this.txtWebiste.Enabled = false;
            this.txtWebiste.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtWebiste.Location = new System.Drawing.Point(151, 307);
            this.txtWebiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtWebiste.Name = "txtWebiste";
            this.txtWebiste.Size = new System.Drawing.Size(364, 28);
            this.txtWebiste.TabIndex = 17;
            this.txtWebiste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWebiste.Enter += new System.EventHandler(this.txtCompNameEn_Enter);
            this.txtWebiste.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(6, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "الموقع الالكتروني:";
            // 
            // dgvListCompines
            // 
            this.dgvListCompines.AllowUserToAddRows = false;
            this.dgvListCompines.AllowUserToDeleteRows = false;
            this.dgvListCompines.AllowUserToOrderColumns = true;
            this.dgvListCompines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCompines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCompines.Location = new System.Drawing.Point(13, 353);
            this.dgvListCompines.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListCompines.Name = "dgvListCompines";
            this.dgvListCompines.ReadOnly = true;
            this.dgvListCompines.RowHeadersWidth = 51;
            this.dgvListCompines.RowTemplate.Height = 24;
            this.dgvListCompines.Size = new System.Drawing.Size(779, 185);
            this.dgvListCompines.TabIndex = 19;
            this.dgvListCompines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCompines_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDelete.Image = global::AccountingPR.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(415, 558);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 59);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Image = global::AccountingPR.Properties.Resources.close;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(683, 558);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 59);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "خروج ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemovePc
            // 
            this.btnRemovePc.Enabled = false;
            this.btnRemovePc.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRemovePc.Location = new System.Drawing.Point(697, 258);
            this.btnRemovePc.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePc.Name = "btnRemovePc";
            this.btnRemovePc.Size = new System.Drawing.Size(86, 29);
            this.btnRemovePc.TabIndex = 26;
            this.btnRemovePc.Text = "حذف";
            this.btnRemovePc.UseVisualStyleBackColor = true;
            this.btnRemovePc.Click += new System.EventHandler(this.btnRemovePc_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBrowse.Location = new System.Drawing.Point(585, 258);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 29);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "اختيار صورة";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNew.Image = global::AccountingPR.Properties.Resources.add;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(49, 558);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 59);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "جديد ";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnEdit.Image = global::AccountingPR.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(293, 558);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 59);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSave.Image = global::AccountingPR.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(171, 558);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 59);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbCompImage
            // 
            this.pbCompImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCompImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCompImage.Location = new System.Drawing.Point(559, 20);
            this.pbCompImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbCompImage.Name = "pbCompImage";
            this.pbCompImage.Size = new System.Drawing.Size(233, 223);
            this.pbCompImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompImage.TabIndex = 18;
            this.pbCompImage.TabStop = false;
            this.pbCompImage.Click += new System.EventHandler(this.pbCompImage_Click);
            // 
            // frmCompanyInfo
            // 
            this.AcceptButton = this.btnNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 643);
            this.Controls.Add(this.btnRemovePc);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvListCompines);
            this.Controls.Add(this.pbCompImage);
            this.Controls.Add(this.txtWebiste);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddressEN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddressAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompNameEn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompNameAr);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الشركة ";
            this.Load += new System.EventHandler(this.frmCompanyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCompines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCompNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddressAr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompNameEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddressEN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWebiste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbCompImage;
        private System.Windows.Forms.DataGridView dgvListCompines;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemovePc;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}