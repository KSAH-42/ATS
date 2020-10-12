using System;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class FindEventResponse : Response
	{
		private readonly DOEvent _event = null;


		public FindEventResponse( bool succeed , DOEvent @event )
			: base( succeed )
		{
			_event = @event;
		}



		public DOEvent Event
		{
			get => _event;
		}
	}
}
