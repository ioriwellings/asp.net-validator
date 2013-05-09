using System;

namespace ServerSideValidation.RuleCheckers
{
    public class PatternChecker : IRuleChecker
    {
        private readonly Func<string, bool> _isMatchFunc;
        private readonly string _value;

        public string ErrorDescription { get; set; }

        public PatternChecker(string value, Func<string, bool> isMatchFunc)
        {
            _value = value;
            _isMatchFunc = isMatchFunc;
            ErrorDescription = Global.ResourceManager.GetString("custom", Global.CultureInfo);
        }

        public bool Check()
        {
            return string.IsNullOrEmpty(_value) || _isMatchFunc(_value);
        }
    }
}