using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ULSAApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ULSAApp.App(), args);
            host.Run();
        }
    }
}
