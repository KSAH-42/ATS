using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEventRequest : BaseRequest
	{
		private Guid _eventId = Guid.Empty;



		public DeleteEventRequest( Guid eventId )
		{
			_eventId = InternalValidator.CheckUniqueId( eventId );
		}
	



		public Guid EventId
		{
			get => _eventId;
		}

	}
}
