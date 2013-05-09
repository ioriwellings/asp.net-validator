using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationNoTag : ValidationBase
    {
        public ValidationNoTag() 
            : base(new NoTagField(string.Empty), Global.ResourceManager.GetString("notag"))
        {
        }

        public override string JavascriptMehod
        {
            get
            {
                return string.Format(
                    @"$.validator.addMethod('{0}', function (value, element) {{var regex = new RegExp(/{1}/);return this.optional(element) || !regex.test(value);}}, '{2}');",
                    "notag", Pattern, PatternError);
            }
        }
    }
}