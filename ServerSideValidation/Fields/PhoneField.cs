namespace ServerSideValidation.Fields
{
    public class PhoneField : FieldBase
    {
        public PhoneField(string input) : base(input)
        {
            Pattern = @"^((\+\d{2,3})|0?)[\s-]?((\(\d{3}\))|(\d{3}))?[\s-]?(\d[\s-]?){7}$";
            PatternError = PatternError = Global.ResourceManager.GetString("phone", Global.CultureInfo);
        }
    }
}