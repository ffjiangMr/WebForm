using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class PlaceSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(PlaceCollection))]
        public PlaceCollection Places
        {
            get { return (PlaceCollection)base[""]; }
        }

        [ConfigurationProperty("default")]
        public String Default
        {
            get { return (String)base["default"]; }
            set { base["default"] = value; }
        }
    }
}