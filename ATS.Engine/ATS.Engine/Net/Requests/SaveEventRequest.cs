using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveEventRequest : BaseRequest
	{
		private readonly DOEvent _event = null;




		public SaveEventRequest( DOEvent @event )
		{
			InternalValidator.CheckEvent( @event );

			_event = @event;
		}

		
	

		public DOEvent Event
		{
			get => _event;
		}


	}
}
