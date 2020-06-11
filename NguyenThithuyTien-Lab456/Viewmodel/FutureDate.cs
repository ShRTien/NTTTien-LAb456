using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace NguyenThithuyTien_Lab456.Viewmodel
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime datetime;
            var isValid= DateTime.TryParseExact(Convert.ToString(value),"dd/m/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out datetime);
            return (isValid && datetime > DateTime.Now);
        }
    }
}