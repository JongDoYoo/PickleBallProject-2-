using PickleBallProject_2_.Model;
using PickleBallProject_2_.ViewModel;

namespace PickleBallProject_2_.View;

public partial class HomePage : ContentPage
{
    
	public HomePage()
	{
		InitializeComponent();

	}
    private async void PlayGameClicked(object sender, EventArgs e)
    {
        StatsNum.Text = string.Empty;
        MatchNum.Text = string.Empty;
        DUPRNum.Text = string.Empty;

        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        Match match = new Match(player1, player2);

        match.Playmatch();
        
    }
   
    private async void FaqClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FAQ());
    }
}