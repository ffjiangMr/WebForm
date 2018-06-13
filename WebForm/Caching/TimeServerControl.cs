using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    [PartialCaching(60, VaryByParams = "none", Shared = true)]
    public class TimeServerControl : WebControl
    {
    }
}