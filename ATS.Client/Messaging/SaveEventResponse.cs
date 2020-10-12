using System;

namespace ATS.Client.Messaging
{
	public sealed class SaveEventResponse : Response
	{
		public SaveEventResponse( bool succeed )
			: base( succeed )
		{
		}
	}
}
