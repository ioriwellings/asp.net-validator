using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ServerSideValidation
{
    public static class Global
    {
        private static CultureInfo _cultureInfo = new CultureInfo("en-US");
        public static CultureInfo CultureInfo
        {
            get { return _cultureInfo; }
            set
            {
                if (value != null)
                    _cultureInfo = value;
            }
        }

        private static readonly ResourceManager _resourceManager = new ResourceManager(typeof(Global).Namespace + ".Resources.Messages", Assembly.GetExecutingAssembly());
        public static ResourceManager ResourceManager
        {
            get { return _resourceManager; }
        }
    }
}