using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingPR.Accounts
{
    public partial class frmSearchAccount : Form
    {
        int? _AccountNo;
        public enum enScreen { CashesScreen = 0, BanksScreen = 1 }
        public enScreen _Screen;
        public frmSearchAccount(int AccountNo,enScreen screen)
        {
            InitializeComponent();
            //_AccountNo = AccountNo;
            txtSearch.Text = AccountNo.ToString();

        }

        public frmSearchAccount(int AccountNo)
        {
            InitializeComponent();
            //_AccountNo = AccountNo;
            txtSearch.Text = AccountNo.ToString();  

        }

       
        public delegate void DataBackEventHandler(object sender, int AccountNo);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private async void frmSearchAccount_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
            _AccountNo = Convert.ToInt32(txtSearch.Text.Trim());

            }
            else
            {
                _AccountNo = -1; 
                
            }


            dgvAccounts.DataSource = await clsAccount.SearchByAccountNo(_AccountNo ?? -1);
            if (dgvAccounts.Rows.Count > 0)
            {
                dgvAccounts.Columns[0].HeaderText = "رقم الحساب";
                dgvAccounts.Columns[1].Visible = false;
                dgvAccounts.Columns[2].HeaderText = "اسم الحساب";
                dgvAccounts.Columns[3].Visible = false;
                dgvAccounts.Columns[4].Visible = false;
                dgvAccounts.Columns[5].Visible = false;
                dgvAccounts.Columns[6].Visible = false;
                dgvAccounts.Columns[7].Visible = false;
                dgvAccounts.Columns[8].Visible = false;
                dgvAccounts.Columns[9].Visible = false;

            }

        }

        private void dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccounts.Rows.Count > 0)
            {
                int AccontNumber = Convert.ToInt32(dgvAccounts.CurrentRow.Cells[0].Value);
                DataBack?.Invoke(this, AccontNumber);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAccounts.ClearSelection();
            frmSearchAccount_Load(null, null);
        }

        private void dgvAccounts_SelectionChanged(object sender, EventArgs e)
        {
            //txtSearch.Text = dgvAccounts.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmSearchAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dgvAccounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0 && e.KeyChar == (char)13)
            {
                dgvAccounts_CellDoubleClick(null, null);
            }
        }
    }
}
