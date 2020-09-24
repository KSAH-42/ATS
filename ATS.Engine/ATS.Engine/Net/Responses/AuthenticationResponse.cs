using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class AuthenticationResponse : BaseResponse
	{
		private readonly Guid _sessionId = Guid.Empty;



		public AuthenticationResponse( Guid sessionId )
		{
			_sessionId = sessionId;
		}



		public Guid SessionId
		{
			get => _sessionId;
		}
	}
}
