using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace VerbuvoTools.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new VerbuvoTools.App(), args);
            host.Run();
        }
    }
}
