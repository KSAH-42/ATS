using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteEventResponse : Response
	{
		public DeleteEventResponse( bool succeed )
			: base ( succeed )
		{
		}
	}
}
