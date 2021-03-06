using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_mvvm.Messages;

namespace test_mvvm.ViewModel
{
    public class ReceiverViewModel : ViewModelBase
    {
        private string _contentText;

        public string ContentText
        {
            get { return _contentText; }
            set
            {
                _contentText = value;
                RaisePropertyChanged("ContentText");
            }
        }

        public ReceiverViewModel()
        {
            OnClickCommand = new RelayCommand(OnClickCommandAction, null);
            Messenger.Default.Register<ViewModelMessage>(this, OnReceiveMessageAction);
        }

        private void OnReceiveMessageAction(ViewModelMessage obj)
        {
            ContentText = obj.Text;
        }

        public RelayCommand OnClickCommand { get; set; }
        private void OnClickCommandAction()
        {
        }
    }
}
