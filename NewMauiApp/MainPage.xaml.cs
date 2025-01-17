namespace NewMauiApp
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}


		private void MauiClicked(object sender, EventArgs e)
		{
			MauiLabel.Text = MyClassLib.MyClass.Now().ToString();
		}

		private void StandardClicked(object sender, EventArgs e)
		{
			StandardLabel.Text = MyStandardLib.MyClass.Now().ToString();
		}
	}

}
