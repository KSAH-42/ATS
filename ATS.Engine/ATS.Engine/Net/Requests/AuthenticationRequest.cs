using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class AuthenticationRequest : BaseRequest
	{
		private readonly string _loginId  = string.Empty;

		private readonly string _password = string.Empty;




		public AuthenticationRequest( string loginId , string password )
		{
			_loginId = loginId ?? string.Empty;
			_password= password?? string.Empty;
		}
	



		public string LoginId
		{
			get => _loginId;
		}

		public string Password
		{
			get => _password;
		}




		public override bool Validate()
		{
			return ! string.IsNullOrWhiteSpace( _loginId );
		}
	}
}
