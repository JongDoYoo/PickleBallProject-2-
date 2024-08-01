using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using PickleBallProject_2_.Model;

namespace PickleBallProject_2_.ViewModel
{
    [ObservableObject]
    public partial class MainViewModel      //must be public partial
    {
        [ObservableProperty]
        private string userName;       //property = camel
        [ObservableProperty]
        private string password;
    }
}
