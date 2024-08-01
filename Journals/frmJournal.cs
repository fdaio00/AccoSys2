using AccountingPR.Accounts;
using AccountingPR.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        clsJournalHeaders _JournalHeaders;
        int? _JournalCount = null;
        int? _tempJournalDetialsID = null; 

        enum enMdoe { AddNew , Update };
        enMdoe _Mode = enMdoe.AddNew;
        private clsJournalDetails _JournalDetails;

       public enum enJournalType { General =1 ,Reversed = 2, Circular =3, Closed = 4};
        public enum enOperationType { DailyJournal =1 , Receipt = 2 , Disbursement=3 }
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
            //txtJournalID.Clear();
                txtAccountNo.Clear();
                txtAccountName.Clear();
                txtDebit.Clear();
                txtCredit.Clear(); 
            txtDebit.Text = "0.00";
                txtCredit.Text="0.00"; 
                txtExchange.Clear();
                txtDetails.Clear();
            //txtAccountNo.Focus();
            txtOperationType.Clear(); 
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
                    TotalCredit,
                    _tempJournalDetialsID??null);


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

            _CalculateTotalBalance();
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
            
 
        }

        private void _CalculateTotalBalance()
        {
          txtBalance.Text =  ( Convert.ToSingle(txtTotalDebit.Text) -
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
            _CalculateTotalBalance();
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
            if(dgvJournals.CurrentRow.Cells[11].Value!=null)
            {
                _tempJournalDetialsID = Convert.ToInt32(dgvJournals.CurrentRow.Cells[11].Value);
            }
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

        private void txtMoneyinsertingValues_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "هذا الحقل لا يجب ان يكون فارغا");

            }
            else if (Convert.ToSingle( Temp.Text.Trim())  <= 0.00 )
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "هذا الحقل يجب أن تكون قيمته اكبر من الصفر");

            }
            else
            {
                errorProvider1.SetError(Temp, null);

            }
        }

        private  async void btnNew_Click(object sender, EventArgs e)
        {
            _ClearTextBoxesAfterInsertingDataToDGV();
            dgvJournals.Rows.Clear();
            _CalculatingTotalDebitAndCredit();
            btnSave.Enabled = true; 
            _JournalCount =  await (clsJournalDetails.GetLastJournalNumber());
            txtJournalID.Text = _JournalCount.ToString();
            _JournalHeaders = new clsJournalHeaders();
            txtHeadNote.Focus();
        }

       async Task<bool> _SaveJournalDetails()
        {
            bool sucsess = true;

            try
            {
                for(int i =0; i <dgvJournals.Rows.Count; i++)
                {
                    if(dgvJournals.Rows.Count>0)
                    {
                        if (await clsJournalDetails.CheckJournalDetailsIDExists(Convert.ToInt32(dgvJournals.Rows[i].Cells[11].Value)))
                        {
                            _JournalDetails = clsJournalDetails.GetJournalDetailByID(Convert.ToInt32(dgvJournals.Rows[i].Cells[11].Value));
                        }
                        else
                        {
                            _JournalDetails = new clsJournalDetails();

                        }

                        _JournalDetails.AccountCurrencyID = Convert.ToInt32(dgvJournals.Rows[i].Cells[5].Value);
                        _JournalDetails.AccountCredit = Convert.ToDecimal(dgvJournals.Rows[i].Cells[4].Value);
                        _JournalDetails.AccountDebit = Convert.ToDecimal(dgvJournals.Rows[i].Cells[3].Value);
                        _JournalDetails.AccountID = Convert.ToInt32(dgvJournals.Rows[i].Cells[1].Value);
                        _JournalDetails.JouID = Convert.ToInt32(dgvJournals.Rows[i].Cells[0].Value);
                        _JournalDetails.JouNote = Convert.ToString(dgvJournals.Rows[i].Cells[8].Value);
                        _JournalDetails.CurrentExchange = Convert.ToSingle(dgvJournals.Rows[i].Cells[7].Value);
                       
                        

                        if(!await _JournalDetails.SaveAsync())
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
        async Task<bool> _SaveJournalHeader()
        {
            bool IsFound = false ; 
            _JournalHeaders.TotalCredit = Convert.ToDecimal(txtTotalCredit.Text);
            _JournalHeaders.TotalBalance = Convert.ToDecimal(txtBalance.Text);
            _JournalHeaders.JouNote = txtHeadNote.Text.Trim() ;
            _JournalHeaders.AddedByUserID = clsGlobal.CurrentUser.UserID;
            _JournalHeaders.AddDate = DateTime.Now;
            _JournalHeaders.JouDate = dtpJournalDate.Value;
            _JournalHeaders.EditDate = DateTime.Now;
            _JournalHeaders.EditedByUserID = clsGlobal.CurrentUser.UserID; 
            if(rbClosed.Checked)
            {

            _JournalHeaders.JouTypeID = Convert.ToInt32(enJournalType.Closed);
            }
            if(rbGeneral.Checked)
            {
                _JournalHeaders.JouTypeID = Convert.ToInt32(enJournalType.General);

            }
            _JournalHeaders.JouIsPost = ckbIsPost.Checked;
            _JournalHeaders.JouID = Convert.ToInt32(txtJournalID.Text);
            _JournalHeaders.TotalDebit =  Convert.ToDecimal(txtTotalDebit.Text);
            _JournalHeaders.OperationTypeID = Convert.ToInt32(enOperationType.DailyJournal);

            if(await _JournalHeaders.SaveAsync())
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
            
            if(await _SaveJournalHeader())
            {
                if(await _SaveJournalDetails())
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

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
        }
      
        void _LoadJournalHeaderInfo()
        {
            _JournalHeaders = clsJournalHeaders.GetJournalHeaderByID(Convert.ToInt32(txtSearch.Text.Trim()));
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
            dtpJournalDate  .Value = _JournalHeaders.JouDate.Value;
            txtHeadNote.Text = _JournalHeaders.JouNote.ToString();
            ckbIsPost.Checked = _JournalHeaders.JouIsPost??false;
            if(_JournalHeaders.JouTypeID == (int)enJournalType.Closed)
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
            txtOperationType.Text = _JournalHeaders.OperationTypeInfo.OperationName;

            _LoadJournalDetailsToDataGridView();
              

            


        }

        private async void _LoadJournalDetailsToDataGridView()
        {
            DataTable  dt = await clsJournalDetails.GetAllJournalDetailsByJouHeaderIDAsync(Convert.ToInt32(txtJournalID.Text.Trim()));
            if(dt.Rows.Count > 0)
            {
                dgvJournals.Rows.Clear();
                dgvJournals.RowCount = dt.Rows.Count;
                int j = 0; 
                for (int i = 0; i < dt.Rows.Count; i++)
                {

    
          
                    dgvJournals.Rows[j].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvJournals.Rows[j].Cells[1].Value = dt.Rows[i][1].ToString();
                    dgvJournals.Rows[j].Cells[2].Value = dt.Rows[i][2].ToString();
                    dgvJournals.Rows[j].Cells[3].Value = dt.Rows[i][3].ToString();
                    dgvJournals.Rows[j].Cells[4].Value = dt.Rows[i][4].ToString();
                    dgvJournals.Rows[j].Cells[5].Value = dt.Rows[i][5].ToString();
                    dgvJournals.Rows[j].Cells[6].Value = dt.Rows[i][6].ToString();
                    dgvJournals.Rows[j].Cells[7].Value = dt.Rows[i][7].ToString();
                    dgvJournals.Rows[j].Cells[8].Value = dt.Rows[i][8].ToString();
                    dgvJournals.Rows[j].Cells[9].Value = dt.Rows[i][9].ToString();
                    dgvJournals.Rows[j].Cells[10].Value = dt.Rows[i][10].ToString();
                    dgvJournals.Rows[j].Cells[11].Value = dt.Rows[i][11].ToString();
          
                    j++;
                }
            }
            else
            {
                myToast.ShowToast("هذا القيد لايحتوي على أي تفاصيل", ToastTypeIcon.Information);

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            _LoadJournalHeaderInfo();
            btnSave.Enabled = true; 


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)13)
            {
                btnEnterJournalDetails.PerformClick();
            }
        }

        private void dgvJournals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvJournals.CurrentRow !=null)
            {
                btnDelete.Enabled = true; 
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("هل انت متاكد من حذف السجل المحدد","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.OK)
                {
                if(await clsJournalDetails.DeleteAsync(Convert.ToInt32(dgvJournals.CurrentRow.Cells[11].Value)))
                {
                    myToast.ShowToast("تم حذف السجل بنجاح",ToastTypeIcon.Success);
                    dgvJournals.ClearSelection();
                    btnSearch.PerformClick();
                    btnDelete.Enabled = false; 
                }
                else
                {
                    myToast.ShowToast("لم يتم حذف السجل", ToastTypeIcon.Error);

                }

            }
        }
    }
}
