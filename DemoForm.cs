using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GetFormDemo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8 || e.KeyValue == 46)
            {
                return;
            }
            string cloneString = ((TextBox)sender).Text;
            if (cloneString.Length > 0)
                cloneString = cloneString.Substring(0,cloneString.Length - 1);
            if (e.KeyValue < 48 || e.KeyValue > 57)
            {
                ((TextBox)sender).Text = cloneString;
            }
            else
            {
                startCapture();
            }

        }

        private void startCapture()
        {
            int left = Convert.ToInt32(this.tbLeft.Text);
            int bottom = Convert.ToInt32(this.tbBottom.Text);
            int right = Convert.ToInt32(this.tbRight.Text);
            int top = Convert.ToInt32(this.tbTop.Text);

            if (bottom > this.Bottom)
            {
                bottom = this.Bottom;
                this.tbBottom.Text = this.Bottom.ToString();
            }
            if (right > this.Right)
            {
                right = this.Right;
                this.tbBottom.Text = this.Right.ToString();
            }

            if (bottom > top)
            {
                if (right > left)
                {
                    Comm.RECT rect = new Comm.RECT();
                    Comm.ScreenCapture pc = new Comm.ScreenCapture();
                    pc.SetRECT(ref rect, left, bottom, right, top);

                    Image image = pc.CaptureWindow(this.Handle, rect);
                    this.pictureCapture.Image = image;
                }
            }
        }

        private void DemoForm_Shown(object sender, EventArgs e)
        {
            startCapture();
        }
    }
}
