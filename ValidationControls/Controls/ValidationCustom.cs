using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationCustom : ValidationBase
    {
        public ValidationCustom()
            : base(new CustomField(@".*", string.Empty), Global.ResourceManager.GetString("custom"))
        {
        }
    }
}