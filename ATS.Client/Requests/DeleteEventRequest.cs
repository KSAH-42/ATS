using System;

namespace ATS.Client.Requests
{
	public sealed class DeleteEventRequest : BaseRequest
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
