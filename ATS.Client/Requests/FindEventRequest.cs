using System;

namespace ATS.Client.Requests
{
	public sealed class FindEventRequest : BaseRequest
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
