using AccountingPR.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingPR.Accounts
{
    public partial class frmListAccounts : Form
    {

        clsAccount _Account; 
        DataTable _dtReports;
        DataTable _dtAccountTypes;
        enum enMode { AddNew =0, Update = 1 };
        enMode _Mode;
        async void _FillAccountTypeIDComboBox()
        {
            _dtAccountTypes = await clsAccountType.GetAllAccountTypeIDsAsync();
            if (_dtAccountTypes.Rows.Count>0)
            {
                cbAccountType.DataSource = _dtAccountTypes;
                cbAccountType.ValueMember = "AccountTypeID";
                cbAccountType.DisplayMember = "AccountTypeNameAr";

                //foreach (DataRow r in _dtAccountTypes.Rows)
                //{
                //    cbAccountType.Items.Add(r["AccountTypeNameAr"]);
                //}
            }
        }
        public frmListAccounts()


        {
            InitializeComponent();
        }
        void _EnbaleDesableTextBoxes(bool IsEnabled)
        {
            txtAccountLevel.Enabled = IsEnabled;
            txtAccountNo.Enabled = IsEnabled;
            txtAccountName.Enabled = IsEnabled;
            txtBalance.Enabled = IsEnabled;
            txtDebit.Enabled = IsEnabled;
            txtCredit.Enabled = IsEnabled;
            txtParentAccountNo.Enabled = IsEnabled;
            cbAccountType.Enabled = IsEnabled;
            cbReport.Enabled = IsEnabled;
            btnSave.Enabled = IsEnabled;
            btnDelete.Enabled = IsEnabled; 
        }


        private async void _CreateNodes()
        {
            TreeNode tn;
            tvAccounts.Nodes.Clear();
            DataView dataView = new DataView(await clsAccount.GetAllAccountsAsync());
            dataView.RowFilter = "AccountParentNo=0";
            foreach(DataRowView dv in dataView)
            {
                tn = new TreeNode((dv["AccountNo"]).ToString()+" " + dv["AccountNameAr"].ToString() );
                tn.Tag = dv["AccountNo"].ToString();
                tvAccounts.Nodes.Add(tn);
            }
            foreach(TreeNode tNode in tvAccounts.Nodes)
            {
                _CreateChildNode(tNode);
            }
        }

        private void _LoadAccountInfo(int AccountNo)
        {
            _Account = clsAccount.GetAccountByID(AccountNo);
            if (_Account == null)
            {
                myToast.ShowToast("لايوجد حساب بهذا الرقم", ToastTypeIcon.Warning);
                return;
            }
            _Mode = enMode.Update;
            _EnbaleDesableTextBoxes(true);
            txtAccountNo.Enabled = false; 
            txtAccountLevel.Text = _Account.AccountLevel.ToString();
            txtAccountNo.Text = _Account.AccountNo.ToString();
            txtAccountName.Text = _Account.AccountNameAr.ToString();
            txtBalance.Text = _Account.AccountBalance.ToString();
            txtDebit.Text = _Account.AccountDebit.ToString();
            txtCredit.Text = _Account.AccountCredit.ToString();
            txtParentAccountNo.Text = _Account.AccountParentNo.ToString();
            cbAccountType.Text = _Account.AccountType.AccountTypeINameAr;
            cbReport.Text = _Account.AccoutReport.ReportNameAr;
            
        }
        private async void _CreateChildNode(TreeNode treeNode)
        {
            TreeNode childNode;
            DataView dataView = new DataView(await clsAccount.GetAllAccountsAsync());
            dataView.RowFilter = $"AccountParentNo={Convert.ToInt32(treeNode.Tag)}";
            foreach (DataRowView dv in dataView)
            {
                childNode = new TreeNode((dv["AccountNo"]).ToString() + " " + dv["AccountNameAr"].ToString());
                childNode.Tag = dv["AccountNo"].ToString();
                treeNode.Nodes.Add(childNode);
                _CreateChildNode(childNode);
            }
        }
        async void _FillReportsCombomBox()
        {
            _dtReports = await clsReport.GetAllReportsAsync();
            if(_dtReports != null)
            {
                cbReport.DataSource = _dtReports;
                cbReport.ValueMember = "ReportID";
                cbReport.DisplayMember = "ReportNameAr";
                //foreach (DataRow row in _dtReports.Rows)
                //{
                //    cbReport.Items.Add(row["ReportNameAr"]);
                //}
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.LightYellow;
            temp.SelectAll(); temp.Focus();

        }
        private void TextBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "هذا الحقل لا يمكن ان يكون فارغا");
            }
            else
            {
                errorProvider1.SetError(temp, null);

            }
        }
        private void frmListAccounts_Load(object sender, EventArgs e)
        {
            _FillAccountTypeIDComboBox();
            _FillReportsCombomBox();
            _CreateNodes();
            _EnbaleDesableTextBoxes(false);
            this.AcceptButton = btnNew;
        }

        private void tvAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int AccountNo = Convert.ToInt32(tvAccounts.SelectedNode.Tag.ToString());
            _LoadAccountInfo(AccountNo);

           
        }

        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        void _ClearTextBoxes()
        {
            txtAccountLevel.Clear();
            txtAccountNo.Clear(); 
            txtAccountName.Clear(); 
            txtBalance.Clear(); 
                txtDebit.Clear(); 
            txtCredit.Clear(); 
            txtParentAccountNo.Clear();
            cbAccountType.SelectedIndex = 0; 
            cbReport.SelectedIndex = 0; 
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            this.AcceptButton = btnSave; 
            _Account = new clsAccount();
            _Mode = enMode.AddNew;
            _EnbaleDesableTextBoxes(true);
            btnDelete.Enabled = false; 
            _ClearTextBoxes();
            txtAccountNo.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                myToast.ShowToast("يجب عليك اتمام تعبئة الخانات بالشروط المطلوبة",ToastTypeIcon.Warning);
                return;
            }

            _Account.AccountParentNo = Convert.ToInt32(txtParentAccountNo.Text.Trim());
            _Account.AccountBalance = Convert.ToDecimal(txtBalance.Text.Trim());
            _Account.AccountDebit = Convert.ToDecimal(txtDebit.Text.Trim());  
            _Account.AccountLevel=Convert.ToInt32(txtAccountLevel.Text.Trim());
            _Account.AccountCredit=Convert.ToDecimal(txtAccountLevel.Text.Trim());
            _Account.AccountReportID = cbReport.SelectedIndex + 1;
            _Account.AccountNo = Convert.ToInt32(txtAccountNo.Text.Trim());
            _Account.AccountNameAr=txtAccountName.Text.Trim();
            _Account.AccountTypeID = cbAccountType.SelectedIndex + 1;
            if(_Mode==enMode.Update)
            {
                if(MessageBox.Show("هل تريد تعديل الحساب بالفعل؟","تعديل",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.Cancel)
                    return; 
            }
            if(await _Account.SaveAsync())
            {
                if (_Mode == enMode.Update)
                {
                    myToast.ShowToast("تم التعديل بنجاح",ToastTypeIcon.Success);
                    _CreateNodes();
                    btnDelete.Enabled = true;
                    txtAccountNo.Enabled = false; 
                    
                }
                else
                {
                    myToast.ShowToast("تم الحفظ بنجاح",ToastTypeIcon.Success);
                _CreateNodes();
                    btnDelete.Enabled = true;
                    txtAccountNo.Enabled = false;


                }

            }
            else
            {
                myToast.ShowToast("حدثت مشكلة ما",ToastTypeIcon.Warning);

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(_Account==null)
            {
                myToast.ShowToast("يجب عليك اختيار حساب اولا",ToastTypeIcon.Warning);
                return;
            }
            if(await clsAccount.CheckAccountHasChildren(_Account.AccountNo))
            {
                myToast.ShowToast("لايمكنك حذف هذا الحساب لان لديه ابناء", ToastTypeIcon.Warning);
                    return;
            }
          if(await clsAccount.CheckAccountHasJournal(_Account.AccountNo))
            {
                myToast.ShowToast("لايمكن حذف هذا الحساب لارتباطه بقيود أخرى",ToastTypeIcon.Warning );
                    return;
            }
            if (MessageBox.Show("هل تريد تعديل الحساب بالفعل؟", "تعديل", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if(await _Account.DeleteAsync())
                {
                    myToast.ShowToast("تم الحذف بنجاح",ToastTypeIcon.Success);
                    _CreateNodes();
                    _ClearTextBoxes();
                    _EnbaleDesableTextBoxes(false);
                    this.AcceptButton = btnNew; 
                }
                else
                {
                    myToast.ShowToast("حدث خطأ ما!",ToastTypeIcon.Warning);

                }
            }
        }

        private void txtAccountLevel_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.White;
            if (Convert.ToInt32(temp.Text) > 5)
                cbAccountType.SelectedIndex = 1;
        }
    }
}
