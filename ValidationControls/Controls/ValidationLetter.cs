using ServerSideValidation.Fields;

namespace ValidationControls.Controls
{
    public class ValidationLetter : ValidationBase
    {
        public ValidationLetter() 
            : base(new LetterField(string.Empty), Global.ResourceManager.GetString("letter"))
        {
        }
    }
}