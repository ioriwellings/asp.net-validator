using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationFloat : ValidationBase
    {
        public ValidationFloat()
            : base(new FloatField(string.Empty), Global.ResourceManager.GetString("float"))
        {
        }
    }
}