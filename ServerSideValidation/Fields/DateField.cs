namespace ServerSideValidation.Fields
{
    public class DateField : FieldBase
    {
        /**
        * Day.Month.Year, Month.Day.Year, Year.Month.Day
        * Year -> yy or yyyy
        * Separator ->  "-" or "/" or "."
        * */

        const string Day = @"([1-31]|(0[1-9]|[1-2]\d|3[0-1]))";
        const string Month = @"([1-12]|(0[1-9]|1[0-2]))";
        const string Year = @"(\d\d|\d\d\d\d)";
        const string Separator = @"[-/\.]";

        public DateField(string input) : base(input)
        {
            Pattern = @"^((" + Day + Separator + Month + "|" + Month + Separator + Day + ")" + Separator + Year + "|" + Year + Separator + Month + Separator + Day + ")$";
            PatternError = Global.ResourceManager.GetString("date", Global.CultureInfo);
        }
    }
}