using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WasmFormsEmptyApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}