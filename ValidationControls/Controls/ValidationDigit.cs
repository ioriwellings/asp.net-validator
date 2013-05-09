using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationDigit : ValidationBase
    {
        public ValidationDigit() 
            : base(new DigitField(string.Empty), Global.ResourceManager.GetString("digits"))
        {
        }
    }
}