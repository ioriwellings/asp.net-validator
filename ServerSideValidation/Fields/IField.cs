namespace ServerSideValidation.Fields
{
    public interface IField
    {
        #region Rules

        int MinLength { get; set; }
        int MaxLength { get; set; }
        bool Required { get; set; }
        string EqualTo { get; set; }
        string Pattern { get; set; }

        #endregion

        string Key { get; set; }
        string Value { get; set; }
        string Error { get; }
        string PatternError { get; }

        bool ValidateField();
    }
}