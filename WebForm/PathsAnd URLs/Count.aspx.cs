using Microsoft.AspNet.FriendlyUrls.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PathsAnd_URLs
{
    public partial class Count : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Int32> GetNumbers([FriendlyUrlSegments(0)] Int32? max)        
        {
            for (Int32 i = 0; i < (max ?? 5); i++)
            {
                yield return i;
            }
        }

    }
}