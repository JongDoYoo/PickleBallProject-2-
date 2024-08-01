using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PickleBallProject_2_.ViewModel;

namespace PickleBallProject_2_.View
{
    public partial class MainPage : ContentPage
    {


        //private MainViewModel vm = new MainViewModel();  //binds to mainviewmodel  

        public MainPage()
        {
            InitializeComponent();

            //BindingContext = vm;            
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string enteredEmail = Username.Text;
            string enteredPassword = Password.Text;

            var user = await App.Database.LoginUserAsync(enteredEmail, enteredPassword);
            if (user != null)
            {
                await Navigation.PushAsync(new HomePage());
                LogInText.Text = "Please log in below!";
            }
            else
            {
                LogInText.Text = "You entered the wrong Username or Password!!";
                await DisplayAlert(LogInText.Text, StyleId, "Please try again!");

            }
        }
        private async void RegisterButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        void OnCheckBoxCheckChanged(object sender, CheckedChangedEventArgs e)
        {
            Password.IsPassword = !Password.IsPassword;
        }

    }

}
