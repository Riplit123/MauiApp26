namespace MauiApp26;

public partial class AppKvantumsPage : ContentPage
{
	public AppKvantumsPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AppItPage());
    }

    private  async void Button_Clicked_1(object sender, EventArgs e)
    {
       await Navigation.PopModalAsync();
    }
}