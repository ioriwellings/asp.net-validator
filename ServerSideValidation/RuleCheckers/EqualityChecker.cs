namespace ServerSideValidation.RuleCheckers
{
    public class EqualityChecker : IRuleChecker
    {
        private readonly string _equal;
        private readonly string _value;

        public string ErrorDescription { get; set; }

        public EqualityChecker(string value, string equal)
        {
            _value = value;
            _equal = equal;
            ErrorDescription = Global.ResourceManager.GetString("equal", Global.CultureInfo);
        }
        
        public bool Check()
        {
            return string.IsNullOrEmpty(_value) || string.IsNullOrEmpty(_equal) || _value.Equals(_equal);
        } 
    }
}