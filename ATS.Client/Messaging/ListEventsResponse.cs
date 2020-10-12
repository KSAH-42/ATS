using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class ListEventsResponse : Response
	{
		private readonly IList<DOEvent> _events = null;


		public ListEventsResponse( bool succeed , IList<DOEvent> events )
			: base ( succeed )
		{
			_events = events ?? throw new ArgumentNullException( nameof( events ) );
		}



		public IList<DOEvent> Events
		{
			get => _events;
		}
	}
}
