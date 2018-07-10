using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Web;

namespace ConfigFiles
{
    public class NewUserDefaultsSection : ConfigurationSection
    {
        [ConfigurationProperty("city", IsRequired = true)]
        [CallbackValidator(CallbackMethodName = "ValidateCity", Type = typeof(NewUserDefaultsSection))]
        public String City
        {
            get { return (String)this["city"]; }
            set { this["city"] = value; }
        }

        [ConfigurationProperty("country", DefaultValue = "USA")]
        public String Country
        {
            get { return (String)this["country"]; }
            set { this["country"] = value; }
        }

        [ConfigurationProperty("language")]
        public String Language
        {
            get { return (String)this["language"]; }
            set { this["language"] = value; }
        }

        [ConfigurationProperty("regionCode")]
        [IntegerValidator(MaxValue = 5, MinValue = 0)]
        public Int32 RegionCode
        {
            get { return (Int32)this["regionCode"]; }
            set { this["regionCode"] = value; }
        }

        public static void ValidateCity(Object candidateValue)
        {
            String value = (String)candidateValue;
            if (value.ToLower() == "paris")
            {
                throw new Exception("City cannot be paris");
            }
        }
    }
}