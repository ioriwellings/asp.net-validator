﻿namespace ServerSideValidation.Fields
{
    public class UrlField : FieldBase
    {
        public UrlField(string input) : base(input)
        {
            Pattern = @"^(http(s)?:\/\/)?([a-zA-Z0-9_\%\-\?\.]+\.)+[a-zA-Z0-9_\%\-\?\=\/\.]+$";
            PatternError = PatternError = Global.ResourceManager.GetString("url", Global.CultureInfo);
        }
    }
}