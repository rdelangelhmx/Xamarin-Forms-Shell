﻿using Prism.Commands;
using System;
using System.Windows.Input;
using XamarinFormsShell.Navigation;

namespace XamarinFormsShell.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{

		public LoginViewModel()
		{
			LoginCommand = new DelegateCommand(Login);
		}


		public ICommand LoginCommand { get; }

		private string _username;

		public string Username
		{
			get { return _username; }
			set { SetProperty(ref _username, value); }
		}


		private string _password;

		public string Password
		{
			get { return _password; }
			set { SetProperty(ref _password, value); }
		}

		private void Login()
		{
			Navigation.NavigateToAsync(NavigationRoutes.LoginOptionsPage, options: new NavigationOptions(animated: false));
		}


	}
}
