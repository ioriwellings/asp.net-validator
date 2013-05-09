using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationUrl : ValidationBase
    {
        public ValidationUrl() 
            : base(new UrlField(string.Empty), Global.ResourceManager.GetString("url"))
        {
        }
    }
}