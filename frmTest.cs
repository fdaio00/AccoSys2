using AccountingPR.Accounts;
using AccountingPR.Bank;
using AccountingPR.Bonds;
using AccountingPR.Company;
using AccountingPR.Currencies;
using AccountingPR.Journals;
using AccountingPR.System_Settings;
using AccountingPR.Users;
using MdiTabControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabControl = System.Windows.Forms.TabControl;

namespace AccoSys
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        void _OpenForm (object sender)
        {
            Form frm = (Form)sender;
            frm.BackColor = Color.White;
       
            tbForms.TabPages.Add(frm);
            frm.TopLevel = false; // Important to set this to false
            frm.FormBorderStyle = FormBorderStyle.None; // Remove border
            frm.Dock = DockStyle.None; // Ensure the form is not docked

            // Add the form to the TabPage and show it
           

            // Center the form within the TabPage
       
            frm.Left = (tbForms.ClientSize.Width - frm.Width) / 2;
            frm.Top = -10;
            frm.Show();



        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            tbForms.TabPages.Add(new frmListUsers());

        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            frmCompanyInfo frm = new frmCompanyInfo();
            _OpenForm(frm);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            _OpenForm(frm);
        }

        private void btnConnectionInfo_Click(object sender, EventArgs e)
        {

            frmConnectionFormat frm = new frmConnectionFormat();
            _OpenForm(frm);
        }

        private void btnCashed_Click(object sender, EventArgs e)
        {
            frmListBanksCashes frm = new frmListBanksCashes(frmListBanksCashes.enScreen.CashesScreen);
            _OpenForm(frm);
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            frmListBanksCashes frm = new frmListBanksCashes(frmListBanksCashes.enScreen.BanksScreen);
            _OpenForm(frm);
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            frmListCurrencies frm = new frmListCurrencies();
            _OpenForm(frm);
        }

        private void frmTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAccountLists_Click(object sender, EventArgs e)
        {
            frmListAccounts frm = new frmListAccounts();
            _OpenForm(frm);
        }

        private void btnDailyJournals_Click(object sender, EventArgs e)
        {
            frmJournal frm = new frmJournal(); 
            _OpenForm(frm);

        }

        private void btnGaveBonds_Click(object sender, EventArgs e)
        {
            frmBonds frm = new frmBonds(frmBonds.enScreen.ReceiptScreen);
            _OpenForm(frm);
        }

        private void btnTakeBond_Click(object sender, EventArgs e)
        {
            frmBonds frm = new frmBonds(frmBonds.enScreen.DisbursementScreen);
            _OpenForm(frm);
        }
    }
}
