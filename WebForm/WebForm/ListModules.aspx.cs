using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{

    public class ModuleDescription
    {
        public String Name { get; set; }
        public String TypeName { get; set; }
    }

    public partial class ListModules : System.Web.UI.Page
    {

        public IEnumerable<ModuleDescription> GetModules()
        {
            HttpModuleCollection modules = this.Context.ApplicationInstance.Modules;
            foreach (var item in modules.AllKeys.OrderBy(m=>m))
            {
                yield return new ModuleDescription()
                {
                    Name = item,            
                    TypeName = modules[item].GetType().ToString()
                };
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}