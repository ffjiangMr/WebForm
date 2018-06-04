using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_MouseEnter(object sender, EventArgs e)
        //{
        //    var point = new Point();
        //    var flag = true;
        //    while (flag)
        //    {
        //        flag = false;
        //        point.X = new Random((Int32)DateTime.Now.Ticks).Next(this.panel1.Width - this.button1.Width);
        //        point.Y = new Random((Int32)DateTime.Now.Ticks).Next(this.panel1.Height - this.button1.Height);
        //        var absX = Math.Abs(point.X - this.button1.Location.X);
        //        var absY = Math.Abs(point.Y - this.button1.Location.Y);
        //        if ((absX < this.button1.Width) && (absY < this.button1.Height))
        //        {
        //            flag = true;
        //        }
        //        else
        //        {
        //            this.button1.Location = point;
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "好")
            {
                this.button1.Text = "不好";
                this.button2.Text = "好";
            }
            else
            {
                this.button1.Text = "好";
                this.button2.Text = "不好";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "好")
            {
                this.button2.Text = "不好";
                this.button1.Text = "好";
            }
            else
            {
                this.button2.Text = "好";
                this.button1.Text = "不好";
            }
        }

        //private void MouseEnter(Object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    if (btn != null)
        //    {
        //        if (btn.Text == "好")
        //        {
        //            btn.Text = "不好";
        //        }
        //        else
        //        {
        //            btn.Text = "好";
        //        }
        //    }
        //}

        private void MouseClick(Object sender, EventArgs args)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (btn.Text == "好")
                {
                    MessageBox.Show("恭喜成为我的女朋友!");
                }
                else
                {
                    MessageBox.Show("再考虑考虑🤔");
                }
            }
        }
    }
}
