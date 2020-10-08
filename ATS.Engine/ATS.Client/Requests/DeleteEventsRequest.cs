using System;
using System.Collections.Generic;

namespace ATS.Client.Requests
{
	public sealed class DeleteEventsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _events = null;


		public DeleteEventsRequest( IReadOnlyCollection<Guid> events )
		{
			InternalValidator.CheckCollection( events );

			_events = events;
		}




		public IReadOnlyCollection<Guid> Events
		{
			get => _events;
		}


	}
}
