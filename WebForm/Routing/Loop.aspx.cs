using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing
{
    public partial class Loop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Int32> GetValues([RouteData("count")] Int32? count)
        {
            for (Int32 i = 0; i < (count ?? 3); i++)
            {
                yield return i;
            }
        }
    }
}