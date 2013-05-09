namespace ServerSideValidation.Fields
{
    public class CustomField : FieldBase
    {
        public CustomField(string pattern, string input) : base(input)
        {
            Pattern = pattern;
            PatternError = PatternError = Global.ResourceManager.GetString("custom", Global.CultureInfo);
        }
    }
}