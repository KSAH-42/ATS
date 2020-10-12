using System;

namespace ATS.Client.Messaging
{
	public sealed class DisableCardResponse : Response
	{
		public DisableCardResponse( bool succeed )
			: base ( succeed )
		{
		}
	}
}
