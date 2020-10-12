using System;

namespace ATS.Client.Messaging
{
	public sealed class AuthenticationRequest : Request
	{
		private readonly string _loginId  = string.Empty;

		private readonly string _password = string.Empty;




		public AuthenticationRequest( string loginId , string password )
		{
			ValidationHelper.CheckLogin( loginId );

			_loginId  = loginId ;
			_password = password ?? string.Empty;
		}
	



		public string LoginId
		{
			get => _loginId;
		}

		public string Password
		{
			get => _password;
		}
	}
}
