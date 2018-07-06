using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigFiles.Admin
{
    public partial class FolderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<String> GetConfig()
        {
            foreach (var key in WebConfigurationManager.AppSettings.AllKeys)
            {
                yield return $"{key} = {WebConfigurationManager.AppSettings[key]}"; ;
            }
        }
    }
}