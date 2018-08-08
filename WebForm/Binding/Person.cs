using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Binding
{
    public class Person
    {
        [Required(ErrorMessage = "You must enter your name")]
        [StringLength(20, ErrorMessage = "Names are 3-20 characters", MinimumLength = 3)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Names are alpha characters")]
        public String Name { get; set; }

        [Required(ErrorMessage = "You must enter your age")]
        [Range(5, 100, ErrorMessage = "Age are 5-100")]
        public Int32 Age { get; set; }
        public String Cell { get; set; }
        [CustomValidation(typeof(Binding.CustomChecks),"CheckZip")]
        public String Zip { get; set; }
    }
}