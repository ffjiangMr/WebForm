using System;

namespace WebForm
{
    public partial class Default : CommonPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mySpan.InnerText = Server.HtmlEncode("Hello World.");           
        }

        public String GetCity()
        {
            String[] cities = { "London", "New Year", "Paries" };
            //String str = @"<input id='password'/><button type='submit'>Submit</button>";
            return (cities[new Random(DateTime.Now.GetHashCode()).Next(cities.Length)]);//cities[new Random().Next(cities.Length)];
        }
    }
}