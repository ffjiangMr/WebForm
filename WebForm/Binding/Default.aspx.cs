using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Web.ModelBinding;

namespace Binding
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GetPerson();
                if (!ModelState.IsValid)
                {
                    DisplayPerson(GetPerson());
                }
                //errorPanel.Visible = ModelState.IsValid;
            }
        }

        protected Person GetPerson()
        {
            Person model = new Person();
            IValueProvider provider = new FormValueProvider(ModelBindingExecutionContext);
            TryUpdateModel<Person>(model, provider);
            return model;
            //String nameFormValue = Request.Form["name"];
            //if (String.IsNullOrEmpty(nameFormValue))
            //{
            //    throw new FormatException("Please provide your name");
            //}
            //else if (nameFormValue.Length < 3 || nameFormValue.Length > 20)
            //{
            //    throw new FormatException("Your name must be 3-20 characters");
            //}
            //else if (!Regex.IsMatch(nameFormValue, @"^[A-Za-z\s]+$"))
            //{
            //    throw new FormatException("Your name can only contain letters and spaces");
            //}
            //else
            //{
            //    model.Name = Request.Form["name"];
            //}
            //model.Age = Int32.Parse(Request.Form["age"]);
            //model.Cell = Request.Form["cell"];
            //model.Zip = Request.Form["zip"];
            //return model;
        }

        protected void DisplayPerson(Person person)
        {
            sname.InnerText = person.Name;
            sage.InnerText = person.Age.ToString();
            scell.InnerText = person.Cell;
            szip.InnerText = person.Zip;
        }

        public IEnumerable<String> GetModelValidationErrors()
        {
            if (ModelState.IsValid)
            {
                foreach (KeyValuePair<String, ModelState> pair in ModelState)
                {
                    foreach (ModelError error in pair.Value.Errors)
                    {
                        if (!String.IsNullOrEmpty(error.ErrorMessage))
                        {
                            yield return error.ErrorMessage;
                        }
                    }
                }
            }
        }
    }
}