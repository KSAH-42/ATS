using System;

namespace ATS.Client.Messaging
{
	public sealed class AuthenticationResponse : Response
	{
		private readonly Guid _sessionId = Guid.Empty;

		private readonly Guid _userId    = Guid.Empty;


		public AuthenticationResponse( bool succeed , Guid sessionId , Guid userId )
			: base( succeed )
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
