namespace ServerSideValidation.Fields
{
    public class UrlField : FieldBase
    {
        public UrlField(string input) : base(input)
        {
            Pattern = @"^(http(s)?:\/\/)?([a-zA-Z0-9\%\-\_\?\.]+\.)+[a-zA-Z0-9\%\-\?\=\/\.]+$";
            PatternError = PatternError = Global.ResourceManager.GetString("url", Global.CultureInfo);
        }
    }
}