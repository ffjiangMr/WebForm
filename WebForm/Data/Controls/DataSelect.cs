using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Data.Controls
{
    public class DataSelect:DataBoundControl
    {
        private String[] dataArray;

        public DataSelect()
        {
            Init += (src, args) => { };
        }
    }
}