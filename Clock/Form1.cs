using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int imgRes = 1000;
        int clockRes = 400;
        int sec = 0;
        int xOffset, yOffset;
        bool pinned = false;
        DateTime time;
        Graphics g;

        private void Redraw()
        {
            double x, y, a;
            g = this.CreateGraphics();
            Image dialImg = Image.FromFile("assets/Dial.png");
            Image hourImg = Image.FromFile("assets/Hours.png");
            Image minuteImg = Image.FromFile("assets/Minutes.png");
            Image secondImg = Image.FromFile("assets/Seconds.png");

            Graphics clock = Graphics.FromImage(dialImg);
            
            this.Width = clockRes;
            this.Height = clockRes;

            a = 30 * (time.Hour >= 12 ? time.Hour - 12 : time.Hour) + time.Minute / 2;
            x = imgRes / 2 * (1 + Math.Sqrt(2) * Math.Cos(Math.PI * (0.75 - a / 180)));
            y = imgRes / 2 * (1 - Math.Sqrt(2) * Math.Sin(Math.PI * (0.75 - a / 180)));
            clock.TranslateTransform((float)x, (float)y);
            clock.RotateTransform((float)a);
            clock.DrawImage(hourImg, 0, 0, imgRes, imgRes);

            a = 6 * time.Minute + time.Second / 10;
            x = imgRes / 2 * (1 + Math.Sqrt(2) * Math.Cos(Math.PI * (0.75 - a / 180)));
            y = imgRes / 2 * (1 - Math.Sqrt(2) * Math.Sin(Math.PI * (0.75 - a / 180)));
            clock.TranslateTransform((float)x, (float)y);
            clock.RotateTransform((float)a);
            clock.DrawImage(minuteImg, 0, 0, imgRes, imgRes);

            a = 6 * time.Second;
            x = imgRes / 2 * (1 + Math.Sqrt(2) * Math.Cos(Math.PI * (0.75 - a / 180)));
            y = imgRes / 2 * (1 - Math.Sqrt(2) * Math.Sin(Math.PI * (0.75 - a / 180)));
            clock.TranslateTransform((float)x, (float)y);
            clock.RotateTransform((float)a);
            clock.DrawImage(secondImg, 0, 0, imgRes, imgRes);

            g.DrawImage(dialImg, 0, 0, clockRes, clockRes);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            time = DateTime.Now;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Redraw();
            closeButton.Image = Image.FromFile("assets/Close.png");
            if(pinned == false)
            {
                pinButton.Image = Image.FromFile("assets/Pin.png");
            }
            else
            {
                pinButton.Image = Image.FromFile("assets/Unpin.png");
            }
            smallerButton.Image = Image.FromFile("assets/Smaller.png");
            biggerButton.Image = Image.FromFile("assets/Bigger.png");
        }

        private void OnTick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            Redraw();
            if(sec == 1)
            {
                sec--;
            }
            else if(sec == 0)
            {
                closeButton.Visible = false;
                pinButton.Visible = false;
                biggerButton.Visible = false;
                smallerButton.Visible = false;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            closeButton.Visible = true;
            pinButton.Visible = true;
            biggerButton.Visible = true;
            smallerButton.Visible = true;
            sec = 2;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            sec = 1;
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            sec = 2;
            closeButton.Image = Image.FromFile("assets/CloseOver.png");
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            sec = 1;
            closeButton.Image = Image.FromFile("assets/Close.png");
        }

        private void OnClickPin(object sender, EventArgs e)
        {
            if(pinned == false)
            {
                this.TopMost = true;
                pinned = true;
                pinButton.Image = Image.FromFile("assets/UnpinOver.png");
            }
            else
            {
                this.TopMost = false;
                pinned = false;
                pinButton.Image = Image.FromFile("assets/PinOver.png");
            }
        }

        private void OnMouseEnterPin(object sender, EventArgs e)
        {
            sec = 2;
            if(pinned == false)
            {
                pinButton.Image = Image.FromFile("assets/PinOver.png");
            }
            else
            {
                pinButton.Image = Image.FromFile("assets/UnpinOver.png");
            }
        }

        private void OnMouseLeavePin(object sender, EventArgs e)
        {
            sec = 1;
            if (pinned == false)
            {
                pinButton.Image = Image.FromFile("assets/Pin.png");
            }
            else
            {
                pinButton.Image = Image.FromFile("assets/Unpin.png");
            }
        }

        private void OnMouseDownMove(object sender, MouseEventArgs e)
        {
            xOffset = MousePosition.X - this.Left;
            yOffset = MousePosition.Y - this.Top;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = MousePosition.X - xOffset;
                this.Top = MousePosition.Y - yOffset;
            }
        }

        private void OnClickSmaller(object sender, EventArgs e)
        {
            if (clockRes > 100)
            {
                clockRes -= 50;
                g.Clear(Color.FromArgb(64, 0, 64));
                this.Left += 50;
                closeButton.Left -= 50;
                pinButton.Left -= 50;
                biggerButton.Left -= 50;
                smallerButton.Left -= 50;
                Redraw();
            }
        }

        private void OnMouseEnterSmaller(object sender, EventArgs e)
        {
            sec = 2;
            smallerButton.Image = Image.FromFile("assets/SmallerOver.png");
        }

        private void OnMouseLeaveSmaller(object sender, EventArgs e)
        {
            sec = 1;
            smallerButton.Image = Image.FromFile("assets/Smaller.png");
        }

        private void OnClickBigger(object sender, EventArgs e)
        {
            if (clockRes < 1000)
            {
                clockRes += 50;
                g.Clear(Color.FromArgb(64, 0, 64));
                this.Left -= 50;
                closeButton.Left += 50;
                pinButton.Left += 50;
                biggerButton.Left += 50;
                smallerButton.Left += 50;
                Redraw();
            }
        }

        private void OnMouseEnterBigger(object sender, EventArgs e)
        {
            sec = 2;
            biggerButton.Image = Image.FromFile("assets/BiggerOver.png");
        }

        private void OnMouseLeaveBigger(object sender, EventArgs e)
        {
            sec = 1;
            biggerButton.Image = Image.FromFile("assets/Bigger.png");
        }
    }
}
