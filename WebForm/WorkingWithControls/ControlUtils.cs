using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls
{
    public class ControlUtils
    {
        public static void EnumerateControls(Control target, Boolean ignorel = false)
        {
            foreach (Control c in target.Controls.Cast<Control>())
            {
                if (!(c is LiteralControl) || !ignorel)
                {
                    Debug.WriteLine($"Control ID:{c.ID},Type:{c.GetType().Name} ,Parent:{target.ID}");
                    if (c.Controls.Count > 0)
                    {
                        EnumerateControls(c, ignorel);
                    }
                }
            }
        }

        public static void AddButtonClickHandler(Control target)
        {
            foreach (Control c in target.Controls.Cast<Control>())
            {
                if (c is Button)
                {
                    Button b = c as Button;
                    b.Text += " (+)";
                    b.Click += (src, args) =>
                    {
                        Debug.WriteLine("Button Clicked: " + b.Text);
                    };
                }
                else if (c.Controls.Count > 0)
                {
                    AddButtonClickHandler(c);
                }
            }
        }
    }
}