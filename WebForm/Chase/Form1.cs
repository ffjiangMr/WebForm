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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var point = new Point();
            var flag = true;
            while (flag)
            {
                flag = false;
                point.X = new Random((Int32)DateTime.Now.Ticks).Next(this.panel1.Width - this.button1.Width);
                point.Y = new Random((Int32)DateTime.Now.Ticks).Next(this.panel1.Height - this.button1.Height);
                var absX = Math.Abs(point.X - this.button1.Location.X);
                var absY = Math.Abs(point.Y - this.button1.Location.Y);
                if ((absX < this.button1.Width) && (absY < this.button1.Height))
                {
                    flag = true;
                }
                else
                {
                    this.button1.Location = point;
                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("给你追上了！");
        }
    }
}
