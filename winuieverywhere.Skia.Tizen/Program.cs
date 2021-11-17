using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace winuieverywhere.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new winuieverywhere.App(), args);
		host.Run();
	}
}
}
