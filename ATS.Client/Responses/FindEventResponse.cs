using System;

namespace ATS.Client.Responses
{
	public sealed class FindEventResponse : BaseResponse
	{
		private readonly DOEvent _event = null;


		public FindEventResponse( DOEvent @event )
		{
			_event = @event;
		}



		public DOEvent Event
		{
			get => _event;
		}
	}
}
