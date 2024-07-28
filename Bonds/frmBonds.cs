﻿using AccountingPR.Accounts;
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
        List<int> _AccountsList = new List<int>();
        clsBondHeader _BondHeader;
        clsBondDetail _BondDetail;



        public enum enScreen { ReceiptScreen = 1, DisbursementScreen = 2 }
        public enScreen Screen;
        private clsAccount _Account;
        private int? _tempHeaderDetialsID = null;

        public frmBonds(enScreen ScreenType)
        {
            InitializeComponent();
            Screen = ScreenType;
        }

        async void _FillCashesComboBox()
        {
            _dtCashes = await clsCash.GetAllCashesAsync();
            if (_dtCashes.Rows.Count > 0)
            {
                foreach (DataRow item in _dtCashes.Rows)
                {
                    cbCashes.Items.Add(item["CashNameAr"]);
                }

                try
                {

                    cbCashes.SelectedIndex = 0;
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
            if (_Cash == null)
            {
                return;
            }
            txtCahsID.Text = _Cash.AccountNo.ToString();
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            int? BondsNo = -1;

            if (Screen == enScreen.ReceiptScreen)
            {
                BondsNo = await clsBondHeader.GenerateReceiptBondNo();
            }
            else
            {
                BondsNo = await clsBondHeader.GenerateDisbursementBondNo();
            }
            //why here it if i call get last numner direcly to the textvbox it does not 
            //set the value , but when I assign it to integer var it gives me the correct answer expected?
            _ClearTextBoxesAfterInsertingDataToDGV();
            dgvBondsList.Rows.Clear();
            _CalculatingTotalBondsAmount();
            btnSave.Enabled = true;
            _BondHeader = new clsBondHeader();
            txtJournalHeaderID.Text = (await clsJournalHeaders.GetLastJournalNumber()).ToString();
            txtHeadNote.Focus();
            txtBondHeaderID.Text = BondsNo?.ToString();
            btnSave.Enabled = true;
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
        void _ClearTextBoxesAfterInsertingDataToDGV()
        {
            //txtJournalID.Clear();
            txtAccountNo.Clear();
            txtAccountName.Clear();
            txtAmount.Text = "0.00";
            txtExchange.Clear();
            txtDetails.Clear();
            //txtAccountNo.Focus();
            _Account = null;
            _Currency = null;
            cbCurrency.SelectedIndex = cbCurrency.FindString("الريال اليمني");
            cbCurrency_SelectedIndexChanged(null, null);


        }
        void _CalculatingTotalBondsAmount()
        {
            float TotalBonds = 0;

            for (int i = 0; i < dgvBondsList.Rows.Count; i++)
            {
                TotalBonds += Convert.ToSingle(dgvBondsList.Rows[i].Cells[8].Value);
            }

            txtTotalBonds.Text = TotalBonds.ToString("0.0");

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

            if (_AccountsList.Contains(Convert.ToInt32(txtAccountNo.Text)))
            {
                myToast.ShowToast("هذا الحساب مضاف بالفعل الى القائمة", ToastTypeIcon.Information);
                txtAccountNo.Focus();
                txtAccountNo.SelectAll();
                return;

            }
            try
            {

                float TotalBondAfterExchange = Convert.ToSingle(txtExchange.Text.Trim()) * Convert.ToSingle(txtAmount.Text.Trim());
                //float TotalCredit = Convert.ToSingle(txtExchange.Text) * Convert.ToSingle(txtCredit.Text);
                dgvBondsList.Rows.Add(
                    txtBondHeaderID.Text,
                    txtAccountNo.Text,
                    txtAccountName.Text,
                txtAmount.Text,
                    _Currency.CurrencyID.ToString(),
                    _Currency.CurrencyNameAr.ToString(),
                    txtExchange.Text,
                    txtDetails.Text,
                    TotalBondAfterExchange,
                    _tempHeaderDetialsID ?? null);
                //TotalDebit,
                //TotalCredit,
                //_tempJournalDetialsID ?? null);


                _AccountsList.Add(Convert.ToInt32(txtAccountNo.Text));
                _ClearTextBoxesAfterInsertingDataToDGV();
                _CalculatingTotalBondsAmount();
            }
            catch (Exception)
            {

                myToast.ShowToast("حدثت مشكلة ما", ToastTypeIcon.Error);
            }
        }
        private void btnEnterJournalDetails_Click(object sender, EventArgs e)
        {
            _EnteringRow();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnEnterHeaderDetails.PerformClick();
            }
        }

        private void dgvBondsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




            txtBondHeaderID.Text = dgvBondsList.CurrentRow.Cells[0].Value.ToString();
            txtAccountNo.Text = dgvBondsList.CurrentRow.Cells[1].Value.ToString();
            _Account = clsAccount.GetAccountByID(Convert.ToInt32(txtAccountNo.Text.Trim()));
            txtAccountName.Text = dgvBondsList.CurrentRow.Cells[2].Value.ToString();
            txtAmount.Text = dgvBondsList.CurrentRow.Cells[3].Value.ToString();
            _Currency = clsCurrency.GetCurrencyByID(Convert.ToInt32(dgvBondsList.CurrentRow.Cells[4].Value));
            cbCurrency.SelectedIndex = cbCurrency.FindString(_Currency.CurrencyNameAr);
            txtExchange.Text = dgvBondsList.CurrentRow.Cells[6].Value.ToString();
            txtDetails.Text = dgvBondsList.CurrentRow.Cells[7].Value.ToString();
            if (dgvBondsList.CurrentRow.Cells[9].Value != null)
            {
                _tempHeaderDetialsID = Convert.ToInt32(dgvBondsList.CurrentRow.Cells[9].Value);
            }


            toolStripMenuItem1_Click(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_AccountsList != null)
            {
                _AccountsList.Remove(Convert.ToInt32(dgvBondsList.CurrentRow.Cells[1].Value));
            }
            dgvBondsList.Rows.RemoveAt(dgvBondsList.CurrentRow.Index);
            _CalculatingTotalBondsAmount();
        }

        async Task<bool> _SaveBondDetails()
        {
            bool sucsess = true;

            try
            {
                for (int i = 0; i < dgvBondsList.Rows.Count; i++)
                {
                    if (dgvBondsList.Rows.Count > 0)
                    {
                        if (await clsBondDetail.CheckBondDetailsIDExists(Convert.ToInt32(dgvBondsList.Rows[i].Cells[9].Value)))
                        {
                            _BondDetail = clsBondDetail.GetBondDetailByID(Convert.ToInt32(dgvBondsList.Rows[i].Cells[9].Value));
                        }
                        else
                        {
                            _BondDetail = new clsBondDetail();

                        }

                        _BondDetail.BondID = Convert.ToInt32(dgvBondsList.Rows[i].Cells[0].Value);
                        _BondDetail.AccountID = Convert.ToInt32(dgvBondsList.Rows[i].Cells[1].Value);
                        _BondDetail.Amount = Convert.ToDecimal(dgvBondsList.Rows[i].Cells[3].Value);
                        _BondDetail.BondNote = Convert.ToString(dgvBondsList.Rows[i].Cells[7].Value);
                        _BondDetail.CurrencyID = Convert.ToInt32(dgvBondsList.Rows[i].Cells[4].Value);




                        if (!await _BondDetail.SaveAsync())
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                clsGlobal.SetErrorLoggingEvent(ex.Message);
                sucsess = false;
            }


            return sucsess;
        }

        int _GetBondTypeID()
        {
            if (rbDisbursement.Checked)
            {

                return Convert.ToInt32(enScreen.DisbursementScreen);
            }
            else if (rbReceipt.Checked)
            {
                return Convert.ToInt32(enScreen.ReceiptScreen);

            }
            else
                return -1;
        }
        async Task<bool> _SaveBondHeader()
        {
            bool IsFound = false;
            //_BondHeader.TotalCredit = Convert.ToDecimal(txtTotalCredit.Text);
            _BondHeader.BondID = Convert.ToInt32(txtBondHeaderID.Text);
            _BondHeader.BondDate = dtpBondHeaderDate.Value;
            _BondHeader.BondNote = txtHeadNote.Text.Trim();
            _BondHeader.BondTypeID = _GetBondTypeID();
            _BondHeader.IsPost = ckbIsPost.Checked;
            _BondHeader.BondBalance = Convert.ToDecimal(txtTotalBonds.Text);
            _BondHeader.CashID = _Cash.CashID;
            //_BondHeader.AccountBankID = 
            _BondHeader.AddedByUserID = clsGlobal.CurrentUser.UserID;
            _BondHeader.AddDate = DateTime.Now;
            _BondHeader.EditedByUserID = clsGlobal.CurrentUser.UserID;
            _BondHeader.EditDate = DateTime.Now;


            if (await _BondHeader.SaveAsync())
            {
                IsFound = true;
            }

            return IsFound;



        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //if(!this.ValidateChildren())
            //{
            //    myToast.ShowToast("يحب عليك ادخال الفراغات المطلوبة", ToastTypeIcon.Warning);
            //    return;
            //}

            if (await _SaveBondHeader())
            {
                if (await _SaveBondDetails())
                {
                    myToast.ShowToast("تم حفظ جميع السجلات بنجاح", ToastTypeIcon.Success);

                }
                else
                {
                    myToast.ShowToast("لم يتم حفظ بعض السجلات , حدث خطأ ما ", ToastTypeIcon.Error);

                }
            }
            else
            {
                myToast.ShowToast("لم يتم الحفظ , حدث خطأ ما ", ToastTypeIcon.Error);

            }
        }
         void _LoadJournalHeaderInfo()
        {
            _BondHeader =  clsBondHeader.FindBondHeaderByID(Convert.ToInt32(txtSearch.Text.Trim()));
            _ClearTextBoxesAfterInsertingDataToDGV();
            txtJournalID.Clear();
            txtHeadNote.Clear();
            dgvJournals.Rows.Clear();
            if (_JournalHeaders == null)
            {
                myToast.ShowToast("لا يوجد قيد بهذا الرقم", ToastTypeIcon.Information);
                txtSearch.Focus();
                return;
            }
            txtJournalID.Text = _JournalHeaders.JouID.ToString();
            dtpJournalDate.Value = _JournalHeaders.JouDate.Value;
            txtHeadNote.Text = _JournalHeaders.JouNote.ToString();
            ckbIsPost.Checked = _JournalHeaders.JouIsPost ?? false;
            if (_JournalHeaders.JouTypeID == (int)enJournalType.Closed)
            {
                rbClosed.Checked = true;
                rbGeneral.Checked = false;

            }
            if (_JournalHeaders.JouTypeID == (int)enJournalType.General)
            {
                rbGeneral.Checked = true;
                rbClosed.Checked = false;

            }
            txtBalance.Text = _JournalHeaders.TotalBalance.ToString();
            txtTotalDebit.Text = _JournalHeaders.TotalDebit.ToString();
            txtTotalCredit.Text = _JournalHeaders.TotalCredit.ToString();

            _LoadJournalDetailsToDataGridView();





        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _LoadJournalHeaderInfo();
        }
    }


    /*
     شوف المشكلة زم ما قال لك تشات جي بي تي انه لازم يكون هناك اوبجت من الكلاس اللي انت عايزه
    وزي ما قلت لك انك لازم تلتزم بالطريقة التي انت فاهم لها مش طريقة الاستاذ 
    في طريقة الاستاذ هو عامل 
    _LocalLicenseApplication.ApplicationInfo =.........
    اذا جئنا للنظر هنا في ال
    ApplicationInfo 
    سنرى انه عبارة عن كلاس داخل الكلاس الثانية بتاع اللوكال لايسنس ابلكيشن 
    وعشان هذه الكلاس لم يتم تعيين قيمة لها اما ان ترسل لها كونستركتر مليان او كنستركر فاضي
    ApplicationInfo = new clsApplicati on();
    or 
    ApplicationInfo = clsApplication.GetApplication(ApplicationID);

        لكن لو نظرنا الى السطر الثاني قد نرى انه يتم جلب البيانات وذلك بواسطة ارسال رقم الابلكيشن واللي هو في الاساس مش موجود 
        وهذه الدالة هي اصلا موجودة في كلاس لوكال لايسنش ابلكيشن ف عليك اولا ان تقوم بانشاء اوبجكت من كلاس لايسنس ابلكيشن 

        اذا كان الوضع وضع اضافة طلب جديد سنقوم بمراعاة الاشياء التالية لكي يتم الحفظ بنجاح 
        -  اولا ساقوم بالذهاب الى جدول 
        LocalLicenseApplications 
        س ارى ان يحتاج ان تتم اضافة 3 حقول حتى يتم الحفظ والتي هي : 
        LocalDrivingLicenseApplication ID والذي يضاف تلقائيا 
        ApplicationID
        LicenseClassID 

        اذا يتبين لنا انه لكي تتم عملية الحفظ سنقوم باضافة 
        application 
        ثم نقوم بارسال رقم الابلكيشن اي دي الى دالة اللوكال لاينسن لكي امليء هذا الحقل 
        ونقوم بجلب معلومات لايسنس كلاس من الكومبو بووكس 

        الان كيف س اقوم بحفظ ابكليشن جديد
        س اعمل اوبجكت جديد من 
        Application 
        >>_Application = new clsApplication(); 
        بعد ان اقوم بحقظ معلومات الابلكيشن س اقوم ب عمل اوبجكت جديد من نوع لوكال دراينفث لايسنس ابلكيشن 
        _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseAppliction(); 

        بعدها س اقوم باسناد المعلومات التي احتاج اليها لاجل الحفظ 
        _LocalDrivingLicenseApplication.Application = _Application.ApplicationID;
    _LocalDrivingLicenseApplication.LicenseClassID = cbLicsesClasses.selectedIndex +1 (او بطريقة الاستاذ في اليوزر او البيروسن (
    بعد ذلك س اعمل حفظ
    _LocalDrivingLicenseApplicato.Save()

    اخي مارلي هذه هي الحل الكامل لمشكلتك اسال الله ان اكون وفقت في شرحها 
    اذا لم تفهم ف قم بالبحث عنها في الانترنت 
    اذا لم يفتهم لك قم بمراجعة الكورس 18 
    اذا لم تفهم قم بمراجعة الكورس 16
    اذا لم تفهم قم بمراجعة الكورس 11
    اذا لم تفهم قم بمراجعة الكورس 10
    اذا لم تفهم عندك خلل في طريقة تتبعك لخارطة الطريق ويجب عليك اصلاحه 



     */
}
