using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	public sealed class ListEventsRequest : Request
	{
		private readonly IReadOnlyCollection<Guid> _events = null;


		public ListEventsRequest( IReadOnlyCollection<Guid> events )
		{
			ValidationHelper.CheckCollection( events );

			_events = events;
		}

		
	

		public IReadOnlyCollection<Guid> Events
		{
			get => _events;
		}


	}
}
