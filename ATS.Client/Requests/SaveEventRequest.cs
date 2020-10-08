using System;

namespace ATS.Client.Requests
{
	public sealed class SaveEventRequest : BaseRequest
	{
		private readonly DOEvent _event = null;




		public SaveEventRequest( DOEvent @event )
		{
			ValidationHelper.CheckEvent( @event );

			_event = @event;
		}

		
	

		public DOEvent Event
		{
			get => _event;
		}


	}
}
