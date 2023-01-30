namespace StyleIssue;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

}
public class CustomEntry : Entry
{
	public CustomEntry()
	{
		if(this.BackgroundColor==null)
		{
			this.BackgroundColor = Colors.Red;
		}
	}


}


