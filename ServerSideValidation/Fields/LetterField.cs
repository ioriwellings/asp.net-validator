namespace ServerSideValidation.Fields
{
    public class LetterField : FieldBase
    {
        public LetterField(string input) : base(input)
        {
            Pattern = @"^[a-zA-Z\sçğıöşüâîûéèäßèİÇĞİÖŞÜ]+$";
            PatternError = PatternError = Global.ResourceManager.GetString("letter", Global.CultureInfo);
        }
    }
}