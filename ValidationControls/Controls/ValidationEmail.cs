using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationEmail : ValidationBase
    {
        public ValidationEmail() 
            : base(new EmailField(string.Empty), Global.ResourceManager.GetString("email"))
        {
        }
    }
}