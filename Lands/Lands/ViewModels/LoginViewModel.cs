using System;
using System.Collections.Generic;
using System.Text;
namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        #region Properties
        public string Email
        {
            get; set;
        }

        public string Paswoord
        {
            get; set;
        }

        public bool IsRunning
        {
            get; set;
        }

        public bool IsRemembered
        {
            get; set;
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "You must enter an email.", 
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Paswoord))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or paswoord incorrect",
                    "Accept");
                return;
            }

            if (this.Email != "yeit_20@hotmail.com" || this.Paswoord != "1234")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a paswoord.",
                    "Accept");
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "Fuck yeahhhhh",
                    "Accept");
        }
        #endregion
    }
}
