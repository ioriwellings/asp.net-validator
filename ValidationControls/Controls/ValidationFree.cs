using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationFree : ValidationBase
    {
        public ValidationFree() : base(new FreeField(string.Empty))
        {
        }

        public override string JavascriptMehod
        {
            get { return string.Empty; }
        }
    }
}