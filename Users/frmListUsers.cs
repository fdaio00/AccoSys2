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

namespace AccountingPR.Users
{
    public partial class frmListUsers : Form
    {

        clsUser _User;
        DataTable _dtListUsers; 
        public frmListUsers()
        {
            InitializeComponent();
            
        }
        async void  _GetAllUsers()
        {
            _dtListUsers = await clsUser.GetAllUsersAsync(); 
            if(_dtListUsers != null)
            {
                dgvListUsers.DataSource = _dtListUsers;
                if(dgvListUsers.Rows.Count > 0)
                {
                    dgvListUsers.ClearSelection(); 
                    dgvListUsers.Columns[0].Visible = false;
                    dgvListUsers.Columns[1].HeaderText = "الاسم الكامل";
                    dgvListUsers.Columns[2].HeaderText = "اسم المستخدم";
                    dgvListUsers.Columns[3].HeaderText = "كلمة المرور";
                    dgvListUsers.Columns[4].HeaderText = "تلفون";
                    dgvListUsers.Columns[5].HeaderText = "البريد الالكتروني";
                    dgvListUsers.Columns[6].Visible = false;
                    dgvListUsers.Columns[7].Visible = false;
                    dgvListUsers.Columns[8].Visible = false;

                }
            }
        }

        void _LoadUsersInfoToTextBoxes(int UserID)
        {
            _User = clsUser.GetUserByID(UserID);
            if(_User==null)
            {

                myToast.ShowToast("لايوجد شخص بهذا الاسم", ToastTypeIcon.Error); 
                    return;
                
            }
            _EnabelDesableTextBoxes(true);
            btnSave.Enabled = true;
            txtEmail.Text = _User.Email;
            txtUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtPhone.Text = _User.Phone;
            txtEmail.Text = _User.Email;
            txtFullName.Text = _User.FullName;
            btnRemovePicture.Enabled = (_User.Image != null);
            btnDelete.Enabled = true; 
            if(_User.Image != null)
            {
                pbImage.Image = clsUtil.ByteToImage(_User.Image);
            }
            else
            {
                pbImage.Image = null;
            }
                ckbIsActive.Checked = _User.IsActive;
            if (_User.UserType)
                rbAdmin.Checked = true; 
            else
                rbUser.Checked = true;

            this.AcceptButton = btnSave;

        }
        void _ClearTextBoxes()
        {
            txtUserID.Text = "لم بتم الاضافة";
            txtEmail.Clear();
            txtUserID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            pbImage.Image = null; 
        }

        void _EnabelDesableTextBoxes(bool IsEnable)
        {
            txtEmail.Enabled = IsEnable;
            txtUserName.Enabled = IsEnable;
            txtPassword.Enabled = IsEnable;
            txtPhone.Enabled = IsEnable;
            txtEmail.Enabled = IsEnable;
            txtFullName.Enabled = IsEnable;
            btnSelectImage.Enabled = IsEnable;
        }


       
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _GetAllUsers();
            _EnabelDesableTextBoxes(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value);
            if (UserID > 0)
            {
                //this.AcceptButton = btnEdit;
                _LoadUsersInfoToTextBoxes(UserID);

                //_EnabelDesableTextBoxes(true); 
            }
        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.LightYellow;
            temp.SelectAll();temp.Focus();

            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.LightYellow;
            temp.SelectAll();temp.Focus();

            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-ye"));
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.White;
        
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _User = new clsUser();
            _EnabelDesableTextBoxes(true);
            _ClearTextBoxes();
            dgvListUsers.ClearSelection();
            rbUser.Checked = true; 
            txtUserID.Text = clsUser.GetUserMaxCount().ToString();
            txtFullName.Focus();
            btnSave.Enabled = true;
            this.AcceptButton = btnSave;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                myToast.ShowToast("يجب عليك اتمام عملية الخانات بالشروط المطلوبة",ToastTypeIcon.Information);
                return; 
            }
           
            _User.Email = txtEmail.Text.Trim();
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.Phone = txtPhone.Text.Trim(); 
            _User.FullName = txtFullName.Text.Trim();
            _User.Image = clsUtil.ImageToByte(pbImage);
            _User.IsActive = ckbIsActive.Checked;
            _User.UserType = rbAdmin.Checked;

            if(await _User.SaveAsync())
            {
                myToast.ShowToast("تم الحفظ بنجاح",ToastTypeIcon.Success);

                txtUserID.Text = _User.UserID.ToString();    
                
                btnNew.Enabled = true;
                _GetAllUsers();
            }
            else
            {
                myToast.ShowToast("لم يتم الحفظ",ToastTypeIcon.Warning);

            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("هل أنت متأكد من حذف هذا المستخدم ؟", "حذف!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (await clsUser.DeleteAsync (UserID))
                {
                    myToast.ShowToast("تم الحذف بنجاح",ToastTypeIcon.Success);

                    _GetAllUsers();
                    dgvListUsers.ClearSelection();
                    _ClearTextBoxes();

                }
                else
                {
                    myToast.ShowToast("حصل خطأ ما", ToastTypeIcon.Error);

                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog1.Title = "اختر صورة حلوة...";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    pbImage.ImageLocation = openFileDialog1.FileName;
                    btnRemovePicture.Enabled = true;
                }
            }
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if(string.IsNullOrEmpty(temp.Text.Trim()))
                {
                e.Cancel = true; 
                errorProvider1.SetError( temp,"هذا الحقل لا يمكن ان يكون فارغا");
            }
            else
            {
                errorProvider1.SetError(temp, null);

            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "هذا الحقل لا يمكن ان يكون فارغا");
            }
            else if (clsUser.CheckUserNameExists(txtUserName.Text.Trim()) && txtUserName.Text.Trim()!=_User.UserName)
            {

                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "اسم المستخدم هذا بالفعل موجود");


            }
            else
            {
                errorProvider1.SetError(txtUserName, null);

            }
            }

        private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

