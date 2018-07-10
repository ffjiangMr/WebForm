using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class Place : ConfigurationElement
    {
        [ConfigurationProperty("code", IsRequired = true)]
        public String Code { get { return (String)this["code"]; } set { this["code"] = value; } }

        [ConfigurationProperty("city", IsRequired = true)]
        public String City { get { return (String)this["city"]; } set { this["city"] = value; } }

        [ConfigurationProperty("counrty", IsRequired = true)]
        public String Country { get { return (String)this["counrty"]; } set { this["counrty"] = value; } }
    }
}