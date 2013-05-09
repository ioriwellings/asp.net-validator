namespace ServerSideValidation.Fields
{
    public class UrlFriendlyField : FieldBase
    {
        public UrlFriendlyField(string input) : base(input)
        {
            Pattern = @"^[a-zA-Z0-9\-\%\?\=\/\.]+$";
            PatternError = Global.ResourceManager.GetString("urlFriendly", Global.CultureInfo);
        }
    }
}