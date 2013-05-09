using System.Globalization;
using System.Resources;

namespace ServerSideValidation.Fields
{
    public class AlphanumericField : FieldBase
    {
        public AlphanumericField(string input) : base(input)
        {
            Pattern = @"^\w+$";
            PatternError = Global.ResourceManager.GetString("alphanumeric", Global.CultureInfo);
        }
    }
}