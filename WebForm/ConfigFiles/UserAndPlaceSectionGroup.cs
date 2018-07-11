using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class UserAndPlaceSectionGroup : ConfigurationSectionGroup
    {
        [ConfigurationProperty("newUserDefaults")]
        public NewUserDefaultsSection NewUserDefaults
        {
            get { return (NewUserDefaultsSection)Sections["newUserDefaults"]; }
        }

        [ConfigurationProperty("places")]
        public PlaceSection Places
        {
            get { return (PlaceSection)Sections["places"]; }
        }
    }
}