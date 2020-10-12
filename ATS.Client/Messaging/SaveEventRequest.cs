using System;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class SaveEventRequest : Request
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
