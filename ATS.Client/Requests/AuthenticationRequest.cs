using System;

namespace ATS.Client.Requests
{
	public sealed class AuthenticationRequest : BaseRequest
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
