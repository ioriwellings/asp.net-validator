namespace ServerSideValidation.RuleCheckers
{
    public class MaxLengthChecker : IRuleChecker
    {
        private readonly int _maxLength;
        private readonly string _value;

        public string ErrorDescription { get; set; }

        public MaxLengthChecker(string value, int maxLength)
        {
            _value = value;
            _maxLength = maxLength;
            ErrorDescription = Global.ResourceManager.GetString("maxLength", Global.CultureInfo);
        }

        public bool Check()
        {
            if (_maxLength > 0 && !string.IsNullOrEmpty(_value))
            {
                return _value.Length <= _maxLength;
            }
            return true;
        }
    }
}