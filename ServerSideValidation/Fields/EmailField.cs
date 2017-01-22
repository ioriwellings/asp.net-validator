namespace ServerSideValidation.Fields
{
    public class EmailField : FieldBase
    {
        public EmailField(string input) : base(input)
        {
            // ref: http://emailregex.com/
            Pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9A-Za-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9A-Za-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9A-Za-z][-\w]*[0-9A-Za-z]*\.)+[A-Za-z0-9][\-A-Za-z0-9]{0,22}[A-Za-z0-9]))$";
            PatternError = PatternError = Global.ResourceManager.GetString("email", Global.CultureInfo);
        }
    }
}