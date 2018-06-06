using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class CityAndColor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack && this is IRequiresSessionState)
            {
                Session["color"] = Enum.Parse(typeof(Color), colorSelect.SelectedValue);
                Session["city"] = Enum.Parse(typeof(City), citySelect.SelectedValue);
            }
            if (this is IReadOnlySessionState || this is IRequiresSessionState)
            {
                colorSelect.Enabled = citySelect.Enabled = true;
                colorSelect.SelectedValue = Session["color"].ToString();
                citySelect.SelectedValue = Session["city"].ToString();
            }
            else
            {
                colorSelect.Enabled = citySelect.Enabled = false;
            }
        }

        public String[] GetColors()
        {
            return Enum.GetNames(typeof(Color));
        }

        public String[] GetCities()
        {
            return Enum.GetNames(typeof(City));
        }
    }
}