namespace ServerSideValidation.Fields
{
    public class NoTagField : FieldBase
    {
        public NoTagField(string input) : base(input)
        {
            // ref=http://www.regular-expressions.info/examples.html
            Pattern = @"<([a-zA-Z][a-zA-Z0-9]*)\b[^>]*>(.*?)<\/\1>";
            PatternError = PatternError = Global.ResourceManager.GetString("noTag", Global.CultureInfo);
        }

        protected override bool IsMatch(string input)
        {
            return !base.IsMatch(input);
        }
    }
}