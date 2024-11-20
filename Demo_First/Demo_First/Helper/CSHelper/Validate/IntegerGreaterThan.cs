using Demo_First.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Demo_First
{
    public class IntegerGreaterThan : System.Windows.Controls.ValidationRule
    {
        private int _Value = 0;

        public int Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        private string message = "";
        public IntegerGreaterThan()
        { }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            message = MngLanguage.GetNameFromCurrentResource(() => Resources_ja_JP.GEN_InputRequireIntegerAndGreaterEqualValue);
            message = string.Format(message, value.ToString());
            try
            {
                int output = 0;
                bool check = int.TryParse((string)value, out output);
                if (check && output >= Value && string.IsNullOrEmpty((string)value) == false)
                {
                    return ValidationResult.ValidResult;
                }
                else
                {
                    return new ValidationResult(false, message);
                }
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, ex.Message);
            }
        }
    }
}
