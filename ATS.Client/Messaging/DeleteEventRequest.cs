using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteEventRequest : Request
	{
		private Guid _eventId = Guid.Empty;



		public DeleteEventRequest( Guid eventId )
		{
			ValidationHelper.CheckUniqueId( eventId );

			_eventId = eventId;
		}
	



		public Guid EventId
		{
			get => _eventId;
		}

	}
}
