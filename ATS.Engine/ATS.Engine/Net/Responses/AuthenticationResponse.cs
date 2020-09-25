using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class AuthenticationResponse : BaseResponse
	{
		private readonly Guid _sessionId = Guid.Empty;

		private readonly Guid _userId    = Guid.Empty;


		public AuthenticationResponse( Guid sessionId , Guid userId )
		{
			_sessionId = sessionId;
			_userId    = userId;
		}



		public Guid SessionId
		{
			get => _sessionId;
		}

		public Guid UserId
		{
			get => _userId;
		}
	}
}
