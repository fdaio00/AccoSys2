using AccountingPR.Accounts;
using AccountingPR.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingPR.Bonds
{
    public partial class frmBonds : Form
    {
        DataTable _dtCurrencyType;
        DataTable _dtCashes;
        clsCurrency _Currency;
        clsCash _Cash; 



        public enum enScreen { ReceiptScreen =1 , DisbursementScreen =2}
        public enScreen Screen;
        private clsAccount _Account;

        public frmBonds(enScreen ScreenType)
        {
            InitializeComponent();
            Screen = ScreenType;
        }

        async void _FillCashesComboBox()
        {
            _dtCashes = await clsCash.GetAllCashesAsync(); 
            if(_dtCashes.Rows.Count > 0)
            {
                foreach (DataRow item in _dtCashes.Rows)
                {
                    cbCashes.Items.Add(item["CashNameAr"]);
                }

                try
                {

                    //cbCashes.SelectedIndex = cbCurrency.FindString("الريال اليمني");
                }
                catch (Exception ex)
                {
                    clsGlobal.SetErrorLoggingEvent(ex.Message);
                    throw;
                }
            }
        }
        async void _FillCurrecnyTypesComboBox()
        {
            _dtCurrencyType = await clsCurrency.GetAllCurrenciesAsync();
            if (_dtCurrencyType.Rows.Count > 0)
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
        void _SetFormFormat()
        {

            txtUserName.Text = clsGlobal.CurrentUser.FullName.ToString(); 
           switch (Screen)
            {
                case enScreen.ReceiptScreen:
                    this.Text = "سند صرف";
                    gbTitle.Text = "بيانات سند الصرف";
                    rbReceipt.Checked = true; 

                    break; 
                case enScreen.DisbursementScreen:
                    this.Text = "سند قبض";
                    gbTitle.Text = "بيانات سند القبض";
                    rbDisbursement.Checked = true; 
                    break; 
            }
        }
        private void frmBonds_Load(object sender, EventArgs e)
        {
            _SetFormFormat();
            _FillCurrecnyTypesComboBox();
            _FillCashesComboBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Currency = clsCurrency.GetCurrencyByName(cbCurrency.SelectedItem.ToString());
            if (_Currency == null)
            {
                return;
            }
            txtExchange.Text = _Currency.CurrencyExchange.ToString();
        }

        private void cbCashes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Cash = clsCash.FindCashByName(cbCashes.SelectedItem.ToString());
            if(_Cash==null)
            {
                return; 
            }
            txtCahsID.Text = _Cash.AccountNo.ToString(); 
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            int? BondsNo =-1; 

            if(Screen == enScreen.ReceiptScreen)
            {
                BondsNo = await clsBondHeader.GenerateReceiptBondNo(); 
            }
            else
            {
                BondsNo = await clsBondHeader.GenerateDisbursementBondNo(); 
            }
            //why here it if i call get last numner direcly to the textvbox it does not 
            //set the value , but when I assign it to integer var it gives me the correct answer expected?
            txtBondHeaderID.Text = BondsNo?.ToString();
            txtJournalHeaderID.Text = (await clsJournalHeaders.GetLastJournalNumber()).ToString(); 
        }

        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAccountNo.Text.Trim()))
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
                    txtAmount.Focus();

                }
            }
        }

        private void GetAccountInfo(object sender, int AccountNo)
        {
            _Account = clsAccount.GetAccountByID(AccountNo);
            if (_Account == null)
            {
                return;
            }

            txtAccountNo.Text = _Account.AccountNo.ToString();
            txtAccountName.Text = _Account.AccountNameAr;
       
        }
    }
}
