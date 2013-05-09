using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationPhone : ValidationBase
    {
        public ValidationPhone() 
            : base(new PhoneField(string.Empty), Global.ResourceManager.GetString("phone"))
        {
        }
    }
}