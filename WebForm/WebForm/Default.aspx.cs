using System;
using System.Web.SessionState;
using System.Web.UI;

namespace WebForm
{
    public partial class Default : CommonPageBase, IRequiresSessionState
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    mySpan.InnerText = Server.HtmlEncode("Hello World.");           
        //}

        public String GetCity()
        {
            String[] cities = { "London", "New Year", "Paries" };
            //String str = @"<input id='password'/><button type='submit'>Submit</button>";
            return (cities[new Random(DateTime.Now.GetHashCode()).Next(cities.Length)]);//cities[new Random().Next(cities.Length)];
        }

        protected void Page_PreInit(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "PreInit");
        }

        protected void Page_Init(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "Init");
        }

        protected void Page_PreLoad(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "PreLoad");
        }

        protected void Page_Load(Object src, EventArgs args)
        {
            mySpan.InnerText = Server.HtmlEncode("Hello World.");
            EventCollection.Add(EventSource.Page, "Load");
        }

        protected void Page_LoadComplete(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "LoadComplete");
        }

        protected void Page_InitComplete(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "InitComplete");
            //counter.Count += (sender, eventArgs) =>
            //{
            //    EventCollection.Add(EventSource.Page, String.Format($"Control - Counter : {eventArgs.Counter}"));
            //};
        }

        protected void Page_PreRender(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "PreRender");
        }

        protected void Page_PreRenderComplete(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "PreRenderComplete");
        }

        protected void Page_SaveStateComplete(Object src, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "SaveStateComplete");
        }

        protected override void Render(HtmlTextWriter writer)
        {
            EventCollection.Add(EventSource.Page, "Render");
            base.Render(writer);
        }

        protected void Page_Unload(Object sender, EventArgs args)
        {
            EventCollection.Add(EventSource.Page, "Unload");
        }

        protected void HandleEvent(Object sender, ViewCounterEventArgs args)
        {
            EventCollection.Add( EventSource.Page,String.Format($"Control - Counter : {args.Counter}"));
        }        

    }
}