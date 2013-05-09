using System.Reflection;
using System.Resources;

namespace ValidationControls
{
    public static class Global
    {
        private static readonly ResourceManager _resourceManager = new ResourceManager(typeof(Global).Namespace + ".Resources.CssClasses", Assembly.GetExecutingAssembly());
        public static ResourceManager ResourceManager
        {
            get { return _resourceManager; }
        }
    }
}