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
    public partial class ctrlTextBox : UserControl
    {
        public ctrlTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cstTextBox_Paint(object sender, PaintEventArgs e)
        {
            Pen tPen;
            Graphics gLine;

            gLine = e.Graphics;
            textBox1.Font = this.Font;
            textBox1.Height = this.Height - 2;
            textBox1.Width = this.Width;
            tPen = new Pen(Color.DarkGray, 1.0F);
            int cordX1 = textBox1.Location.X;
            int cordX2 = textBox1.Location.X + textBox1.Width;
            int cordY1 = this.Height - 1;
            int cordY2 = this.Height - 1;
            gLine.DrawLine(tPen, cordX1, cordY1, cordX2, cordY2);

        }

        private void cstTextBox_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.Width;
            textBox1.Height = this.Height - 2;
        }

        public override Color ForeColor
        {
            get
            {
                return textBox1.ForeColor;
            }
            set
            {
                textBox1.ForeColor = value;
            }
        }
        public HorizontalAlignment TextAlign
        {
            get
            {
                return textBox1.TextAlign;
            }
            set
            {
            
                textBox1.TextAlign = value;
            }
        }

        public void SelectAll()
        {
            textBox1.SelectAll();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }
    }
}
