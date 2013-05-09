namespace ServerSideValidation.Fields
{
    public class EmailField : FieldBase
    {
        public EmailField(string input) : base(input)
        {
            Pattern = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]+)$";
            PatternError = PatternError = Global.ResourceManager.GetString("email", Global.CultureInfo);
        }
    }
}