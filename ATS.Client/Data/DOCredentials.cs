﻿using System;

namespace ATS.Client.Data
{
	public sealed class DOCredentials : DORoot
	{
		private string _loginId   = string.Empty;

		private string _password  = string.Empty;



		public string LoginId
		{
			get => GetField( ref _loginId );
			set => SetField( ref _loginId , DataFilter.ReplaceNull( value ) );
		}

		public string Password
		{
			get => GetField( ref _password );
			set => SetField( ref _password , DataFilter.ReplaceNull( value ) );
		}

	}
}
