using System.Web.UI;
using System;

namespace WebForm
{
    public class CommonPageBase:Page
    {
        protected String GetDayOfWeek()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }
    }
}