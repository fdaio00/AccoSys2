using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kp.Toaster;

namespace AccountingPR.Currencies
{
    public partial class frmListCurrencies : Form
    {
        clsCurrency _Currency;
        DataTable _dtCurrencies;
        public frmListCurrencies()
        {
            InitializeComponent();
        }

        async void _GetAllCurencies()
        {
            _dtCurrencies = await clsCurrency.GetAllCurrenciesAsync();
            dgvCureencies.DataSource = _dtCurrencies;
            if (dgvCureencies.Rows.Count > 0)
            {

                dgvCureencies.Columns[3].Visible = false;
                dgvCureencies.Columns[4].Visible = false;
                dgvCureencies.Columns[2].Visible = false;
                dgvCureencies.Columns[5].Visible = false;
                dgvCureencies.Columns[6].Visible = false;
                dgvCureencies.Columns[0].HeaderText = "رقم العملة";
                dgvCureencies.Columns[1].HeaderText = "اسم العملة";
                //dgvCureencies.Columns[3].HeaderText = "رمز العملة"; 
                //dgvCureencies.Columns[4].HeaderText = "صرف العملة"; 
                //dgvCureencies.Columns[5].HeaderText = "نوع العملة"; 
                //dgvCureencies.Columns[6].HeaderText = "فكة العملة"; 
            }

        }
        private void frmListCurrencies_Load(object sender, EventArgs e)
        {
            _GetAllCurencies();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _ClearAllTextBoxes(bool isEnableed = true)
        {
            foreach (var c in gbDetails.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    ((TextBox)c).Enabled = isEnableed;

                }
            }

            gbCurrecntyType.Enabled = isEnableed;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            _ClearAllTextBoxes();
            txtCurrencyNameAr.Focus();
            _Currency = new clsCurrency();
            this.AcceptButton = btnSave;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _Currency.CurrencyExchange = Convert.ToDecimal(txtExchange.Text.Trim());
            _Currency.CurrencyPenies = txtPenni.Text.Trim();
            _Currency.CurrencyNameEn = txtCurrencyNameEn.Text.Trim();
            _Currency.CurrencyNameAr = txtCurrencyNameAr.Text.Trim();
            _Currency.CurrencySymbol = txtSymbol.Text.Trim();
            _Currency.CurrencyTypeID = rbLocal.Checked ? 1 : 2;

            if (await _Currency.SaveAsync())
            {
                myToast.ShowToast("تم الحفظ بنجاح", ToastTypeIcon.Success);
                //Toast.show(this, "تم الحفظ", "تم الحفظ بنجاح", ToastTypeIcon.Information, ToastDuration.SHORT,ToastTheme.LIGHT,true);
                _GetAllCurencies();
            }
            else
            {
                //Toast.show(this, "لم يتم الحفظ", "خطأ في الحفظ ", ToastTypeIcon.Error, ToastDuration.SHORT);

                myToast.ShowToast("لم يتم الحفظ", ToastTypeIcon.Error);

            }
        }

        private void dgvCureencies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrencyID = Convert.ToInt32(dgvCureencies.CurrentRow.Cells[0].Value);
            if (CurrencyID != -1)
            {
                _LoadCurrecnyInfo(CurrencyID);
            }
        }

        private void _LoadCurrecnyInfo(int currencyID)
        {


            _Currency = clsCurrency.GetCurrencyByID(currencyID);
            if (_Currency == null)
            {
                return;
            }
            _ClearAllTextBoxes();
            btnDelete.Enabled = true;
            btnSave.Enabled = true; 
            txtExchange.Text = _Currency.CurrencyExchange.ToString();
            txtPenni.Text = _Currency.CurrencyPenies.ToString();

            txtCurrencyNameEn.Text = _Currency.CurrencyNameEn;
            txtCurrencyNameAr.Text = _Currency.CurrencyNameAr;
            txtSymbol.Text = _Currency.CurrencySymbol;
            if(_Currency.CurrencyTypeID==1)
            {
                rbLocal.Checked = true;
                rbForegin.Checked = false;

            }

            else
            {
                rbForegin.Checked = true;
                rbLocal.Checked = false ;


            }



        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد الحذف؟","تاكيد الحذف",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(await _Currency.DeleteAsync())
                {
                    myToast.ShowToast("تم الحذف بنجاح", ToastTypeIcon.Success);
                    _GetAllCurencies();
                    dgvCureencies.ClearSelection();
                    _ClearAllTextBoxes(false);
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    this.AcceptButton = btnNew; 
                }
                else
                {
                    myToast.ShowToast("فشل في الحذف", ToastTypeIcon.Error);

                }
            }
        }
    }
}
