using Ooui;
using Xamarin.Forms;

namespace WasmFormsEmptyApp
{
	class Program
    {
        static void Main(string[] args)
        {
			Forms.Init ();

			UI.Publish ("/", new MainPage ().GetOouiElement ());
		}
    }
}