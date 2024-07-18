namespace AccoSys
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(313, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(290, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(668, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تبديلالمستخدمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem النسخالاحتياطيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظنسخةاحتياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعادةنسخةمحفوظةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تهئيةالنظامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالشركةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالاتصالToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الصناديقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem البنوكToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحساباتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دليلالحساباتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قيداليوميةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سندصرفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سندقبضToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعةالدليلالمحاسبيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كشفحسابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حركةالصندوقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ميزانالمراجعةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الميزانيةالعموميةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الأرباحوالخسائرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مساعدةToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

