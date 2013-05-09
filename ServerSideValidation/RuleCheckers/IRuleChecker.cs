namespace ServerSideValidation.RuleCheckers
{
    public interface IRuleChecker
    {
        string ErrorDescription { get; set; }
        bool Check();
    }
}