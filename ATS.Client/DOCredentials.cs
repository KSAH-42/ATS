using System;

namespace ATS.Client
{
	public sealed class DOCredentials : DOValue
	{
		private string _loginId   = string.Empty;

		private string _password  = string.Empty;



		public string LoginId
		{
			get => GetField( ref _loginId );
			set => SetField( ref _loginId , ValueFilter.Filter( value ) );
		}

		public string Password
		{
			get => GetField( ref _password );
			set => SetField( ref _password , ValueFilter.Filter( value ) );
		}

	}
}
