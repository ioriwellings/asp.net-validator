using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationAlphanumeric : ValidationBase
    {
        public ValidationAlphanumeric() 
            : base(new AlphanumericField(string.Empty), Global.ResourceManager.GetString("alphanumeric"))
        {
        }
    }
}