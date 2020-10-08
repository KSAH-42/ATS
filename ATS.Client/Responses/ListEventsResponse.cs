using System;
using System.Collections.Generic;

namespace ATS.Client.Responses
{
	public sealed class ListEventsResponse : BaseResponse
	{
		private readonly IList<DOEvent> _events = null;


		public ListEventsResponse( IList<DOEvent> events )
		{
			_events = events ?? throw new ArgumentNullException( nameof( events ) );
		}



		public IList<DOEvent> Events
		{
			get => _events;
		}
	}
}
