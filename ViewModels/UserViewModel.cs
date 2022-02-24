using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using test_mvvm.Messages;
using test_mvvm.Models;

namespace test_mvvm.ViewModels
{
    class UserViewModel :ViewModelBase
    {
        public UserViewModel()
        {
            UpdateCommand = new RelayCommand(UpdateCommandAction, null);
        }

        public RelayCommand UpdateCommand { get; set; }

        private void UpdateCommandAction()
        {
            var viewModelMessage = new ViewModelMessage()
            {
                Text = "Helloworld"
            };

            Messenger.Default.Send(viewModelMessage);
        }
    }
}
