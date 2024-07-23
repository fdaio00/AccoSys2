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

namespace AccountingPR.Bank
{
    public partial class frmListBanksCashes : Form
    {
       public  enum enScreen { CashesScreen =0 , BanksScreen =1}
        public enScreen _Screen;
        private clsCash _Cashes;
        private clsBank _Banks;

        public frmListBanksCashes(enScreen screen)
        {
            InitializeComponent();
            _Screen = screen;

        }

       async void _ShowDetails()
        {
            if (_Screen == enScreen.CashesScreen)
            {
                dgvBanksCashes.DataSource = await clsCash.GetAllCashesAsync();
                if (dgvBanksCashes.Rows.Count > 0)
                {
                    dgvBanksCashes.Columns[0].HeaderText = "معرف الصنوق";
                    dgvBanksCashes.Columns[1].HeaderText = "الاسم عربي";
                    dgvBanksCashes.Columns[2].HeaderText = "الاسم لاتيني";
                    this.Text = "الصناديق";
                    gbTitle.Text = "الصناديق";
                    gbDetails.Text = "بيانات الصندوق";

                    dgvBanksCashes.ClearSelection();
                }
            }
            if (_Screen == enScreen.BanksScreen)
            {
                dgvBanksCashes.DataSource = await clsBank.GetAllBanksAsync();
                if (dgvBanksCashes.Rows.Count > 0)
                {
                    dgvBanksCashes.Columns[0].HeaderText = "معرف البنك";
                    dgvBanksCashes.Columns[1].HeaderText = "الاسم عربي";
                    dgvBanksCashes.Columns[2].HeaderText = "الاسم لاتيني";
                    this.Text = "البنوك";
                    gbDetails.Text = "بيانات البنك";
                    gbTitle.Text = "البنوك";
                    dgvBanksCashes.ClearSelection();
                }
            }
        }
        private  void frmListBanks_Load(object sender, EventArgs e)
        {
            if(_Screen == enScreen.CashesScreen)
            {
                //dgvBanksCashes.DataSource = await clsCash.GetAllCashesAsync();
                //if (dgvBanksCashes.Rows.Count > 0)
                //{
                    //dgvBanksCashes.Columns[0].HeaderText = "معرف الصنوق";
                    //dgvBanksCashes.Columns[1].HeaderText = "الاسم عربي";
                    //dgvBanksCashes.Columns[2].HeaderText = "الاسم لاتيني";
                    this.Text = "الصناديق";
                    gbTitle.Text = "الصناديق";
                    gbDetails.Text = "بيانات الصندوق";

                    dgvBanksCashes.ClearSelection();
                
            }
            if (_Screen == enScreen.BanksScreen)
            {
                //dgvBanksCashes.DataSource = await clsBank.GetAllBanksAsync();
                //if (dgvBanksCashes.Rows.Count > 0)
                //{
                //    dgvBanksCashes.Columns[0].HeaderText = "معرف البنك";
                //    dgvBanksCashes.Columns[1].HeaderText = "الاسم عربي";
                //    dgvBanksCashes.Columns[2].HeaderText = "الاسم لاتيني";
                    this.Text = "البنوك";
                    gbDetails.Text = "بيانات البنك";
                    gbTitle.Text = "البنوك";
                    dgvBanksCashes.ClearSelection();
                
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadAccountInfoEvent(object sender , int AccountNo)
        {
            clsAccount Account = clsAccount.GetAccountByID(AccountNo);
            if(Account==null)
            {
                return; 
            }
            txtAccountNo.Text = Account.AccountNo.ToString();
            txtAccountNameAr.Text = Account.AccountNameAr;
        }
        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (13))
            {if (!string.IsNullOrEmpty(txtAccountNo.Text))
                {
                frmSearchAccount frm = new frmSearchAccount(Convert.ToInt32(txtAccountNo.Text.Trim()),(frmSearchAccount.enScreen)_Screen);
                frm.DataBack += LoadAccountInfoEvent;
                frm.ShowDialog();

                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtAccountNo.Enabled = true;
            txtAccountNo.Focus(); 
            txtAccountNo.Clear(); 
            txtAccountNameAr.Clear(); 
            if(_Screen ==enScreen.CashesScreen)
            {
                _Cashes = new clsCash();
            }
             if(_Screen ==enScreen.BanksScreen)
            {
                _Banks = new clsBank();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(_Screen ==enScreen.CashesScreen)
            {
                _Cashes.AccountNo = Convert.ToInt32(txtAccountNo.Text.Trim());
                _Cashes.CashNameAr = txtAccountNameAr.Text.Trim();
                if(await _Cashes.SaveAsync())
                {
                    myToast.ShowToast("تم الحفظ بنجاح",ToastTypeIcon.Success);
                    _ShowDetails();
                }
                else
                {
                      myToast.ShowToast("لم يتم الحفظ بنجاح",ToastTypeIcon.Success);

                }
            }

            if(_Screen==enScreen.BanksScreen)
            {
                _Banks.AccountNo = Convert.ToInt32(txtAccountNo.Text.Trim());
                _Banks.BankNameAr = txtAccountNameAr.Text.Trim();
                if (await _Banks.SaveAsync())
                {
                      myToast.ShowToast("تم الحفظ بنجاح",ToastTypeIcon.Success);
                    _ShowDetails();



                }
                else
                {
                      myToast.ShowToast("لم يتم الحفظ بنجاح",ToastTypeIcon.Success);

                }
            }
        }
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            _ShowDetails();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_Screen == enScreen.CashesScreen)
            {
                if (MessageBox.Show("هل تريد حذف الصندوق بالفعل؟", "تعديل", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (await _Cashes.DeleteAsync())
                    {
                          myToast.ShowToast("تم الحذف بنجاح",ToastTypeIcon.Success);

                    }
                    else
                    {
                          myToast.ShowToast("حدث خطأ ما!",ToastTypeIcon.Error);

                    }
                }
            }
            if (_Screen == enScreen.BanksScreen)
            {

                if (MessageBox.Show("هل تريد حذف البنك بالفعل؟", "تعديل", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (await _Banks.DeleteAsync())
                    {
                          myToast.ShowToast("تم الحذف بنجاح",ToastTypeIcon.Success);

                    }
                    else
                    {
                          myToast.ShowToast("حدث خطأ ما!",ToastTypeIcon.Error);

                    }
                }
            }
        }
        private void dgvBanksCashes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CashBankID = Convert.ToInt32(dgvBanksCashes.CurrentRow.Cells[0].Value);
            if(CashBankID > 0)
            {
                _LoadCashBankInfo(CashBankID);
            }
        }
        private void _LoadCashBankInfo(int CashBankID)
        {
            if (_Screen == enScreen.CashesScreen)
            {
                _Cashes = clsCash.GetCashByID(CashBankID);
               txtAccountNameAr.Text = _Cashes.CashNameAr;
                txtAccountNo.Text = _Cashes.AccountNo.ToString();
                btnDelete.Enabled = true; 
            }

            if (_Screen == enScreen.BanksScreen)
            {
                _Banks = clsBank.GetBankByID(CashBankID);
                txtAccountNameAr.Text = _Banks.BankNameAr;
                txtAccountNo.Text = _Banks.AccountNo.ToString();
                btnDelete.Enabled = true;

            }

        }
    }
}
