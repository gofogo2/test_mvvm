using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using test_mvvm.Messages;

namespace test_mvvm.ViewModel
{
    public class SenderViewModel : ViewModelBase
    {
        public SenderViewModel()
        {
            OnClickCommand = new RelayCommand(OnClickCommandAction, null);
            OnTextChangedCommand = new RelayCommand<string>((msg)=> OnTextChangedCommandAction(msg), null);
        }

        private string _textBoxText;

        public string TextBoxText
        {
            get { return _textBoxText; }
            set
            {
                _textBoxText = value;
                RaisePropertyChanged("TextBoxText");
            }
        }

        

        public RelayCommand<string> OnTextChangedCommand { get; set; }
        
        private void OnTextChangedCommandAction(string msg)
        {
            MessageBox.Show(TextBoxText);
        }

        public RelayCommand OnClickCommand { get; set; }
        private void OnClickCommandAction()
        {
            if (IsInDesignMode)
            {

            }
            else
            {

            }
            var viewModelMessage = new ViewModelMessage()
            {
                Text = TextBoxText
            };

            Messenger.Default.Send(viewModelMessage);
        }
    }
}
