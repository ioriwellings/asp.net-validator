namespace ServerSideValidation.Fields
{
    public class FloatField : FieldBase
    {
        public FloatField(string input) : base(input)
        {
            switch (Global.CultureInfo.ToString())
            {
                case "tr-TR":
                    Pattern = @"^[-+]?[0-9]*\,?[0-9]+$";
                    break;
                case "en-US":
                default:
                    Pattern = @"^[-+]?[0-9]*\.?[0-9]+$";
                    break;
            }
            
            PatternError = Global.ResourceManager.GetString("float", Global.CultureInfo);
        }
    }
}