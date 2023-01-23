using Android.Views;

namespace MAUIAlert;

public partial class MainPage : ContentPage
{
	bool sur = false;
    bool nam = false;
    bool fut = false;
    public MainPage()
	{
		InitializeComponent();
	}
	private async void Button_Clicked(object sender, EventArgs e)
	{
        if(SurName.Text)
		TextP(SurName.Text,sur);
        TextP(Name.Text, nam);
        TextP(FuthersName.Text, fut);
    }
	public bool TextP(string q, bool s)
	{
        if (q.Length > 0 && q.Length < 11)
        {
            return s = true;
        }
        else
        {
            return s = false;
        }
    }
}

