using System.Collections.Generic;
using System.Text.RegularExpressions;
using ServerSideValidation.RuleCheckers;

namespace ServerSideValidation.Fields
{
    public abstract class FieldBase : IField
    {
        private string _pattern = @"^.*$";
        private string _patternError = "Geçersiz format";

        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public bool Required { get; set; }
        public string EqualTo { get; set; }
        public string Pattern
        {
            get { return _pattern; } 
            set { _pattern = value; }
        }

        public string Key { get; set; }
        public string Value { get; set; }
        public string Error { get; private set; }
        public string PatternError
        {
            get { return _patternError; }
            set { _patternError = value; }
        }

        protected FieldBase(string input)
        {
            Value = input;
        }

        protected virtual bool IsMatch(string input)
        {
            return Regex.IsMatch(input, Pattern);
        }

        public bool ValidateField()
        {
            var rules = new List<IRuleChecker>
                            {
                                new RequiredChecker(Value, Required),
                                new MaxLengthChecker(Value, MaxLength),
                                new MinLengthChecker(Value, MinLength),
                                new PatternChecker(Value, IsMatch){ErrorDescription = PatternError},
                                new EqualityChecker(Value, EqualTo)
                            };

            foreach (var rule in rules)
            {
                if (!rule.Check())
                {
                    Error = rule.ErrorDescription;
                    return false;
                }
            }

            return true;
        }
    }
}