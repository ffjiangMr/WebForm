using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigFiles
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<String> GetConfig()
        {
            Object configObject = WebConfigurationManager.GetWebApplicationSection("system.web/compilation");
            CompilationSection sectionHandler = configObject as CompilationSection;
            if (sectionHandler != null)
            {
                yield return $"Debug = {sectionHandler.Debug}";
                yield return $"targetFramework = {sectionHandler.TargetFramework}";
                yield return $"batch = {sectionHandler.Batch}";                
            }
            else
            {
                yield return $"Unexpected object type:{configObject.GetType()}";
            }
            //String csName = WebConfigurationManager.AppSettings["dbConnectionString"];
            //ConnectionStringSettings conString = WebConfigurationManager.ConnectionStrings[csName];
            //DbConnection dbConnect = DbProviderFactories.GetFactory(conString.ProviderName).CreateConnection();
            //dbConnect.ConnectionString = conString.ConnectionString;
            //dbConnect.Open();
            //DbCommand dbCommand = dbConnect.CreateCommand();
            //dbCommand.CommandText = "select UserName from Users";
            //dbCommand.CommandType = System.Data.CommandType.Text;
            //DbDataReader reader = dbCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    yield return reader[0].ToString();
            //}
            //dbConnect.Close();
            //foreach (ConnectionStringSettings connect in WebConfigurationManager.ConnectionStrings)
            //{
            //    yield return $"name:{connect.Name},connectionString:{connect.ConnectionString}";
            //}
            //foreach (var key in WebConfigurationManager.AppSettings.AllKeys)
            //{
            //    yield return $"{key} = {WebConfigurationManager.AppSettings[key]}";
            //}
            // yield return "This is a placeholder.";
        }
    }
}