using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Responses
{
	public sealed class SearchEventsResponse : BaseResponse
	{
		private readonly IList<DOEvent> _events = null;


		public SearchEventsResponse( IList<DOEvent> events )
		{
			_events = events ?? throw new ArgumentNullException( nameof( events ) );
		}



		public IList<DOEvent> Events
		{
			get => _events;
		}
	}
}
