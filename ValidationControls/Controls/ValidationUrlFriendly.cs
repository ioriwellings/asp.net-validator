using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationUrlFriendly : ValidationBase
    {
        public ValidationUrlFriendly()
            : base(new UrlFriendlyField(string.Empty), Global.ResourceManager.GetString("urlFriendly"))
        {
        }
    }
}