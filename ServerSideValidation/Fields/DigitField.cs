namespace ServerSideValidation.Fields
{
    public class DigitField : FieldBase
    {
        public DigitField(string input) : base(input)
        {
            Pattern = @"^[0-9]+$";
            PatternError = PatternError = Global.ResourceManager.GetString("digits", Global.CultureInfo);
        }
    }
}