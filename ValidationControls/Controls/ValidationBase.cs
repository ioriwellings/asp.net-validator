using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    [ToolboxData(@"<{0}:ValidationField Text="""" runat=""server"" />")]
    public abstract class ValidationBase : TextBox, IField
    {
        private readonly IField _field;
        private readonly string _patternClass;
        protected ValidationBase(IField field)
        {
            _field = field;
        }
        protected ValidationBase(IField field, string patternClass)
        {
            _field = field;
            _patternClass = patternClass;
        }

        public int MinLength
        {
            get { return _field.MinLength; }
            set { _field.MinLength = value; }
        }
        public override int MaxLength
        {
            get { return _field.MaxLength; } 
            set { _field.MaxLength = value; }
        }
        public bool Required
        {
            get { return _field.Required; }
            set { _field.Required = value; }
        }
        public string EqualTo
        {
            get { return _field.EqualTo; }
            set { _field.EqualTo = value; }
        }
        public string Pattern
        {
            get { return _field.Pattern; }
            set { _field.Pattern = value; }
        }

        public string Key
        {
            get { return _field.Key; }
            set { _field.Key = value; }
        }
        public string Value
        {
            get { return Text; }
            set { Text = value; }
        }
        public string Error { get { return _field.Error; } }
        public string PatternError { get { return _field.PatternError; } }

        public virtual string JavascriptMehod
        {
            get
            {
                return string.Format(
                    @"$.validator.addMethod('{0}', function (value, element) {{var regex = new RegExp(/{1}/);return this.optional(element) || regex.test(value);}}, '{2}');",
                    _patternClass, Pattern, PatternError);
            }
        }

        public bool ValidateField()
        {
            _field.Value = Value;
            return _field.ValidateField();
        }

        private List<string> GetClasses(string value)
        {
            return string.IsNullOrEmpty(value) ? new List<string>() : value.Split(' ').ToList();
        }

        protected override void OnPreRender(EventArgs e)
        {
            var classList = GetClasses(base.CssClass);
            if (_field.Required && !classList.Contains("required"))
                classList.Add("required");
            if (!string.IsNullOrEmpty(_patternClass) && !classList.Contains(_patternClass))
                classList.Add(_patternClass);
            base.CssClass = string.Join(" ", classList.ToArray());

            if (_field.MinLength > 0)
                Attributes.Add("minlength", _field.MinLength.ToString());

            base.OnPreRender(e);
        }
    }
}