namespace ServerSideValidation.Fields
{
    public class AlphanumericField : FieldBase
    {
        public AlphanumericField(string input) : base(input)
        {
            Pattern = @"^[a-zA-Z0-9\sçğıöşüâîûéèäßèİÇĞİÖŞÜ]+$";
            PatternError = Global.ResourceManager.GetString("alphanumeric", Global.CultureInfo);
        }
    }
}