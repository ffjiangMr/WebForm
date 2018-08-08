using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Binding
{
    public class CustomChecks
    {
        public static ValidationResult CheckZip(String zipCode)
        {
            return (zipCode != null) && (zipCode.ToLower().StartsWith("ny")) ?
                   ValidationResult.Success :
                   new ValidationResult("Enter a NY zip code");
        }
    }
}