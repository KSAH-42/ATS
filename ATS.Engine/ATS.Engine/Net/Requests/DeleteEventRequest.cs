using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEventRequest : BaseRequest
	{
		private Guid _eventId = Guid.Empty;



		public DeleteEventRequest( Guid eventId )
		{
			InternalValidator.CheckUniqueId( eventId );

			_eventId = eventId;
		}
	



		public Guid EventId
		{
			get => _eventId;
		}

	}
}
