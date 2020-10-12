using System;

namespace ATS.Client.Messaging
{
	public sealed class FindEventRequest : Request
	{
		private readonly Guid _eventId = Guid.Empty;


		public FindEventRequest( Guid eventId )
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
