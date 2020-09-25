using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEventsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _events = null;


		public DeleteEventsRequest( IReadOnlyCollection<Guid> events )
		{
			_events = InternalValidator.CheckCollection( events );
		}




		public IReadOnlyCollection<Guid> Events
		{
			get => _events;
		}


	}
}
