namespace ServerSideValidation.RuleCheckers
{
    public class MinLengthChecker : IRuleChecker
    {
        private readonly int _minLength;
        private readonly string _value;

        public string ErrorDescription { get; set; }

        public MinLengthChecker(string value, int minLength)
        {
            _value = value;
            _minLength = minLength;
            ErrorDescription = Global.ResourceManager.GetString("minLength", Global.CultureInfo);
        }

        public bool Check()
        {
            if (_minLength > 0 && !string.IsNullOrEmpty(_value))
            {
                return _value.Length >= _minLength;
            }
            return true;
        } 
    }
}