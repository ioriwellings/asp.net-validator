namespace ServerSideValidation.RuleCheckers
{
    public class RequiredChecker : IRuleChecker
    {
        private readonly bool _isRequired;
        private readonly string _value;

        public string ErrorDescription { get; set; }

        public RequiredChecker(string value, bool isRequired)
        {
            _value = value;
            _isRequired = isRequired;
            ErrorDescription = Global.ResourceManager.GetString("required", Global.CultureInfo);
        }

        public bool Check()
        {
            return !_isRequired || !string.IsNullOrEmpty(_value);
        }
    }
}