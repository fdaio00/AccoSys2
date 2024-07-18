using AccountingPR.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AccountingPR
{
    public enum ToastTypeIcon
    {
        Information,
        Warning,
        Error,
        Success
    }

    public partial class myToast : Form
    {
        int toastX, toastY;
       static string _Caption; 
      
        public myToast(string message, ToastTypeIcon type, string Caption)
        {
            InitializeComponent();
            SetIcon(type);
            Caption = _Caption;
        lblType.Text = Caption.ToString();
            lblMessage.Text = message; // Assuming you have a Label control named lblMessage
        }

        public static void ShowToast(string message,  ToastTypeIcon type=ToastTypeIcon.Information,string Caption ="")
        {



            string CaptionToSend = "";
            if(Caption!="")
            {
                CaptionToSend = _Caption; 
            }
            else
            {
                CaptionToSend = Caption;
            }
            myToast toast = new myToast(message, type,CaptionToSend);
            toast.Show();
        }

        private void SetIcon(ToastTypeIcon type)
        {
            switch (type)
            {
                case ToastTypeIcon.Information:
                    pbIcon.Image = Resources.info;
                    plBorder.BackColor = Color.FromArgb(18, 136, 191);
                    _Caption = "بيان";

                    break;
                case ToastTypeIcon.Warning:
                    pbIcon.Image = Resources._1488160809;
                    plBorder.BackColor = Color.FromArgb(245, 171, 35);
                    _Caption = "تحذير";

                    break;
                case ToastTypeIcon.Error:
                    pbIcon.Image = Resources.cross;
                    plBorder.BackColor = Color.Red;
                    _Caption = "فشل";

                    break;
                case ToastTypeIcon.Success:
                    pbIcon.Image = Resources.check_mark; // Assuming you have a custom success icon
                    plBorder.BackColor = Color.FromArgb(57, 155, 53);
                    _Caption = "نجاح";

                    break;
            }
        }

        private void Toast_Load(object sender, EventArgs e)
        {
            Position();
            toastTimer.Start();
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 4;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 870)
            {
                toastTimer.Stop();
                toastHide.Start();
            }
        }

        int y = 150;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 3);
                if (toastY > 950)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height;
            this.Location = new Point(toastX, toastY);
        }
    }
}
