using AccountingPR.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingPR.Journals
{
    public partial class frmJournal : Form
    {
        clsAccount _Account;
        DataTable _dtCurrencyType;
        clsCurrency _Currency;
        List<int> _AccountsList = new List<int>(); 
        public frmJournal()
        {
            InitializeComponent();
        }

        async void _FillCurrecnyTypesComboBox()
        {
            _dtCurrencyType = await clsCurrency.GetAllCurrenciesAsync();
           if(_dtCurrencyType.Rows.Count > 0)
            {
                foreach (DataRow item in _dtCurrencyType.Rows)
                {
                    cbCurrency.Items.Add(item["CurrencyNameAr"]);
                }

                try
                {

                    cbCurrency.SelectedIndex = cbCurrency.FindString("الريال اليمني");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            myToast.ShowToast("تم الخروج بنجاح", ToastTypeIcon.Information);
        }

        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAccountNo.Text.Trim()))
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == (char)13)
                {

                    frmSearchAccount frm = new frmSearchAccount(Convert.ToInt32(txtAccountNo.Text.Trim()));
                    frm.DataBack += GetAccountInfo;
                    frm.ShowDialog();
                }
            }
        }
        //60 line of code
        private void GetAccountInfo(object sender, int AccountNo)
        {
            _Account = clsAccount.GetAccountByID(AccountNo);
            if(_Account ==null)
            {
                return; 
            }

            txtAccountNo.Text = _Account.AccountNo.ToString();
            txtAccountName.Text = _Account.AccountNameAr;
            txtDebit.Text = _Account.AccountDebit.ToString("0.0");
            txtCredit.Text = _Account.AccountCredit.ToString("0.0"); 
            

        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            _FillCurrecnyTypesComboBox();
        }

        

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
             _Currency = clsCurrency.GetCurrencyByName(cbCurrency.SelectedItem.ToString());
            if(_Currency == null)
            {
                return; 
            }
            txtExchange.Text = _Currency.CurrencyExchange.ToString();
        }

        private void cbCurrency_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void cbCurrency_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void cbCurrency_DragLeave(object sender, EventArgs e)
        {

        }

        private void cbCurrency_Enter(object sender, EventArgs e)
        {
            cbCurrency.BackColor = Color.DarkTurquoise;

        }

        private void cbCurrency_Leave(object sender, EventArgs e)
        {
            cbCurrency.BackColor = Color.White;

        }
        void _ClearTextBoxesAfterInsertingDataToDGV()
        {
            txtJournalID.Clear();
                txtAccountNo.Clear();
                txtAccountName.Clear();
                txtDebit.Clear();
                txtCredit.Clear(); 
            txtDebit.Text = "0.00";
                txtCredit.Text="0.00"; 
                txtExchange.Clear();
                txtDetails.Clear();
            txtAccountNo.Focus();
            _Account = null; 
            _Currency = null;
            cbCurrency.SelectedIndex = cbCurrency.FindString("الريال اليمني");
            cbCurrency_SelectedIndexChanged(null, null);


        }

        void _EnteringRow()
        {
            if (_Account == null)
            {
                myToast.ShowToast("يجب عليك ادخال حساب صحيح", ToastTypeIcon.Information);
                txtAccountNo.Focus();
                txtAccountNo.SelectAll();
                return;
            }

            if(_AccountsList.Contains(Convert.ToInt32(txtAccountNo.Text)))
            {
                myToast.ShowToast("هذا الحساب مضاف بالفعل الى القائمة", ToastTypeIcon.Information);
                txtAccountNo.Focus();
                txtAccountNo.SelectAll();
                return;

            }
            try
            {
               
                float TotalDebit = Convert.ToSingle(txtExchange.Text.Trim()) * Convert.ToSingle(txtDebit.Text.Trim());
                float TotalCredit = Convert.ToSingle(txtExchange.Text) * Convert.ToSingle(txtCredit.Text);
                dgvJournals.Rows.Add(
                    txtJournalID.Text,
                    txtAccountNo.Text,
                    txtAccountName.Text,
                    txtDebit.Text,
                    txtCredit.Text,
                    _Currency.CurrencyID.ToString(),
                    _Currency.CurrencyNameAr.ToString(),
                    txtExchange.Text,
                    txtDetails.Text,
                    TotalDebit,
                    TotalCredit);
                _AccountsList.Add(Convert.ToInt32(txtAccountNo.Text)); 
                _ClearTextBoxesAfterInsertingDataToDGV();
            }
            catch (Exception)
            {

                myToast.ShowToast("حدثت مشكلة ما", ToastTypeIcon.Error);
            }
        }

        void _CalculatingTotalDebitAndCredit()
        {
            float TotalDebit = 0;
            float TotalCredit = 0; 

            for(int i=0; i<dgvJournals.Rows.Count; i++)
            {
                TotalDebit += Convert.ToSingle(dgvJournals.Rows[i].Cells[9].Value);
                TotalCredit += Convert.ToSingle(dgvJournals.Rows[i].Cells[10].Value);
            }

            txtTotalDebit.Text = TotalDebit.ToString("0.0"); 
            txtTotalCredit.Text = TotalCredit.ToString("0.0"); 
        }
        private void btnEnterJournalDetails_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                myToast.ShowToast("يحب عليك ادخال الفراغات المطلوبة",ToastTypeIcon.Warning);
                return;
            }
            _EnteringRow();
            _CalculatingTotalDebitAndCredit();
            _CalculateDifferenceBetweenDebitAndCredit();
            
 
        }

        private void _CalculateDifferenceBetweenDebitAndCredit()
        {
          txtDifferentBetweenDebitAndCredit.Text =  ( Convert.ToSingle(txtTotalDebit.Text) -
            Convert.ToSingle(txtTotalCredit.Text)).ToString("0.00");
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_AccountsList != null)
            {
                _AccountsList.Remove(Convert.ToInt32(dgvJournals.CurrentRow.Cells[1].Value));
            }
            dgvJournals.Rows.RemoveAt(dgvJournals.CurrentRow.Index);
            _CalculatingTotalDebitAndCredit();
            _CalculateDifferenceBetweenDebitAndCredit();
        }

        private void dgvJournals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtJournalID.Text = dgvJournals.CurrentRow.Cells[0].Value.ToString();
            txtAccountNo.Text = dgvJournals.CurrentRow.Cells[1].Value.ToString();
            _Account = clsAccount.GetAccountByID(Convert.ToInt32(txtAccountNo.Text.Trim()));
            txtAccountName.Text = dgvJournals.CurrentRow.Cells[2].Value.ToString();
            txtDebit.Text = dgvJournals.CurrentRow.Cells[3].Value.ToString();
            txtCredit.Text = dgvJournals.CurrentRow.Cells[4].Value.ToString();
          _Currency = clsCurrency.GetCurrencyByID(Convert.ToInt32( dgvJournals.CurrentRow.Cells[5].Value));
            cbCurrency.SelectedIndex = cbCurrency.FindString(_Currency.CurrencyNameAr);
            txtExchange.Text = dgvJournals.CurrentRow.Cells[7].Value.ToString();
            txtDetails.Text = dgvJournals.CurrentRow.Cells[8].Value.ToString();
            toolStripMenuItem1_Click(null, null);


        }

        private void EnteringTextBox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.PaleTurquoise;
            temp.SelectAll();
        }

        private void LeaveTextBox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.White;
            
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender; 
            if(string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "هذا الحقل لا يجب ان يكون فارغا");

            }
            else
            {
                errorProvider1.SetError(Temp,null);

            }
        }
    }
}
