using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Regitration.ViewModels;

namespace Regitration.CustomAttributes
{
    public class AtLeastOneAreaSelectedAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = value as List<BusinessArea>;
            return list != null && list.Any(x => x.IsChecked);
        }
    }
}