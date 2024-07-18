using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AccountingPR.System_Settings
{
    public partial class frmConnectionFormat : Form
    {
        public frmConnectionFormat()
        {
            
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }
        void _EnableTextBoxes()
        {
            txtDataBase.Enabled = true;
            txtMode.Enabled = true;
            txtSeverName.Enabled = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnSave.Enabled = true; 
            
            txtDataBase.Clear();
            txtMode.Clear();
            txtSeverName.Clear();
            txtUserName.Clear();
           txtPassword.Clear();
        
            txtMode.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            _EnableTextBoxes();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

            Properties.Settings.Default.Mode     = txtMode.Text.Trim();
            Properties.Settings.Default.DB       = txtDataBase.Text.Trim();
            Properties.Settings.Default.Server   = txtSeverName.Text.Trim();
            Properties.Settings.Default.UserID   = txtUserName.Text.Trim();
            Properties.Settings.Default.Password = txtPassword.Text.Trim();
            Properties.Settings.Default.Save();
                MessageBox.Show("تم الحفظ بنحاح","حفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return; 
            }

            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtMode.Text = Properties.Settings.Default.Mode;
            txtDataBase.Text = Properties.Settings.Default.DB;
            txtSeverName.Text = Properties.Settings.Default.Server;
            txtUserName.Text = Properties.Settings.Default.UserID;
            txtPassword.Text = Properties.Settings.Default.Password;
        }

        private void frmConnectionFormat_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Mode = "";
                Properties.Settings.Default.DB = "";
                Properties.Settings.Default.Server = "";
                Properties.Settings.Default.UserID = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
                MessageBox.Show("تم الحذف بنحاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
             
            }
        }
    }
}
