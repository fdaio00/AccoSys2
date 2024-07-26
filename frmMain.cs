using AccoSys;
using AccountingPR.Accounts;
using AccountingPR.Bank;
using AccountingPR.Company;
using AccountingPR.Currencies;
using AccountingPR.Journals;
using AccountingPR.System_Settings;
using AccountingPR.Users;
using AccountingPR_BusinessLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingPR
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void بياناتالاتصالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnectionFormat frm = new frmConnectionFormat();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void بياناتالشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompanyInfo frm = new frmCompanyInfo();
            frm.ShowDialog();
        }

        private void المستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAccounts frm = new frmListAccounts();
            frm.ShowDialog();
        }

        private void الصناديقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBanksCashes frm = new frmListBanksCashes(frmListBanksCashes.enScreen.CashesScreen);
            frm.ShowDialog();
        }

        private void البنوكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBanksCashes frm = new frmListBanksCashes(frmListBanksCashes.enScreen.BanksScreen);
            frm.ShowDialog();
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCurrencies frm = new frmListCurrencies();
            frm.ShowDialog();
        }

        private void toastToolStripMenuItem_Click(object sender, EventArgs e)
        { 
                myToast.ShowToast(" يتم الحفظ",ToastTypeIcon.Information,"حدث خطأ ما");
        }

        private void قيداليوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJournal frm = new frmJournal();
            frm.ShowDialog();
        }

        private void tesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain2 frm = new frmMain2();
            frm.ShowDialog();
        }

        private void عبدالباسطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myToast.ShowToast("عبد الباسط");
        }
    }
}
