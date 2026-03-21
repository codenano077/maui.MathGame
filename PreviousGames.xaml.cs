using Maui.MathGame.Models;
namespace Maui.MathGame;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();
		gamesList.ItemsSource= App.GameRepo?.GetAllGames();
	}
	
	private void OnDelete(object sender, EventArgs e)
	{
		ImageButton button = (ImageButton)sender;

		App.GameRepo?.Delete((int)button.BindingContext);

		gamesList.ItemsSource = App.GameRepo?.GetAllGames();
    }
}