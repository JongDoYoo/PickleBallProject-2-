namespace PickleBallProject_2_.ViewModel;

public partial class HomePageViewModel : ContentPage
{


    private HomePageViewModel vm = new HomePageViewModel();

    public HomePageViewModel()
	{
		InitializeComponent();
		
		BindingContext = vm;
	}
}