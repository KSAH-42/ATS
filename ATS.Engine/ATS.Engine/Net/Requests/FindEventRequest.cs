using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class FindEventRequest : BaseRequest
	{
		private readonly Guid _eventId = Guid.Empty;


		public FindEventRequest( Guid eventId )
		{
			_eventId = InternalValidator.CheckUniqueId( eventId );
		}

		
	

		public Guid EventId
		{
			get => _eventId;
		}


	}
}
