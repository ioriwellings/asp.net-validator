using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationDate : ValidationBase
    {
        public ValidationDate() 
            : base(new DateField(string.Empty), Global.ResourceManager.GetString("date"))
        {
        }
    }
}